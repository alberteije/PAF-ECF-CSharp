namespace Balcao.View
{
	partial class FPDVCarga
    {
		private System.Windows.Forms.Panel PanelFiltroRapido;
		private System.Windows.Forms.PictureBox Image1;
		internal System.Windows.Forms.Label Label2;
		private System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.CheckBox boxProduto;
		internal System.Windows.Forms.CheckBox boxCliente;
		internal System.Windows.Forms.CheckBox boxTurno;
		internal System.Windows.Forms.CheckBox boxFuncionario;
		internal System.Windows.Forms.CheckBox boxOperador;
		internal System.Windows.Forms.CheckBox boxContador;
		internal System.Windows.Forms.CheckBox boxEmpresa;
		internal System.Windows.Forms.CheckBox boxImpressora;
		private System.Windows.Forms.GroupBox RadioMarcarTodos;
		internal System.Windows.Forms.RadioButton cbMarcarTodos;
		internal System.Windows.Forms.RadioButton cbDesmarcarTodos;
		internal System.Windows.Forms.CheckBox boxTipoPagamento;
		internal System.Windows.Forms.CheckBox boxTerminalCaixa;
		internal System.Windows.Forms.CheckBox boxAliquotas;
		internal System.Windows.Forms.CheckBox boxProdutoSelecionado;
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
            this.PanelFiltroRapido = new System.Windows.Forms.Panel();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.boxProduto = new System.Windows.Forms.CheckBox();
            this.boxCliente = new System.Windows.Forms.CheckBox();
            this.boxTurno = new System.Windows.Forms.CheckBox();
            this.boxFuncionario = new System.Windows.Forms.CheckBox();
            this.boxOperador = new System.Windows.Forms.CheckBox();
            this.boxContador = new System.Windows.Forms.CheckBox();
            this.boxEmpresa = new System.Windows.Forms.CheckBox();
            this.boxImpressora = new System.Windows.Forms.CheckBox();
            this.RadioMarcarTodos = new System.Windows.Forms.GroupBox();
            this.cbMarcarTodos = new System.Windows.Forms.RadioButton();
            this.cbDesmarcarTodos = new System.Windows.Forms.RadioButton();
            this.boxTipoPagamento = new System.Windows.Forms.CheckBox();
            this.boxTerminalCaixa = new System.Windows.Forms.CheckBox();
            this.boxAliquotas = new System.Windows.Forms.CheckBox();
            this.boxProdutoSelecionado = new System.Windows.Forms.CheckBox();
            this.botaoConfirma = new System.Windows.Forms.Button();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.PanelFiltroRapido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.RadioMarcarTodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFiltroRapido
            // 
            this.PanelFiltroRapido.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelFiltroRapido.Controls.Add(this.Image1);
            this.PanelFiltroRapido.Controls.Add(this.Label2);
            this.PanelFiltroRapido.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFiltroRapido.Location = new System.Drawing.Point(0, 0);
            this.PanelFiltroRapido.Name = "PanelFiltroRapido";
            this.PanelFiltroRapido.Size = new System.Drawing.Size(430, 65);
            this.PanelFiltroRapido.TabIndex = 0;
            // 
            // Image1
            // 
            this.Image1.Image = global::Balcao.Properties.Resources.telaMesclar01;
            this.Image1.Location = new System.Drawing.Point(7, 7);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(48, 49);
            this.Image1.TabIndex = 0;
            this.Image1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(72, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(333, 27);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Exporta dados para os caixas";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.boxProduto);
            this.GroupBox1.Controls.Add(this.boxCliente);
            this.GroupBox1.Controls.Add(this.boxTurno);
            this.GroupBox1.Controls.Add(this.boxFuncionario);
            this.GroupBox1.Controls.Add(this.boxOperador);
            this.GroupBox1.Controls.Add(this.boxContador);
            this.GroupBox1.Controls.Add(this.boxEmpresa);
            this.GroupBox1.Controls.Add(this.boxImpressora);
            this.GroupBox1.Controls.Add(this.RadioMarcarTodos);
            this.GroupBox1.Controls.Add(this.boxTipoPagamento);
            this.GroupBox1.Controls.Add(this.boxTerminalCaixa);
            this.GroupBox1.Controls.Add(this.boxAliquotas);
            this.GroupBox1.Controls.Add(this.boxProdutoSelecionado);
            this.GroupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(8, 68);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(411, 223);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // boxProduto
            // 
            this.boxProduto.AutoSize = true;
            this.boxProduto.Location = new System.Drawing.Point(16, 77);
            this.boxProduto.Name = "boxProduto";
            this.boxProduto.Size = new System.Drawing.Size(158, 21);
            this.boxProduto.TabIndex = 0;
            this.boxProduto.Text = "Todos os Produtos";
            this.boxProduto.Click += new System.EventHandler(this.boxProduto_Click);
            // 
            // boxCliente
            // 
            this.boxCliente.AutoSize = true;
            this.boxCliente.Location = new System.Drawing.Point(16, 100);
            this.boxCliente.Name = "boxCliente";
            this.boxCliente.Size = new System.Drawing.Size(81, 21);
            this.boxCliente.TabIndex = 1;
            this.boxCliente.Text = "Clientes";
            // 
            // boxTurno
            // 
            this.boxTurno.AutoSize = true;
            this.boxTurno.Location = new System.Drawing.Point(16, 123);
            this.boxTurno.Name = "boxTurno";
            this.boxTurno.Size = new System.Drawing.Size(69, 21);
            this.boxTurno.TabIndex = 2;
            this.boxTurno.Text = "Turno";
            // 
            // boxFuncionario
            // 
            this.boxFuncionario.AutoSize = true;
            this.boxFuncionario.Location = new System.Drawing.Point(16, 146);
            this.boxFuncionario.Name = "boxFuncionario";
            this.boxFuncionario.Size = new System.Drawing.Size(107, 21);
            this.boxFuncionario.TabIndex = 3;
            this.boxFuncionario.Text = "Funcionário";
            // 
            // boxOperador
            // 
            this.boxOperador.AutoSize = true;
            this.boxOperador.Location = new System.Drawing.Point(216, 170);
            this.boxOperador.Name = "boxOperador";
            this.boxOperador.Size = new System.Drawing.Size(93, 21);
            this.boxOperador.TabIndex = 4;
            this.boxOperador.Text = "Operador";
            // 
            // boxContador
            // 
            this.boxContador.AutoSize = true;
            this.boxContador.Location = new System.Drawing.Point(216, 146);
            this.boxContador.Name = "boxContador";
            this.boxContador.Size = new System.Drawing.Size(93, 21);
            this.boxContador.TabIndex = 5;
            this.boxContador.Text = "Contador";
            // 
            // boxEmpresa
            // 
            this.boxEmpresa.AutoSize = true;
            this.boxEmpresa.Location = new System.Drawing.Point(216, 100);
            this.boxEmpresa.Name = "boxEmpresa";
            this.boxEmpresa.Size = new System.Drawing.Size(87, 21);
            this.boxEmpresa.TabIndex = 6;
            this.boxEmpresa.Text = "Empresa";
            // 
            // boxImpressora
            // 
            this.boxImpressora.AutoSize = true;
            this.boxImpressora.Location = new System.Drawing.Point(216, 123);
            this.boxImpressora.Name = "boxImpressora";
            this.boxImpressora.Size = new System.Drawing.Size(107, 21);
            this.boxImpressora.TabIndex = 7;
            this.boxImpressora.Text = "Impressora";
            // 
            // RadioMarcarTodos
            // 
            this.RadioMarcarTodos.Controls.Add(this.cbMarcarTodos);
            this.RadioMarcarTodos.Controls.Add(this.cbDesmarcarTodos);
            this.RadioMarcarTodos.Location = new System.Drawing.Point(15, 14);
            this.RadioMarcarTodos.Name = "RadioMarcarTodos";
            this.RadioMarcarTodos.Size = new System.Drawing.Size(381, 47);
            this.RadioMarcarTodos.TabIndex = 8;
            this.RadioMarcarTodos.TabStop = false;
            this.RadioMarcarTodos.Text = "Opções de Marcação:";
            // 
            // cbMarcarTodos
            // 
            this.cbMarcarTodos.AutoSize = true;
            this.cbMarcarTodos.Location = new System.Drawing.Point(12, 18);
            this.cbMarcarTodos.Name = "cbMarcarTodos";
            this.cbMarcarTodos.Size = new System.Drawing.Size(116, 21);
            this.cbMarcarTodos.TabIndex = 0;
            this.cbMarcarTodos.Text = "MarcarTodos";
            this.cbMarcarTodos.Click += new System.EventHandler(this.cbMarcarTodos_Click);
            // 
            // cbDesmarcarTodos
            // 
            this.cbDesmarcarTodos.AutoSize = true;
            this.cbDesmarcarTodos.Location = new System.Drawing.Point(201, 17);
            this.cbDesmarcarTodos.Name = "cbDesmarcarTodos";
            this.cbDesmarcarTodos.Size = new System.Drawing.Size(142, 21);
            this.cbDesmarcarTodos.TabIndex = 1;
            this.cbDesmarcarTodos.Text = "DesmarcarTodos";
            this.cbDesmarcarTodos.Click += new System.EventHandler(this.cbDesmarcarTodos_Click);
            // 
            // boxTipoPagamento
            // 
            this.boxTipoPagamento.AutoSize = true;
            this.boxTipoPagamento.Location = new System.Drawing.Point(16, 170);
            this.boxTipoPagamento.Name = "boxTipoPagamento";
            this.boxTipoPagamento.Size = new System.Drawing.Size(178, 21);
            this.boxTipoPagamento.TabIndex = 9;
            this.boxTipoPagamento.Text = "Tipos Pagamento ECF";
            // 
            // boxTerminalCaixa
            // 
            this.boxTerminalCaixa.AutoSize = true;
            this.boxTerminalCaixa.Location = new System.Drawing.Point(216, 194);
            this.boxTerminalCaixa.Name = "boxTerminalCaixa";
            this.boxTerminalCaixa.Size = new System.Drawing.Size(155, 21);
            this.boxTerminalCaixa.TabIndex = 10;
            this.boxTerminalCaixa.Text = "Terminais de Caixa";
            // 
            // boxAliquotas
            // 
            this.boxAliquotas.AutoSize = true;
            this.boxAliquotas.Location = new System.Drawing.Point(16, 194);
            this.boxAliquotas.Name = "boxAliquotas";
            this.boxAliquotas.Size = new System.Drawing.Size(144, 21);
            this.boxAliquotas.TabIndex = 11;
            this.boxAliquotas.Text = "Alíquotas do ECF";
            // 
            // boxProdutoSelecionado
            // 
            this.boxProdutoSelecionado.AutoSize = true;
            this.boxProdutoSelecionado.Location = new System.Drawing.Point(216, 77);
            this.boxProdutoSelecionado.Name = "boxProdutoSelecionado";
            this.boxProdutoSelecionado.Size = new System.Drawing.Size(184, 21);
            this.boxProdutoSelecionado.TabIndex = 12;
            this.boxProdutoSelecionado.Text = "Produtos Selecionados";
            this.boxProdutoSelecionado.Click += new System.EventHandler(this.boxProdutoSelecionado_Click);
            // 
            // botaoConfirma
            // 
            this.botaoConfirma.Font = new System.Drawing.Font("Tahoma", 8F);
            this.botaoConfirma.ForeColor = System.Drawing.Color.Black;
            this.botaoConfirma.Image = global::Balcao.Properties.Resources.confirmar16;
            this.botaoConfirma.Location = new System.Drawing.Point(167, 300);
            this.botaoConfirma.Name = "botaoConfirma";
            this.botaoConfirma.Size = new System.Drawing.Size(120, 25);
            this.botaoConfirma.TabIndex = 5;
            this.botaoConfirma.Text = "&Confirma (F12)";
            this.botaoConfirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoConfirma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoConfirma.Click += new System.EventHandler(this.botaoConfirma_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botaoCancela.Font = new System.Drawing.Font("Tahoma", 8F);
            this.botaoCancela.ForeColor = System.Drawing.Color.Black;
            this.botaoCancela.Image = global::Balcao.Properties.Resources.cancelar16;
            this.botaoCancela.Location = new System.Drawing.Point(299, 300);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(120, 25);
            this.botaoCancela.TabIndex = 6;
            this.botaoCancela.Text = "Ca&ncela (ESC)";
            this.botaoCancela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoCancela.Click += new System.EventHandler(this.botaoCancela_Click);
            // 
            // FPDVCarga
            // 
            this.ClientSize = new System.Drawing.Size(430, 334);
            this.Controls.Add(this.botaoConfirma);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.PanelFiltroRapido);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(268, 465);
            this.Name = "FPDVCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exporta dados para os caixas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPDVCarga_KeyDown);
            this.PanelFiltroRapido.ResumeLayout(false);
            this.PanelFiltroRapido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.RadioMarcarTodos.ResumeLayout(false);
            this.RadioMarcarTodos.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private System.Windows.Forms.Button botaoConfirma;
        private System.Windows.Forms.Button botaoCancela;

	}
}
