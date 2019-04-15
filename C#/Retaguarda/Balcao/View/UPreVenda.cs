/********************************************************************************
Title: AlbertEijePDV
Description: Janela da Pré-Venda

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
using System.Collections.Generic;
using System.Windows.Forms;
using PafEcf.VO;
using Balcao.Controller;
using Balcao.Util;

namespace Balcao.View
{

    public partial class FPreVenda : Form
    {

        //TODO: Leitor - Realize as devidas validações dessa janela.
        //TODO: Leitor - Leia com calma as especificações do PAF e deixe essa janela de acordo com o que é exigido.

        public static PreVendaController PreVendaController;
        public static ProdutoController ProdutoController;
        public static PreVendaCabecalhoVO PreVendaCabecalho;
        public static List<PreVendaDetalheVO> ListaPreVendaDetalhe;
        public static int Item;
        public static decimal TotalGeral;

        public FPreVenda()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            PreVendaController = new PreVendaController();
            ProdutoController = new ProdutoController();
            PreVendaCabecalho = new PreVendaCabecalhoVO();
            ListaPreVendaDetalhe = new List<PreVendaDetalheVO>();
            Item = 1;
            TotalGeral = 0;
            GridItens.AutoGenerateColumns = false;
        }

        private void FPreVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                botaoProduto.PerformClick();
            if (e.KeyCode == Keys.F6)
                botaoCliente.PerformClick();
            if (e.KeyCode == Keys.F8)
                botaoCancela.PerformClick();
            if (e.KeyCode == Keys.F10)
                botaoDesconto.PerformClick();
            if (e.KeyCode == Keys.F12)
                botaoGravar.PerformClick();
            if (e.KeyCode == Keys.Escape)
                botaoESC.PerformClick();
        }

        private void botaoProduto_Click(object sender, EventArgs e)
        {
            FImportaProduto FImportaProduto = new FImportaProduto();
            FImportaProduto.ShowDialog();
            EditCodigoProduto.Text = FImportaProduto.IdProdutoSelecionado.ToString();
            EditCodigoProduto.Focus();
        }

        private void botaoCliente_Click(object sender, EventArgs e)
        {
            //TODO: Leitor - Migre a janela ImportaCliente do PAF e utilize-a nesse projeto.
        }

        private void botaoCancela_Click(object sender, EventArgs e)
        {
            //TODO: Leitor - Implemente o cancelamento do Item de acordo com os requisitos do PAF.
        }

        private void botaoDesconto_Click(object sender, EventArgs e)
        {
            //TODO: Leitor - Migre a janela de desconto do PAF e utilize-a nesse projeto.
        }

        private void botaoGravar_Click(object sender, EventArgs e)
        {
            Confirma();
        }

        private void botaoESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCodigoProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (EditCodigoProduto.Text.Trim() != "")
                {
                    ProdutoVO Produto = ProdutoController.ConsultaId(Convert.ToInt32(EditCodigoProduto.Text.Trim()));
                    if (Produto != null)
                    {
                        editUnitario.Text = Produto.ValorVenda.ToString();
                        editTotalItem.Text = (Produto.ValorVenda * Convert.ToDecimal(editQuantidade.Text)).ToString("0.00");

                        PreVendaDetalheVO PreVendaDetalhe = new PreVendaDetalheVO();
                        PreVendaDetalhe.IdProduto = Produto.Id;
                        PreVendaDetalhe.Item = Item++;
                        PreVendaDetalhe.Quantidade = Convert.ToDecimal(editQuantidade.Text);
                        PreVendaDetalhe.ValorUnitario = Convert.ToDecimal(editUnitario.Text);
                        PreVendaDetalhe.ValorTotal = Convert.ToDecimal(editTotalItem.Text);
                        PreVendaDetalhe.GtinProduto = Produto.GTIN;
                        PreVendaDetalhe.NomeProduto = Produto.Nome;
                        PreVendaDetalhe.UnidadeProduto = Produto.UnidadeProduto;
                        PreVendaDetalhe.ECFICMS = Produto.TotalizadorParcial;

                        ListaPreVendaDetalhe.Add(PreVendaDetalhe);
                        GridItens.DataSource = typeof(List<PreVendaDetalheVO>); 
                        GridItens.DataSource = ListaPreVendaDetalhe;
                        GridItens.Refresh();

                        TotalGeral = TotalGeral + PreVendaDetalhe.ValorTotal;
                        labelSubtotal.Text = TotalGeral.ToString("0.00");
                        labelTotal.Text = TotalGeral.ToString("0.00");

                        EditCodigoProduto.Text = "";
                        EditCodigoProduto.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Código não cadastrado.", "Informação do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception eError)
            {
                Log.write(eError.ToString());
            }
        }

        public void Confirma()
        {
            try
            {
                PreVendaCabecalhoVO PreVendaCabecalho = new PreVendaCabecalhoVO();
                PreVendaCabecalho.IdEmpresa = Constantes.EMPRESA_BALCAO;
                PreVendaCabecalho.IdPessoa = Convert.ToInt32(editCodigoCliente.Text);
                PreVendaCabecalho.NomeDestinatario = EditNome.Text;
                PreVendaCabecalho.CpfCnpjDestinatario = editCpfCnpj.Text;
                PreVendaCabecalho.DataEmissao = DateTime.Now;
                PreVendaCabecalho.HoraEmissao = DateTime.Now.ToString("HH:mm:ss");
                PreVendaCabecalho.Situacao = "P";
                PreVendaCabecalho.TaxaAcrescimo = 0;
                PreVendaCabecalho.Acrescimo = 0;
                PreVendaCabecalho.TaxaDesconto = 0;
                PreVendaCabecalho.Desconto = 0;
                PreVendaCabecalho.SubTotal = TotalGeral;
                PreVendaCabecalho.Valor = TotalGeral;

                PreVendaController.InserePreVenda(PreVendaCabecalho, ListaPreVendaDetalhe);

                //TODO: Leitor - Não é permitido imprimir a pré-venda, mas você deve pelo menos informar seu número para o cliente. Implemente isso.
                MessageBox.Show("Pré-Venda gravada com sucesso!", "Informação do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception eError)
            {
                Log.write(eError.ToString());
            }

        }

    }

}
