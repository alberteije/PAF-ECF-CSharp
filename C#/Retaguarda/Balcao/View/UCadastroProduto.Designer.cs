namespace Balcao.View
{
	partial class FCadastroProduto
    {
		private System.Windows.Forms.PictureBox Image1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridView GridPrincipal;
		private System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button SpeedButton1;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label2 = new System.Windows.Forms.Label();
            this.GridPrincipal = new System.Windows.Forms.DataGridView();
            this.GTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_VALOR_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_QTD_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_IPPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_IAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_ECF_ICMS_ST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_CODIGO_INTERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_ESTOQUE_MIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_ESTOQUE_MAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EditLocaliza = new System.Windows.Forms.TextBox();
            this.SpeedButton1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.botaoConfirma = new System.Windows.Forms.Button();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridPrincipal)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(68, 320);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 13);
            this.Label2.TabIndex = 1;
            // 
            // GridPrincipal
            // 
            this.GridPrincipal.AllowUserToAddRows = false;
            this.GridPrincipal.AllowUserToDeleteRows = false;
            this.GridPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GTIN,
            this.GridPrincipal_NOME,
            this.GridPrincipal_UNIDADE,
            this.GridPrincipal_VALOR_VENDA,
            this.GridPrincipal_QTD_ESTOQUE,
            this.GridPrincipal_IPPT,
            this.GridPrincipal_IAT,
            this.GridPrincipal_ECF_ICMS_ST,
            this.GridPrincipal_CODIGO_INTERNO,
            this.GridPrincipal_ESTOQUE_MIN,
            this.GridPrincipal_ESTOQUE_MAX});
            this.GridPrincipal.Font = new System.Drawing.Font("Tahoma", 8F);
            this.GridPrincipal.Location = new System.Drawing.Point(68, 133);
            this.GridPrincipal.Name = "GridPrincipal";
            this.GridPrincipal.ReadOnly = true;
            this.GridPrincipal.Size = new System.Drawing.Size(613, 215);
            this.GridPrincipal.TabIndex = 1;
            this.GridPrincipal.Text = "Select columns";
            this.GridPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridPrincipal_KeyDown);
            // 
            // GTIN
            // 
            this.GTIN.DataPropertyName = "GTIN";
            this.GTIN.HeaderText = "GTIN";
            this.GTIN.Name = "GTIN";
            this.GTIN.ReadOnly = true;
            this.GTIN.Width = 110;
            // 
            // GridPrincipal_NOME
            // 
            this.GridPrincipal_NOME.DataPropertyName = "Nome";
            this.GridPrincipal_NOME.HeaderText = "Descrição da Mercadoria ou Serviço";
            this.GridPrincipal_NOME.Name = "GridPrincipal_NOME";
            this.GridPrincipal_NOME.ReadOnly = true;
            this.GridPrincipal_NOME.Width = 300;
            // 
            // GridPrincipal_UNIDADE
            // 
            this.GridPrincipal_UNIDADE.DataPropertyName = "UnidadeProduto";
            this.GridPrincipal_UNIDADE.HeaderText = "Unidade";
            this.GridPrincipal_UNIDADE.Name = "GridPrincipal_UNIDADE";
            this.GridPrincipal_UNIDADE.ReadOnly = true;
            // 
            // GridPrincipal_VALOR_VENDA
            // 
            this.GridPrincipal_VALOR_VENDA.DataPropertyName = "ValorVenda";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GridPrincipal_VALOR_VENDA.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridPrincipal_VALOR_VENDA.HeaderText = "Valor Unitário";
            this.GridPrincipal_VALOR_VENDA.Name = "GridPrincipal_VALOR_VENDA";
            this.GridPrincipal_VALOR_VENDA.ReadOnly = true;
            // 
            // GridPrincipal_QTD_ESTOQUE
            // 
            this.GridPrincipal_QTD_ESTOQUE.DataPropertyName = "QtdeEstoque";
            this.GridPrincipal_QTD_ESTOQUE.HeaderText = "Qtde. Estoque";
            this.GridPrincipal_QTD_ESTOQUE.Name = "GridPrincipal_QTD_ESTOQUE";
            this.GridPrincipal_QTD_ESTOQUE.ReadOnly = true;
            // 
            // GridPrincipal_IPPT
            // 
            this.GridPrincipal_IPPT.DataPropertyName = "IPPT";
            this.GridPrincipal_IPPT.HeaderText = "IPPT";
            this.GridPrincipal_IPPT.Name = "GridPrincipal_IPPT";
            this.GridPrincipal_IPPT.ReadOnly = true;
            // 
            // GridPrincipal_IAT
            // 
            this.GridPrincipal_IAT.DataPropertyName = "IAT";
            this.GridPrincipal_IAT.HeaderText = "IAT";
            this.GridPrincipal_IAT.Name = "GridPrincipal_IAT";
            this.GridPrincipal_IAT.ReadOnly = true;
            // 
            // GridPrincipal_ECF_ICMS_ST
            // 
            this.GridPrincipal_ECF_ICMS_ST.DataPropertyName = "ECFICMS";
            this.GridPrincipal_ECF_ICMS_ST.HeaderText = "Situação Tributária";
            this.GridPrincipal_ECF_ICMS_ST.Name = "GridPrincipal_ECF_ICMS_ST";
            this.GridPrincipal_ECF_ICMS_ST.ReadOnly = true;
            // 
            // GridPrincipal_CODIGO_INTERNO
            // 
            this.GridPrincipal_CODIGO_INTERNO.DataPropertyName = "CodigoInterno";
            this.GridPrincipal_CODIGO_INTERNO.HeaderText = "Código Interno";
            this.GridPrincipal_CODIGO_INTERNO.Name = "GridPrincipal_CODIGO_INTERNO";
            this.GridPrincipal_CODIGO_INTERNO.ReadOnly = true;
            // 
            // GridPrincipal_ESTOQUE_MIN
            // 
            this.GridPrincipal_ESTOQUE_MIN.DataPropertyName = "EstoqueMinimo";
            this.GridPrincipal_ESTOQUE_MIN.HeaderText = "Estoque Mínimo";
            this.GridPrincipal_ESTOQUE_MIN.Name = "GridPrincipal_ESTOQUE_MIN";
            this.GridPrincipal_ESTOQUE_MIN.ReadOnly = true;
            // 
            // GridPrincipal_ESTOQUE_MAX
            // 
            this.GridPrincipal_ESTOQUE_MAX.DataPropertyName = "EstoqueMaximo";
            this.GridPrincipal_ESTOQUE_MAX.HeaderText = "Estoque Máximo";
            this.GridPrincipal_ESTOQUE_MAX.Name = "GridPrincipal_ESTOQUE_MAX";
            this.GridPrincipal_ESTOQUE_MAX.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Panel1.Controls.Add(this.EditLocaliza);
            this.Panel1.Controls.Add(this.SpeedButton1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(68, 354);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(613, 58);
            this.Panel1.TabIndex = 0;
            // 
            // EditLocaliza
            // 
            this.EditLocaliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EditLocaliza.Location = new System.Drawing.Point(10, 27);
            this.EditLocaliza.Name = "EditLocaliza";
            this.EditLocaliza.Size = new System.Drawing.Size(485, 20);
            this.EditLocaliza.TabIndex = 0;
            // 
            // SpeedButton1
            // 
            this.SpeedButton1.BackColor = System.Drawing.Color.White;
            this.SpeedButton1.Location = new System.Drawing.Point(497, 27);
            this.SpeedButton1.Name = "SpeedButton1";
            this.SpeedButton1.Size = new System.Drawing.Size(105, 21);
            this.SpeedButton1.TabIndex = 5;
            this.SpeedButton1.Text = "Localiza (F2)";
            this.SpeedButton1.UseVisualStyleBackColor = false;
            this.SpeedButton1.Click += new System.EventHandler(this.SpeedButton1_Click);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(7, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Procura por:";
            // 
            // botaoCancela
            // 
            this.botaoCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botaoCancela.Font = new System.Drawing.Font("Tahoma", 8F);
            this.botaoCancela.ForeColor = System.Drawing.Color.Black;
            this.botaoCancela.Image = global::Balcao.Properties.Resources.cancelar16;
            this.botaoCancela.Location = new System.Drawing.Point(561, 424);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(120, 25);
            this.botaoCancela.TabIndex = 4;
            this.botaoCancela.Text = "Ca&ncela (ESC)";
            this.botaoCancela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoCancela.Click += new System.EventHandler(this.botaoCancela_Click);
            // 
            // botaoConfirma
            // 
            this.botaoConfirma.Font = new System.Drawing.Font("Tahoma", 8F);
            this.botaoConfirma.ForeColor = System.Drawing.Color.Black;
            this.botaoConfirma.Image = global::Balcao.Properties.Resources.confirmar16;
            this.botaoConfirma.Location = new System.Drawing.Point(429, 424);
            this.botaoConfirma.Name = "botaoConfirma";
            this.botaoConfirma.Size = new System.Drawing.Size(120, 25);
            this.botaoConfirma.TabIndex = 3;
            this.botaoConfirma.Text = "&Confirma (F12)";
            this.botaoConfirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoConfirma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoConfirma.Click += new System.EventHandler(this.botaoConfirma_Click);
            // 
            // Image1
            // 
            this.Image1.Image = global::Balcao.Properties.Resources.telaCarrinho02;
            this.Image1.Location = new System.Drawing.Point(10, 10);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(48, 48);
            this.Image1.TabIndex = 0;
            this.Image1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(68, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Produto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "GTIN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(365, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Unidade:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(503, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Valor Unitário:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arredondamento",
            "Truncamento"});
            this.comboBox1.Location = new System.Drawing.Point(132, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "IAT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "IPPT:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Próprio",
            "Terceirizado"});
            this.comboBox2.Location = new System.Drawing.Point(259, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "NCM:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(493, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 20);
            this.textBox5.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "CST:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(386, 82);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 14;
            // 
            // FCadastroProduto
            // 
            this.ClientSize = new System.Drawing.Size(692, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoConfirma);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GridPrincipal);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(226, 359);
            this.Name = "FCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FImportaProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridPrincipal)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private System.Windows.Forms.Button botaoConfirma;
        private System.Windows.Forms.Button botaoCancela;
        public System.Windows.Forms.TextBox EditLocaliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_VALOR_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_QTD_ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_IPPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_IAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_ECF_ICMS_ST;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_CODIGO_INTERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_ESTOQUE_MIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_ESTOQUE_MAX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;

	}
}
