namespace Balcao.View
{
    partial class FPreVenda
    {
		private System.Windows.Forms.PictureBox Image1;
		private System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox editCodigo;
		private System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.GroupBox GroupBox6;
        private System.Windows.Forms.GroupBox GroupBox5;
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.EditCodigoProduto = new System.Windows.Forms.TextBox();
            this.editTotalItem = new System.Windows.Forms.TextBox();
            this.editUnitario = new System.Windows.Forms.TextBox();
            this.editQuantidade = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.editCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.EditNome = new System.Windows.Forms.TextBox();
            this.editCodigoCliente = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.GridItens = new System.Windows.Forms.DataGridView();
            this.GridPrincipal_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_VALOR_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelBotoes = new System.Windows.Forms.FlowLayoutPanel();
            this.botaoProduto = new System.Windows.Forms.Button();
            this.botaoCliente = new System.Windows.Forms.Button();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.botaoDesconto = new System.Windows.Forms.Button();
            this.botaoGravar = new System.Windows.Forms.Button();
            this.botaoESC = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDescricaoProduto = new System.Windows.Forms.Label();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).BeginInit();
            this.GroupBox5.SuspendLayout();
            this.PanelBotoes.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.EditCodigoProduto);
            this.GroupBox1.Controls.Add(this.editTotalItem);
            this.GroupBox1.Controls.Add(this.editUnitario);
            this.GroupBox1.Controls.Add(this.editQuantidade);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(59, 159);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(551, 68);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Digite os Produtos:";
            // 
            // EditCodigoProduto
            // 
            this.EditCodigoProduto.BackColor = System.Drawing.Color.White;
            this.EditCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EditCodigoProduto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCodigoProduto.ForeColor = System.Drawing.Color.Black;
            this.EditCodigoProduto.Location = new System.Drawing.Point(13, 35);
            this.EditCodigoProduto.Name = "EditCodigoProduto";
            this.EditCodigoProduto.Size = new System.Drawing.Size(170, 23);
            this.EditCodigoProduto.TabIndex = 11;
            this.EditCodigoProduto.Leave += new System.EventHandler(this.EditCodigoProduto_Leave);
            // 
            // editTotalItem
            // 
            this.editTotalItem.BackColor = System.Drawing.Color.White;
            this.editTotalItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.editTotalItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTotalItem.ForeColor = System.Drawing.Color.Black;
            this.editTotalItem.Location = new System.Drawing.Point(427, 35);
            this.editTotalItem.Name = "editTotalItem";
            this.editTotalItem.ReadOnly = true;
            this.editTotalItem.Size = new System.Drawing.Size(118, 23);
            this.editTotalItem.TabIndex = 6;
            this.editTotalItem.Text = "0,00";
            this.editTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // editUnitario
            // 
            this.editUnitario.BackColor = System.Drawing.Color.White;
            this.editUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.editUnitario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUnitario.ForeColor = System.Drawing.Color.Black;
            this.editUnitario.Location = new System.Drawing.Point(308, 35);
            this.editUnitario.Name = "editUnitario";
            this.editUnitario.ReadOnly = true;
            this.editUnitario.Size = new System.Drawing.Size(108, 23);
            this.editUnitario.TabIndex = 5;
            this.editUnitario.Text = "0,00";
            this.editUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // editQuantidade
            // 
            this.editQuantidade.BackColor = System.Drawing.Color.White;
            this.editQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.editQuantidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuantidade.ForeColor = System.Drawing.Color.Black;
            this.editQuantidade.Location = new System.Drawing.Point(189, 35);
            this.editQuantidade.Name = "editQuantidade";
            this.editQuantidade.Size = new System.Drawing.Size(108, 23);
            this.editQuantidade.TabIndex = 4;
            this.editQuantidade.Text = "1,000";
            this.editQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(10, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(132, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Código do Produto:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(187, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Quantidade:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(305, 16);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 16);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Valor Unitário:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(423, 16);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(83, 16);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Valor Total:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.editCpfCnpj);
            this.GroupBox2.Controls.Add(this.label17);
            this.GroupBox2.Controls.Add(this.label16);
            this.GroupBox2.Controls.Add(this.EditNome);
            this.GroupBox2.Controls.Add(this.editCodigoCliente);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.GroupBox2.Location = new System.Drawing.Point(59, 8);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(725, 81);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Dados do Cliente";
            // 
            // editCpfCnpj
            // 
            this.editCpfCnpj.Location = new System.Drawing.Point(509, 45);
            this.editCpfCnpj.Name = "editCpfCnpj";
            this.editCpfCnpj.Size = new System.Drawing.Size(204, 22);
            this.editCpfCnpj.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(510, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "CPF/CNPJ:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(130, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 16);
            this.label16.TabIndex = 11;
            this.label16.Text = "Nome Destinatário:";
            // 
            // EditNome
            // 
            this.EditNome.BackColor = System.Drawing.Color.White;
            this.EditNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EditNome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditNome.ForeColor = System.Drawing.Color.Black;
            this.EditNome.Location = new System.Drawing.Point(129, 44);
            this.EditNome.Name = "EditNome";
            this.EditNome.Size = new System.Drawing.Size(359, 23);
            this.EditNome.TabIndex = 10;
            // 
            // editCodigoCliente
            // 
            this.editCodigoCliente.BackColor = System.Drawing.Color.White;
            this.editCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.editCodigoCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCodigoCliente.ForeColor = System.Drawing.Color.Black;
            this.editCodigoCliente.Location = new System.Drawing.Point(14, 44);
            this.editCodigoCliente.Name = "editCodigoCliente";
            this.editCodigoCliente.Size = new System.Drawing.Size(101, 23);
            this.editCodigoCliente.TabIndex = 9;
            this.editCodigoCliente.Text = "0";
            this.editCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(11, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(104, 16);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Có&digo Cliente:";
            // 
            // GroupBox6
            // 
            this.GroupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox6.Controls.Add(this.GridItens);
            this.GroupBox6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.GroupBox6.ForeColor = System.Drawing.Color.Black;
            this.GroupBox6.Location = new System.Drawing.Point(58, 233);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(725, 208);
            this.GroupBox6.TabIndex = 3;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Produtos Lançados:";
            // 
            // GridItens
            // 
            this.GridItens.AllowUserToAddRows = false;
            this.GridItens.AllowUserToDeleteRows = false;
            this.GridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridPrincipal_ID,
            this.GridPrincipal_NOME,
            this.GridPrincipal_UNIDADE,
            this.Quantidade,
            this.GridPrincipal_VALOR_VENDA,
            this.ValorTotal});
            this.GridItens.Font = new System.Drawing.Font("Tahoma", 8F);
            this.GridItens.Location = new System.Drawing.Point(8, 18);
            this.GridItens.MultiSelect = false;
            this.GridItens.Name = "GridItens";
            this.GridItens.ReadOnly = true;
            this.GridItens.Size = new System.Drawing.Size(711, 184);
            this.GridItens.TabIndex = 104;
            this.GridItens.Text = "Select columns";
            // 
            // GridPrincipal_ID
            // 
            this.GridPrincipal_ID.DataPropertyName = "IdProduto";
            this.GridPrincipal_ID.HeaderText = "Código";
            this.GridPrincipal_ID.Name = "GridPrincipal_ID";
            this.GridPrincipal_ID.ReadOnly = true;
            // 
            // GridPrincipal_NOME
            // 
            this.GridPrincipal_NOME.DataPropertyName = "NomeProduto";
            this.GridPrincipal_NOME.HeaderText = "Nome";
            this.GridPrincipal_NOME.Name = "GridPrincipal_NOME";
            this.GridPrincipal_NOME.ReadOnly = true;
            this.GridPrincipal_NOME.Width = 405;
            // 
            // GridPrincipal_UNIDADE
            // 
            this.GridPrincipal_UNIDADE.DataPropertyName = "UnidadeProduto";
            this.GridPrincipal_UNIDADE.HeaderText = "Unidade";
            this.GridPrincipal_UNIDADE.Name = "GridPrincipal_UNIDADE";
            this.GridPrincipal_UNIDADE.ReadOnly = true;
            this.GridPrincipal_UNIDADE.Width = 57;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // GridPrincipal_VALOR_VENDA
            // 
            this.GridPrincipal_VALOR_VENDA.DataPropertyName = "ValorUnitario";
            this.GridPrincipal_VALOR_VENDA.HeaderText = "Valor Unitário";
            this.GridPrincipal_VALOR_VENDA.Name = "GridPrincipal_VALOR_VENDA";
            this.GridPrincipal_VALOR_VENDA.ReadOnly = true;
            this.GridPrincipal_VALOR_VENDA.Width = 148;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox5.Controls.Add(this.labelTotal);
            this.GroupBox5.Controls.Add(this.label14);
            this.GroupBox5.Controls.Add(this.labelSubtotal);
            this.GroupBox5.Controls.Add(this.label8);
            this.GroupBox5.Controls.Add(this.label7);
            this.GroupBox5.Controls.Add(this.label6);
            this.GroupBox5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.GroupBox5.ForeColor = System.Drawing.Color.Black;
            this.GroupBox5.Location = new System.Drawing.Point(616, 98);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(168, 128);
            this.GroupBox5.TabIndex = 5;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Resumo da Operação:";
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Blue;
            this.labelTotal.Location = new System.Drawing.Point(86, 100);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(75, 16);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "0,00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(86, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "0,00";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.ForeColor = System.Drawing.Color.Blue;
            this.labelSubtotal.Location = new System.Drawing.Point(86, 31);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(75, 16);
            this.labelSubtotal.TabIndex = 7;
            this.labelSubtotal.Text = "0,00";
            this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Desconto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sub-Total:";
            // 
            // PanelBotoes
            // 
            this.PanelBotoes.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotoes.Controls.Add(this.botaoProduto);
            this.PanelBotoes.Controls.Add(this.botaoCliente);
            this.PanelBotoes.Controls.Add(this.botaoCancela);
            this.PanelBotoes.Controls.Add(this.botaoDesconto);
            this.PanelBotoes.Controls.Add(this.botaoGravar);
            this.PanelBotoes.Controls.Add(this.botaoESC);
            this.PanelBotoes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelBotoes.Location = new System.Drawing.Point(59, 447);
            this.PanelBotoes.Name = "PanelBotoes";
            this.PanelBotoes.Size = new System.Drawing.Size(724, 28);
            this.PanelBotoes.TabIndex = 49;
            // 
            // botaoProduto
            // 
            this.botaoProduto.BackColor = System.Drawing.Color.Transparent;
            this.botaoProduto.FlatAppearance.BorderSize = 0;
            this.botaoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoProduto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoProduto.ForeColor = System.Drawing.Color.Black;
            this.botaoProduto.Image = global::Balcao.Properties.Resources._21botaoPesquisa;
            this.botaoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoProduto.Location = new System.Drawing.Point(1, 1);
            this.botaoProduto.Margin = new System.Windows.Forms.Padding(1);
            this.botaoProduto.Name = "botaoProduto";
            this.botaoProduto.Size = new System.Drawing.Size(110, 26);
            this.botaoProduto.TabIndex = 0;
            this.botaoProduto.TabStop = false;
            this.botaoProduto.Text = "F1 - Produto";
            this.botaoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoProduto.UseVisualStyleBackColor = false;
            this.botaoProduto.Click += new System.EventHandler(this.botaoProduto_Click);
            // 
            // botaoCliente
            // 
            this.botaoCliente.BackColor = System.Drawing.Color.Transparent;
            this.botaoCliente.FlatAppearance.BorderSize = 0;
            this.botaoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCliente.ForeColor = System.Drawing.Color.Black;
            this.botaoCliente.Image = global::Balcao.Properties.Resources._21botaoCliente;
            this.botaoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCliente.Location = new System.Drawing.Point(113, 1);
            this.botaoCliente.Margin = new System.Windows.Forms.Padding(1);
            this.botaoCliente.Name = "botaoCliente";
            this.botaoCliente.Size = new System.Drawing.Size(110, 26);
            this.botaoCliente.TabIndex = 0;
            this.botaoCliente.TabStop = false;
            this.botaoCliente.Text = "F6 - Cliente";
            this.botaoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoCliente.UseVisualStyleBackColor = false;
            this.botaoCliente.Click += new System.EventHandler(this.botaoCliente_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.BackColor = System.Drawing.Color.Transparent;
            this.botaoCancela.FlatAppearance.BorderSize = 0;
            this.botaoCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancela.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCancela.ForeColor = System.Drawing.Color.Black;
            this.botaoCancela.Image = global::Balcao.Properties.Resources._21botaoCancelaCupom;
            this.botaoCancela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancela.Location = new System.Drawing.Point(225, 1);
            this.botaoCancela.Margin = new System.Windows.Forms.Padding(1);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(150, 26);
            this.botaoCancela.TabIndex = 17;
            this.botaoCancela.TabStop = false;
            this.botaoCancela.Text = "F8 - Cancela Item";
            this.botaoCancela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoCancela.UseVisualStyleBackColor = false;
            this.botaoCancela.Click += new System.EventHandler(this.botaoCancela_Click);
            // 
            // botaoDesconto
            // 
            this.botaoDesconto.BackColor = System.Drawing.Color.Transparent;
            this.botaoDesconto.FlatAppearance.BorderSize = 0;
            this.botaoDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDesconto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDesconto.ForeColor = System.Drawing.Color.Black;
            this.botaoDesconto.Image = global::Balcao.Properties.Resources._21botaoDesconto;
            this.botaoDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoDesconto.Location = new System.Drawing.Point(377, 1);
            this.botaoDesconto.Margin = new System.Windows.Forms.Padding(1);
            this.botaoDesconto.Name = "botaoDesconto";
            this.botaoDesconto.Size = new System.Drawing.Size(130, 26);
            this.botaoDesconto.TabIndex = 20;
            this.botaoDesconto.TabStop = false;
            this.botaoDesconto.Text = "F10 - Desconto";
            this.botaoDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoDesconto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoDesconto.UseVisualStyleBackColor = false;
            this.botaoDesconto.Click += new System.EventHandler(this.botaoDesconto_Click);
            // 
            // botaoGravar
            // 
            this.botaoGravar.BackColor = System.Drawing.Color.Transparent;
            this.botaoGravar.FlatAppearance.BorderSize = 0;
            this.botaoGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoGravar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoGravar.ForeColor = System.Drawing.Color.Black;
            this.botaoGravar.Image = global::Balcao.Properties.Resources._21botaoMenuFiscal;
            this.botaoGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoGravar.Location = new System.Drawing.Point(509, 1);
            this.botaoGravar.Margin = new System.Windows.Forms.Padding(1);
            this.botaoGravar.Name = "botaoGravar";
            this.botaoGravar.Size = new System.Drawing.Size(110, 26);
            this.botaoGravar.TabIndex = 15;
            this.botaoGravar.TabStop = false;
            this.botaoGravar.Text = "F12 - Gravar";
            this.botaoGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoGravar.UseVisualStyleBackColor = false;
            this.botaoGravar.Click += new System.EventHandler(this.botaoGravar_Click);
            // 
            // botaoESC
            // 
            this.botaoESC.BackColor = System.Drawing.Color.Transparent;
            this.botaoESC.FlatAppearance.BorderSize = 0;
            this.botaoESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoESC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoESC.ForeColor = System.Drawing.Color.Black;
            this.botaoESC.Image = global::Balcao.Properties.Resources._21botaoSair;
            this.botaoESC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoESC.Location = new System.Drawing.Point(621, 1);
            this.botaoESC.Margin = new System.Windows.Forms.Padding(1);
            this.botaoESC.Name = "botaoESC";
            this.botaoESC.Size = new System.Drawing.Size(100, 26);
            this.botaoESC.TabIndex = 21;
            this.botaoESC.TabStop = false;
            this.botaoESC.Text = "ESC - Sair";
            this.botaoESC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoESC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoESC.UseVisualStyleBackColor = false;
            this.botaoESC.Click += new System.EventHandler(this.botaoESC_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox3.BackColor = System.Drawing.Color.White;
            this.GroupBox3.Controls.Add(this.labelDescricaoProduto);
            this.GroupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.GroupBox3.Location = new System.Drawing.Point(59, 100);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(551, 57);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            // 
            // labelDescricaoProduto
            // 
            this.labelDescricaoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescricaoProduto.BackColor = System.Drawing.Color.Teal;
            this.labelDescricaoProduto.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.labelDescricaoProduto.ForeColor = System.Drawing.Color.Black;
            this.labelDescricaoProduto.Location = new System.Drawing.Point(4, 5);
            this.labelDescricaoProduto.Name = "labelDescricaoProduto";
            this.labelDescricaoProduto.Size = new System.Drawing.Size(543, 47);
            this.labelDescricaoProduto.TabIndex = 0;
            this.labelDescricaoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Image1
            // 
            this.Image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Image1.Image = global::Balcao.Properties.Resources.telaDocumento07;
            this.Image1.Location = new System.Drawing.Point(4, 12);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(51, 56);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Image1.TabIndex = 0;
            this.Image1.TabStop = false;
            // 
            // FPreVenda
            // 
            this.ClientSize = new System.Drawing.Size(791, 484);
            this.Controls.Add(this.PanelBotoes);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(140, 471);
            this.Name = "FPreVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emissão de Pré-Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPreVenda_KeyDown);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).EndInit();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.PanelBotoes.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private System.Windows.Forms.Button botaoESC;
        private System.Windows.Forms.Button botaoGravar;
        private System.Windows.Forms.Button botaoDesconto;
        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.Button botaoCliente;
        private System.Windows.Forms.Button botaoProduto;
        private System.Windows.Forms.FlowLayoutPanel PanelBotoes;
        private System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label labelDescricaoProduto;
        private System.Windows.Forms.DataGridView GridItens;
        internal System.Windows.Forms.Label labelTotal;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label labelSubtotal;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox editQuantidade;
        internal System.Windows.Forms.TextBox editUnitario;
        internal System.Windows.Forms.TextBox editTotalItem;
        internal System.Windows.Forms.TextBox editCodigoCliente;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox EditNome;
        private System.Windows.Forms.MaskedTextBox editCpfCnpj;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox EditCodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_VALOR_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;


    }
}
