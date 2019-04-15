namespace Balcao.View
{
	partial class FMenu
    {
		private System.Windows.Forms.StatusStrip LinhaStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		// Required designer variable.
		private System.ComponentModel.IContainer components = null;

		// Clean up any resources being used.
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.LinhaStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botaoDav = new System.Windows.Forms.ToolStripButton();
            this.botaoPreVenda = new System.Windows.Forms.ToolStripButton();
            this.botaoProduto = new System.Windows.Forms.ToolStripButton();
            this.botaoCarga = new System.Windows.Forms.ToolStripButton();
            this.botaoSair = new System.Windows.Forms.ToolStripButton();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaCargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinhaStatus
            // 
            this.LinhaStatus.BackColor = System.Drawing.Color.White;
            this.LinhaStatus.Location = new System.Drawing.Point(0, 408);
            this.LinhaStatus.Name = "LinhaStatus";
            this.LinhaStatus.Size = new System.Drawing.Size(688, 22);
            this.LinhaStatus.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoDav,
            this.botaoPreVenda,
            this.botaoProduto,
            this.botaoCarga,
            this.toolStripSeparator1,
            this.botaoSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(688, 55);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.movimentoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préVendaToolStripMenuItem,
            this.dAVToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.exportaCargaToolStripMenuItem});
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.movimentoToolStripMenuItem.Text = "Movimento";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // botaoDav
            // 
            this.botaoDav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoDav.Image = global::Balcao.Properties.Resources.telaDocumento04;
            this.botaoDav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoDav.Name = "botaoDav";
            this.botaoDav.Size = new System.Drawing.Size(52, 52);
            this.botaoDav.Text = "Emissão de DAV";
            this.botaoDav.Click += new System.EventHandler(this.botaoDav_Click);
            // 
            // botaoPreVenda
            // 
            this.botaoPreVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoPreVenda.Image = global::Balcao.Properties.Resources.telaDocumento07;
            this.botaoPreVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoPreVenda.Name = "botaoPreVenda";
            this.botaoPreVenda.Size = new System.Drawing.Size(52, 52);
            this.botaoPreVenda.Text = "Emissão de Pré-Venda";
            this.botaoPreVenda.Click += new System.EventHandler(this.botaoPreVenda_Click);
            // 
            // botaoProduto
            // 
            this.botaoProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoProduto.Image = global::Balcao.Properties.Resources.telaCarrinho02;
            this.botaoProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoProduto.Name = "botaoProduto";
            this.botaoProduto.Size = new System.Drawing.Size(52, 52);
            this.botaoProduto.Text = "Cadastro de Produto";
            this.botaoProduto.Click += new System.EventHandler(this.botaoProduto_Click);
            // 
            // botaoCarga
            // 
            this.botaoCarga.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoCarga.Image = global::Balcao.Properties.Resources.telaMesclar01;
            this.botaoCarga.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoCarga.Name = "botaoCarga";
            this.botaoCarga.Size = new System.Drawing.Size(52, 52);
            this.botaoCarga.Text = "Gera Carga para Caixas";
            this.botaoCarga.Click += new System.EventHandler(this.botaoCarga_Click);
            // 
            // botaoSair
            // 
            this.botaoSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoSair.Image = global::Balcao.Properties.Resources.telaSair01;
            this.botaoSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(52, 52);
            this.botaoSair.Text = "Sair do Balcão";
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Balcao.Properties.Resources._21botaoSair;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // préVendaToolStripMenuItem
            // 
            this.préVendaToolStripMenuItem.Image = global::Balcao.Properties.Resources._21botaoMenuPrincipal;
            this.préVendaToolStripMenuItem.Name = "préVendaToolStripMenuItem";
            this.préVendaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.préVendaToolStripMenuItem.Text = "Pré-Venda";
            this.préVendaToolStripMenuItem.Click += new System.EventHandler(this.botaoPreVenda_Click);
            // 
            // dAVToolStripMenuItem
            // 
            this.dAVToolStripMenuItem.Image = global::Balcao.Properties.Resources._21botaoMenuOperacoes;
            this.dAVToolStripMenuItem.Name = "dAVToolStripMenuItem";
            this.dAVToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dAVToolStripMenuItem.Text = "DAV";
            this.dAVToolStripMenuItem.Click += new System.EventHandler(this.botaoDav_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Image = global::Balcao.Properties.Resources._21botaoMenuFiscal;
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.botaoProduto_Click);
            // 
            // exportaCargaToolStripMenuItem
            // 
            this.exportaCargaToolStripMenuItem.Image = global::Balcao.Properties.Resources._21botaoGaveta;
            this.exportaCargaToolStripMenuItem.Name = "exportaCargaToolStripMenuItem";
            this.exportaCargaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportaCargaToolStripMenuItem.Text = "Exporta Carga";
            this.exportaCargaToolStripMenuItem.Click += new System.EventHandler(this.botaoCarga_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::Balcao.Properties.Resources._21botaoAjuda;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // FMenu
            // 
            this.ClientSize = new System.Drawing.Size(688, 430);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LinhaStatus);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(187, 375);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "Sistema Balcão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoDav;
        private System.Windows.Forms.ToolStripButton botaoPreVenda;
        private System.Windows.Forms.ToolStripButton botaoProduto;
        private System.Windows.Forms.ToolStripButton botaoCarga;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton botaoSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportaCargaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;

	}
}
