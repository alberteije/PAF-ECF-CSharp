/********************************************************************************
Title: T2TiPDV
Description: Pesquisa por cliente e importacao para a venda.

The MIT License

Copyright: Copyright (C) 2014 T2Ti.COM

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

@author T2Ti.COM
@version 2.0
********************************************************************************/


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PafEcf.DTO;
using PafEcf.Controller;

namespace PafEcf.View
{

    public partial class ImportaCliente : Form
    {

        private static List<ClienteDTO> ListaCliente;
        public static string QuemChamou;

        public ImportaCliente()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            ListaCliente = new List<ClienteDTO>();
            GridPrincipal.AutoGenerateColumns = false;
            EditLocaliza.Focus();
        }

        private void botaoConfirma_Click(object sender, EventArgs e)
        {
            Confirma();
        }

        private void botaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SpeedButton1_Click(object sender, EventArgs e)
        {
            Localiza();
        }

        private void FImportaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Localiza();
            if (e.KeyCode == Keys.F12)
                botaoConfirma.PerformClick();
            if (e.KeyCode == Keys.Escape)
                botaoCancela.PerformClick();
        }

        public void Localiza()
        {
            string ProcurePor = "%" + EditLocaliza.Text + "%";
            string Filtro = "Nome like " + ProcurePor;
            ListaCliente = (List<ClienteDTO>)ClienteController.ConsultaClienteLista(Filtro);
            Label2.Text = ListaCliente.Count.ToString() + " clientes localizados.";
            GridPrincipal.DataSource = ListaCliente;
            if (ListaCliente.Count > 0)
                GridPrincipal.Focus();
        }

        public void Confirma()
        {
            if (ListaCliente.Count > 0)
            {
                if (ListaCliente[GridPrincipal.CurrentRow.Index].CpfCnpj != "")
                {
                    if (QuemChamou == "NF")
                    {
                        /*
                        FNotaFiscal.editCpfCnpj.Text = ListaCliente[GridPrincipal.CurrentRow.Index].CpfOuCnpj;
                        FNotaFiscal.editNome.Text = ListaCliente[GridPrincipal.CurrentRow.Index].Nome;
                        FNotaFiscal.editCodigoCliente.asint = ListaCliente[GridPrincipal.CurrentRow.Index].Id.ToString();
                         */
                    }
                    else if (QuemChamou == "IDENTIFICA")
                    {
                        IdentificaCliente.EditCpfCnpj.Text = ListaCliente[GridPrincipal.CurrentRow.Index].CpfCnpj;
                        IdentificaCliente.EditNome.Text = ListaCliente[GridPrincipal.CurrentRow.Index].Nome;
                        IdentificaCliente.EditIDCliente.Text = ListaCliente[GridPrincipal.CurrentRow.Index].Id.ToString();
                    }
                }
                else
                    MessageBox.Show("Cliente sem CPF ou CNPJ cadastrado.", "Informa��o do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void GridPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EditLocaliza.Focus();
        }

    }

}
