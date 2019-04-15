/********************************************************************************
Title: AlbertEijePDV
Description: Janela Principal

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


using System.Windows.Forms;

namespace Balcao.View
{


    public partial class FMenu : Form
    {

        public FMenu()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
        }


        private void botaoDav_Click(object sender, System.EventArgs e)
        {
            FDAV FDAV = new FDAV();
            FDAV.ShowDialog();
        }

        private void botaoPreVenda_Click(object sender, System.EventArgs e)
        {
            FPreVenda FPreVenda = new FPreVenda();
            FPreVenda.ShowDialog();
        }

        private void botaoProduto_Click(object sender, System.EventArgs e)
        {
            FCadastroProduto FCadastroProduto = new FCadastroProduto();
            FCadastroProduto.ShowDialog();
        }

        private void botaoCarga_Click(object sender, System.EventArgs e)
        {
            FPDVCarga FPDVCarga = new FPDVCarga();
            FPDVCarga.ShowDialog();
        }

        private void botaoSair_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Sair do Sistema?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }

}
