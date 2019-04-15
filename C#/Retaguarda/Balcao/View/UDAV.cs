/********************************************************************************
Title: AlbertEijePDV
Description: Janela do DAV

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

    public partial class FDAV : Form
    {

        //TODO: Leitor - Realize as devidas validações dessa janela.
        //TODO: Leitor - Leia com calma as especificações do PAF e deixe essa janela de acordo com o que é exigido.

        public static DAVController DAVController;
        public static ProdutoController ProdutoController;
        public static DavCabecalhoVO DavCabecalho;
        public static List<DavDetalheVO> ListaDavDetalhe;
        public static int Item;
        public static decimal TotalGeral;

        public FDAV()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            DAVController = new DAVController();
            ProdutoController = new ProdutoController();
            DavCabecalho = new DavCabecalhoVO();
            ListaDavDetalhe = new List<DavDetalheVO>();
            Item = 1;
            TotalGeral = 0;
            GridItens.AutoGenerateColumns = false;
        }

        private void FDAV_KeyDown(object sender, KeyEventArgs e)
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

                        DavDetalheVO DavDetalhe = new DavDetalheVO();
                        DavDetalhe.IdProduto = Produto.Id;
                        DavDetalhe.DataEmissao = DateTime.Now;
                        DavDetalhe.Item = Item++;
                        DavDetalhe.Quantidade = Convert.ToDecimal(editQuantidade.Text);
                        DavDetalhe.ValorUnitario = Convert.ToDecimal(editUnitario.Text);
                        DavDetalhe.ValorTotal = Convert.ToDecimal(editTotalItem.Text);
                        DavDetalhe.GtinProduto = Produto.GTIN;
                        DavDetalhe.NomeProduto = Produto.Nome;
                        DavDetalhe.UnidadeProduto = Produto.UnidadeProduto;
                        DavDetalhe.TotalizadorParcial = Produto.TotalizadorParcial;

                        ListaDavDetalhe.Add(DavDetalhe);
                        GridItens.DataSource = typeof(List<DavDetalheVO>); 
                        GridItens.DataSource = ListaDavDetalhe;
                        GridItens.Refresh();

                        TotalGeral = TotalGeral + DavDetalhe.ValorTotal;
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
                DavCabecalhoVO DAVCabecalho = new DavCabecalhoVO();
                DAVCabecalho.IdEmpresa = Constantes.EMPRESA_BALCAO;
                DAVCabecalho.IdPessoa = Convert.ToInt32(editCodigoCliente.Text);
                DAVCabecalho.NomeDestinatario = EditNome.Text;
                DAVCabecalho.CpfCnpjDestinatario = editCpfCnpj.Text;
                DAVCabecalho.DataEmissao = DateTime.Now;
                DAVCabecalho.HoraEmissao = DateTime.Now.ToString("HH:mm:ss");
                DAVCabecalho.Situacao = "P";
                DAVCabecalho.TaxaAcrescimo = 0;
                DAVCabecalho.Acrescimo = 0;
                DAVCabecalho.TaxaDesconto = 0;
                DAVCabecalho.Desconto = 0;
                DAVCabecalho.Subtotal = TotalGeral;
                DAVCabecalho.Valor = TotalGeral;

                DAVController.InsereDAV(DAVCabecalho, ListaDavDetalhe);

                if (MessageBox.Show("Deseja imprimir o DAV?", "Pergunta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //TODO: Leitor - Analise o arquivo 'DAV.rep'. Relatório feito no ReportManager. Estude o ReportManager e veja como chamar o relatório.
                }

                MessageBox.Show("DAV gravado com sucesso!", "Informação do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception eError)
            {
                Log.write(eError.ToString());
            }

        }
    }

}
