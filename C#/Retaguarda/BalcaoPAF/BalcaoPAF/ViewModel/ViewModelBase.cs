using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Controls;
using System.Windows.Input;
using CloseableTabItemDemo;
using ExportarParaArquivo;
using BalcaoPAF.ServidorReference;
using BalcaoPAF.View;

namespace BalcaoPAF.ViewModel
{

    public class ViewModelBase : INotifyPropertyChanged
    {
                
        #region Variáveis Command
        protected ICommand PagSeguinteCommand;
        protected ICommand PagAnteriorCommand;
        protected ICommand BotaoInserirCommand;
        protected ICommand BotaoAlterarCommand;
        protected ICommand BotaoExcluirCommand;
        protected ICommand BotaoImprimirCommand;
        protected ICommand BotaoCancelarCommand;
        protected ICommand BotaoSalvarCommand;
        protected ICommand BotaoLocalizarCommand;
        protected ICommand BotaoExportarXlsCommand;
        protected ICommand BotaoExportarCsvCommand;
        protected ICommand BotaoExportarTxtCommand;
        protected ICommand BotaoExportarRtfCommand;
        #endregion

        #region Controle de Acesso
        /*
        public IList<ViewControleAcessoDTO> ListaControleAcesso = new List<ViewControleAcessoDTO>();
        public static UsuarioDTO UsuarioLogado = new UsuarioDTO();
        public ViewControleAcessoDTO ControleAcesso;

        public void Acesso(int papel, String formulario)
        {
            try
            {
                using (ServicoBalcaoPAF Servico = new ServicoBalcaoPAF())
                {
                    ViewControleAcessoDTO ControleAcesso = new ViewControleAcessoDTO();
                    ControleAcesso.IdPapel = papel;
                    ControleAcesso.Formulario = formulario;
                    List<ViewControleAcessoDTO> ListaServ = Servico.SelectControleAcesso(ControleAcesso);

                    ListaControleAcesso.Clear();

                    foreach (ViewControleAcessoDTO objAdd in ListaServ)
                    {
                        ListaControleAcesso.Add(objAdd);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         */ 
        #endregion

        #region Navegação Registros
        protected int IndiceNavegacao;
        public bool NavegaPaginaAnterior { get; set; }
        public bool NavegaPaginaSeguinte { get; set; }
        
        public int QuantidadeCarregada { get; set; }
        public const int QuantidadePagina = 20;
        public string Filtro { get; set; }

        public void ControlarNavegacao() 
        {
            NavegaPaginaAnterior = IndiceNavegacao > 0;
            NavegaPaginaSeguinte = QuantidadePagina == QuantidadeCarregada;
            notifyPropertyChanged("NavegaPaginaAnterior");
            notifyPropertyChanged("NavegaPaginaSeguinte");
            //
            if (DataGridExportacao != null)
                PodeExportar = DataGridExportacao.Items.Count > 0;
            else
                PodeExportar = false;
            notifyPropertyChanged("PodeExportar");
        }
        #endregion

        #region Exportação Dados
        public static DataGrid DataGridExportacao;
        public bool PodeExportar { get; set; }

        public void ExportarDataGrid(ExportarParaArquivo.Formato formato)
        {
            if (DataGridExportacao.HasItems)
            {
                Exportar Exportar = new Exportar(formato);
                Exportar.exportarDataGrid(DataGridExportacao);
            }
            else
                throw new Exception("Não há itens a serem exportados.");
        }
        #endregion

        [Conditional("DEBUG")]
        private void checkIfPropertyNameExists(String propertyName)
        {
            Type type = this.GetType();
            Debug.Assert(
              type.GetProperty(propertyName) != null,
              propertyName + " propriedade não encontrada : " + type.FullName);
        }


        public void NovaPagina(UserControl janela, String cabecalho)
        {
            Boolean Achou = false;

            CloseableTabItem TabItem = new CloseableTabItem();
            TabItem.Header = cabecalho;
            TabItem.Content = janela;

            foreach (TabItem tab in BalcaoPAFPrincipal.TabPrincipal.Items)
            {
                if (tab.Header == TabItem.Header)
                {
                    Achou = true;
                    tab.Focus();
                }
            }

            if (!Achou)
            {
                BalcaoPAFPrincipal.TabPrincipal.Items.Add(TabItem);
                TabItem.Focus();
            }
        }

        #region Impressão
        public System.Windows.Visibility ExibeBotaoImprimir { get; set; }

        protected string SalvarArquivoTempLocal(System.IO.MemoryStream pArquivo, string pNome)
        {
            try
            {
                string caminhoTemp = System.IO.Path.GetTempPath() + pNome;

                if (!File.Exists(caminhoTemp))
                {
                    using (FileStream fs = new FileStream(caminhoTemp, FileMode.Create, FileAccess.ReadWrite))
                    {
                        pArquivo.WriteTo(fs);
                        fs.Close();
                    }
                }
                return caminhoTemp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        public void notifyPropertyChanged(String propertyName)
        {
            checkIfPropertyNameExists(propertyName);
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }

}
