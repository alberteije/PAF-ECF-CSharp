/********************************************************************************
Title: AlbertEijePDV
Description: Janela para exportar dados para os caixas

The MIT License

Copyright: Copyright (C) 2012 Albert Eije

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.

       The author may be contacted at:
           alberteije@gmail.com

@author Albert Eije
@version 1.0
********************************************************************************/


using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PafEcf.VO;
using Balcao.Util;
using Balcao.Infra;

namespace Balcao.View
{


    public partial class FPDVCarga : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader leitor;
        public string ConsultaSQL;

        //TODO: Leitor - Configure o Path a partir de um arquivo de conexão. Crie a rotina para exportar a carga para cada um dos caixas existentes na empresa.
        private string PathExporta = "C:\\PAFECF\\Caixa1\\carga.txt";

        public FPDVCarga()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            conexao = dbConnection.conectarRetaguarda();
        }

        private void botaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoConfirma_Click(object sender, EventArgs e)
        {
            Confirma();
        }

        private void FPDVCarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                botaoCancela.PerformClick();
            if (e.KeyCode == Keys.F12)
                botaoConfirma.PerformClick();
        }


        public void MarcarTodosCheckBox()
        {
            foreach (Control c in GroupBox1.Controls)
            {
                if (c is CheckBox)
                    (c as CheckBox).Checked = true;
            }
        }


        public void DesmarcarTodosCheckBox()
        {
            foreach (Control c in GroupBox1.Controls)
            {
                if (c is CheckBox)
                    (c as CheckBox).Checked = false;
            }
        }

        private void cbMarcarTodos_Click(object sender, EventArgs e)
        {
            MarcarTodosCheckBox();
        }

        private void cbDesmarcarTodos_Click(object sender, EventArgs e)
        {
            DesmarcarTodosCheckBox();
        }

        private void boxProduto_Click(object sender, EventArgs e)
        {
            if (boxProduto.Checked)
                boxProdutoSelecionado.Checked = false;
        }

        private void boxProdutoSelecionado_Click(object sender, EventArgs e)
        {
            if (boxProdutoSelecionado.Checked)
                boxProduto.Checked = false;
        }


        //TODO: Leitor - Verifique se a exportação implemetada está 100%. Implemente as demais.
        public void Confirma()
        {
            if (MessageBox.Show("Deseja gerar os arquivos de exportação para os terminais de caixa?", "Pergunta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (File.Exists(PathExporta))
                {
                    File.Delete(PathExporta);
                    Application.DoEvents();
                }

                try
                {

                    if (boxProduto.Checked) // OK
                    {
                        ExportaUnidadeProduto();
                        ExportaAliquotas();
                        ExportaProduto();
                    }

                    if (boxCliente.Checked) // OK
                    {
                        ExportaSituacaoCliente();
                        ExportaCliente();
                    }

                    if (boxTurno.Checked) // OK
                    {
                        ExportaTurno();
                    }

                    if (boxFuncionario.Checked) // OK
                    {
                        ExportaFuncionario();
                    }

                    if (boxOperador.Checked) // OK
                    {
                        ExportaOperador();
                    }

                    if (boxContador.Checked) // OK
                    {
                        ExportaEmpresa();
                        ExportaContador();
                    }

                    if (boxEmpresa.Checked) // OK
                    {
                        ExportaEmpresa();
                    }

                    if (boxImpressora.Checked) // OK
                    {
                        ExportaImpressora();
                    }

                    if (boxTipoPagamento.Checked)
                    {
                        ExportaTipoPagamento();
                    }

                    if (boxTerminalCaixa.Checked)
                    {
                        ExportaTerminalCaixa();
                    }

                    if (boxAliquotas.Checked) // OK
                    {
                        ExportaAliquotas();
                    }

                    if (boxProdutoSelecionado.Checked) // OK
                    {
                        ExportaUnidadeProduto();
                        ExportaAliquotas();
                        ExportaProdutoSelecionado();
                    }

                }
                catch (Exception eError)
                {
                    Log.write(eError.ToString());
                }

            }
        }


        public void ExportaSituacaoCliente()
        {
        }


        public void ExportaTurno()
        {
            string ConsultaSQL = "select * from ECF_TURNO";
            System.IO.TextWriter Arquivo;
            try
            {
                Arquivo = System.IO.File.AppendText(PathExporta);

                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                TurnoVO Turno;
                string Linha = "";

                while (leitor.Read())
                {
                    Turno = new TurnoVO();

                    Turno.Id = Convert.ToInt32(leitor["ID"]);
                    Turno.Descricao = Convert.ToString(leitor["DESCRICAO"]);
                    Turno.HoraInicio = Convert.ToString(leitor["HORA_INICIO"]);
                    Turno.HoraFim = Convert.ToString(leitor["HORA_FIM"]);

                    Linha = "TURNO|'"
                            + Turno.Id + "'|'"
                            + Turno.Descricao + "'|'"
                            + Turno.HoraInicio + "'|'"
                            + Turno.HoraFim + "'|";

                    Arquivo.WriteLine(Linha);
                }
                Arquivo.Close();
            }
            catch (Exception eError)
            {
                Log.write(eError.ToString());
            }
            finally
            {
                if (leitor != null)
                    leitor.Close();
            }

        }


        public void ExportaTerminalCaixa()
        {
        }


        public void ExportaTipoPagamento()
        {
        }


        public void ExportaAliquotas()
        {
        }

        public void ExportaCliente()
        {
        }


        public void ExportaContador()
        {
        }


        public void ExportaEmpresa()
        {
        }


        public void ExportaFuncionario()
        {
        }


        public void ExportaImpressora()
        {
        }


        public void ExportaOperador()
        {
        }


        public void ExportaProduto()
        {
        }


        public void ExportaProdutoSelecionado()
        {
        }


        public void ExportaUnidadeProduto()
        {
        }


        public void FormClose(object sender, EventArgs e)
        {
        }


        public void FormCreate(object Sender)
        {
        }

        public void GravaLogExportacao(string Erro)
        {
        }

    }


}
