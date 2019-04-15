using BalcaoPAF.Command;
using BalcaoPAF.Model;
using BalcaoPAF.ServidorReference;
using SearchWindow;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace BalcaoPAF.ViewModel
{
    public class DavCabecalhoViewModel : ViewModelBase
    {

        #region Variáveis

        public ObservableCollection<DavCabecalhoDTO> ListaDavCabecalho { get; set; }
        private DavCabecalhoDTO _DavCabecalhoSelected;
        private bool _isEditar { get; set; }

        #endregion

        #region Construtor
        public DavCabecalhoViewModel()
        {
            try
            {
                ListaDavCabecalho = new ObservableCollection<DavCabecalhoDTO>();
                IndiceNavegacao = 0;
                QuantidadeCarregada = 0;
                Filtro = "";
                ControlarNavegacao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Infra
        public DavCabecalhoDTO DavCabecalhoSelected
        {
            get { return _DavCabecalhoSelected; }
            set
            {
                _DavCabecalhoSelected = value;
                notifyPropertyChanged("DavCabecalhoSelected");
            }
        }

        public bool IsEditar
        {
            get { return _isEditar; }
            set
            {
                _isEditar = value;
                notifyPropertyChanged("IsEditar");
                notifyPropertyChanged("IsListar");
            }
        }

        public bool IsListar
        {
            get { return !_isEditar; }
            set
            {
                _isEditar = !value;
                notifyPropertyChanged("IsEditar");
                notifyPropertyChanged("IsListar");
            }
        }

        public void PesquisarPessoa()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(PessoaDTO),
                    typeof(ServicoBalcaoPAF));

                if (searchWindow.ShowDialog() == true)
                {
                    DavCabecalhoSelected.Pessoa = (PessoaDTO)searchWindow.itemSelecionado;
                    notifyPropertyChanged("DavCabecalhoSelected");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CRUD
        public void SalvarAtualizarDavCabecalho()
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    Servico.SalvarAtualizarDavCabecalho(DavCabecalhoSelected);
                    DavCabecalhoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarListaDavCabecalho(int pagina)
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    if (pagina == 0)
                        IndiceNavegacao = 0;
                    else if (pagina > 0 && ListaDavCabecalho.Count == QuantidadePagina)
                        IndiceNavegacao += QuantidadePagina;
                    else if (pagina < 0 && IndiceNavegacao != 0)
                        IndiceNavegacao -= QuantidadePagina;

                    DavCabecalhoDTO DavCabecalho = new DavCabecalhoDTO();
                    if (!Filtro.Trim().Equals(""))
                    {
                        DavCabecalho.NomeDestinatario = Filtro;
                    }

                    IList<DavCabecalhoDTO> ListaServ = Servico.SelectDavCabecalhoPagina(IndiceNavegacao, true, QuantidadePagina, true, DavCabecalho);

                    ListaDavCabecalho.Clear();

                    foreach (DavCabecalhoDTO objAdd in ListaServ)
                    {
                        ListaDavCabecalho.Add(objAdd);
                    }
                    DavCabecalhoSelected = null;
                }
                QuantidadeCarregada = ListaDavCabecalho.Count;
                ControlarNavegacao();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ExcluirDavCabecalho()
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    Servico.DeleteDavCabecalho(DavCabecalhoSelected);
                    DavCabecalhoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Controle de Ativação dos Botões
        public void BotaoInserir()
        {
            try
            {
                DavCabecalhoSelected = new DavCabecalhoDTO();
                IsEditar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
        public void BotaoAlterar()
        {
            try
            {
                if (DavCabecalhoSelected != null)
                    IsEditar = true;
                else
                    MessageBox.Show("Selecione um elemento na lista.", "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void BotaoExcluir()
        {
            try
            {
                if (DavCabecalhoSelected != null)
                {
                    if (MessageBox.Show("Tem Certeza Que Deseja Excluir o Registro?", "Pergunta do Sistema", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ExcluirDavCabecalho();
                        MessageBox.Show("Exclusão efetuada com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                        AtualizarListaDavCabecalho(IndiceNavegacao);
                    }
                }
                else
                    MessageBox.Show("Selecione um elemento na lista.", "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void BotaoCancelar()
        {
            try
            {
                IsEditar = false;
                DavCabecalhoSelected = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void BotaoSalvar()
        {
            try
            {
                SalvarAtualizarDavCabecalho();
                MessageBox.Show("Salvo com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                AtualizarListaDavCabecalho(IndiceNavegacao);
                IsEditar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void BotaoLocalizar()
        {
            try
            {
                AtualizarListaDavCabecalho(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Comandos Botões
        public ICommand InserirCommand
        {
            get
            {
                if (BotaoInserirCommand == null)
                {
                    BotaoInserirCommand = new RelayCommand
                    (
                        param =>
                        {
                            BotaoInserir();
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoInserirCommand;
            }
        }

        public ICommand AlterarCommand
        {
            get
            {
                if (BotaoAlterarCommand == null)
                {
                    BotaoAlterarCommand = new RelayCommand
                    (
                        param =>
                        {
                            BotaoAlterar();
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoAlterarCommand;
            }
        }

        public ICommand ExcluirCommand
        {
            get
            {
                if (BotaoExcluirCommand == null)
                {
                    BotaoExcluirCommand = new RelayCommand
                    (
                        param =>
                        {
                            BotaoExcluir();
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoExcluirCommand;
            }
        }

        public ICommand CancelarCommand
        {
            get
            {
                if (BotaoCancelarCommand == null)
                {
                    BotaoCancelarCommand = new RelayCommand
                    (
                        param =>
                        {
                            notifyPropertyChanged("DavCabecalhoSelected");
                            BotaoCancelar();
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoCancelarCommand;
            }
        }

        public ICommand SalvarCommand
        {
            get
            {
                if (BotaoSalvarCommand == null)
                {
                    BotaoSalvarCommand = new RelayCommand
                    (
                        param =>
                        {
                            BotaoSalvar();
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoSalvarCommand;
            }
        }

        public ICommand LocalizarCommand
        {
            get
            {
                if (BotaoLocalizarCommand == null)
                {
                    BotaoLocalizarCommand = new RelayCommand
                    (
                        param =>
                        {
                            BotaoLocalizar();
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoLocalizarCommand;
            }
        }

        public ICommand ExportarXlsCommand
        {
            get
            {
                if (BotaoExportarXlsCommand == null)
                {
                    BotaoExportarXlsCommand = new RelayCommand
                    (
                        param =>
                        {
                            DataGridExportacao.ItemsSource = ListaDavCabecalho;
                            ExportarDataGrid((ExportarParaArquivo.Formato)(0));
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoExportarXlsCommand;
            }
        }

        public ICommand ExportarCsvCommand
        {
            get
            {
                if (BotaoExportarCsvCommand == null)
                {
                    BotaoExportarCsvCommand = new RelayCommand
                    (
                        param =>
                        {
                            DataGridExportacao.ItemsSource = ListaDavCabecalho;
                            ExportarDataGrid((ExportarParaArquivo.Formato)(1));
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoExportarCsvCommand;
            }
        }

        public ICommand ExportarTxtCommand
        {
            get
            {
                if (BotaoExportarTxtCommand == null)
                {
                    BotaoExportarTxtCommand = new RelayCommand
                    (
                        param =>
                        {
                            DataGridExportacao.ItemsSource = ListaDavCabecalho;
                            ExportarDataGrid((ExportarParaArquivo.Formato)(2));
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoExportarTxtCommand;
            }
        }

        public ICommand ExportarRtfCommand
        {
            get
            {
                if (BotaoExportarRtfCommand == null)
                {
                    BotaoExportarRtfCommand = new RelayCommand
                    (
                        param =>
                        {
                            DataGridExportacao.ItemsSource = ListaDavCabecalho;
                            ExportarDataGrid((ExportarParaArquivo.Formato)(3));
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return BotaoExportarRtfCommand;
            }
        }
        #endregion

        #region Comandos Navegação
        public ICommand PaginaSeguinteCommand
        {
            get
            {
                if (PagSeguinteCommand == null)
                {
                    PagSeguinteCommand = new RelayCommand
                    (
                        param =>
                        {
                            AtualizarListaDavCabecalho(1);
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return PagSeguinteCommand;
            }
        }

        public ICommand PaginaAnteriorCommand
        {
            get
            {
                if (PagAnteriorCommand == null)
                {
                    PagAnteriorCommand = new RelayCommand
                    (
                        param =>
                        {
                            AtualizarListaDavCabecalho(-1);
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return PagAnteriorCommand;
            }
        }
        #endregion


    }
}
