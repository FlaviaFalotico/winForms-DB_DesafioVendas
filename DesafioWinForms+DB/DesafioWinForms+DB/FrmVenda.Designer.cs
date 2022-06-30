namespace DesafioWinForms_DB
{
    partial class FrmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.tbCodigoEAN = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.labelCodProd = new System.Windows.Forms.Label();
            this.lblCadVenda = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblListaVenda = new System.Windows.Forms.Label();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.lblItensVendidos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteidClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desafioVenda_dbDataSet1 = new DesafioWinForms_DB.DesafioVenda_dbDataSet1();
            this.vendasTableAdapter = new DesafioWinForms_DB.DesafioVenda_dbDataSet1TableAdapters.VendasTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idItemVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendasidVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoidProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemVendaTableAdapter = new DesafioWinForms_DB.DesafioVenda_dbDataSet1TableAdapters.ItemVendaTableAdapter();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.btBuscarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafioVenda_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.BackColor = System.Drawing.Color.White;
            this.tbQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantidade.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbQuantidade.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.tbQuantidade.Location = new System.Drawing.Point(51, 516);
            this.tbQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.tbQuantidade.Multiline = true;
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(329, 30);
            this.tbQuantidade.TabIndex = 42;
            this.tbQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblQuantidade.Location = new System.Drawing.Point(47, 489);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(120, 25);
            this.lblQuantidade.TabIndex = 41;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // tbCodigoEAN
            // 
            this.tbCodigoEAN.BackColor = System.Drawing.Color.White;
            this.tbCodigoEAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigoEAN.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbCodigoEAN.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.tbCodigoEAN.Location = new System.Drawing.Point(52, 430);
            this.tbCodigoEAN.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoEAN.Multiline = true;
            this.tbCodigoEAN.Name = "tbCodigoEAN";
            this.tbCodigoEAN.Size = new System.Drawing.Size(329, 30);
            this.tbCodigoEAN.TabIndex = 40;
            this.tbCodigoEAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btFechar.Location = new System.Drawing.Point(973, 706);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(119, 39);
            this.btFechar.TabIndex = 39;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLimpar.Location = new System.Drawing.Point(60, 649);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(134, 39);
            this.btLimpar.TabIndex = 38;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // labelCodProd
            // 
            this.labelCodProd.AutoSize = true;
            this.labelCodProd.BackColor = System.Drawing.Color.Transparent;
            this.labelCodProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodProd.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelCodProd.Location = new System.Drawing.Point(47, 403);
            this.labelCodProd.Name = "labelCodProd";
            this.labelCodProd.Size = new System.Drawing.Size(181, 25);
            this.labelCodProd.TabIndex = 34;
            this.labelCodProd.Text = "Código do Produto:";
            // 
            // lblCadVenda
            // 
            this.lblCadVenda.AutoSize = true;
            this.lblCadVenda.BackColor = System.Drawing.Color.Transparent;
            this.lblCadVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadVenda.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCadVenda.Location = new System.Drawing.Point(50, 50);
            this.lblCadVenda.Name = "lblCadVenda";
            this.lblCadVenda.Size = new System.Drawing.Size(559, 69);
            this.lblCadVenda.TabIndex = 32;
            this.lblCadVenda.Text = "Cadastro de Venda";
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeparador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeparador.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblSeparador.Location = new System.Drawing.Point(51, 169);
            this.lblSeparador.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(902, 10);
            this.lblSeparador.TabIndex = 31;
            // 
            // lblListaVenda
            // 
            this.lblListaVenda.AutoSize = true;
            this.lblListaVenda.BackColor = System.Drawing.Color.Transparent;
            this.lblListaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaVenda.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblListaVenda.Location = new System.Drawing.Point(423, 202);
            this.lblListaVenda.Name = "lblListaVenda";
            this.lblListaVenda.Size = new System.Drawing.Size(260, 25);
            this.lblListaVenda.TabIndex = 44;
            this.lblListaVenda.Text = "Lista de Vendas Realizadas:";
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCliente.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCpfCliente.Location = new System.Drawing.Point(47, 249);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(151, 25);
            this.lblCpfCliente.TabIndex = 45;
            this.lblCpfCliente.Text = "CPF do Cliente:";
            // 
            // lblItensVendidos
            // 
            this.lblItensVendidos.AutoSize = true;
            this.lblItensVendidos.BackColor = System.Drawing.Color.Transparent;
            this.lblItensVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItensVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItensVendidos.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblItensVendidos.Location = new System.Drawing.Point(423, 437);
            this.lblItensVendidos.Name = "lblItensVendidos";
            this.lblItensVendidos.Size = new System.Drawing.Size(221, 25);
            this.lblItensVendidos.TabIndex = 47;
            this.lblItensVendidos.Text = "Lista de Itens Vendidos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendaDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.clienteidClienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(428, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 177);
            this.dataGridView1.TabIndex = 51;
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            this.idVendaDataGridViewTextBoxColumn.DataPropertyName = "idVenda";
            this.idVendaDataGridViewTextBoxColumn.HeaderText = "idVenda";
            this.idVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            this.idVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteidClienteDataGridViewTextBoxColumn
            // 
            this.clienteidClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente_idCliente";
            this.clienteidClienteDataGridViewTextBoxColumn.HeaderText = "Cliente_idCliente";
            this.clienteidClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteidClienteDataGridViewTextBoxColumn.Name = "clienteidClienteDataGridViewTextBoxColumn";
            this.clienteidClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this.desafioVenda_dbDataSet1;
            // 
            // desafioVenda_dbDataSet1
            // 
            this.desafioVenda_dbDataSet1.DataSetName = "DesafioVenda_dbDataSet1";
            this.desafioVenda_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemVendaDataGridViewTextBoxColumn,
            this.vendasidVendaDataGridViewTextBoxColumn,
            this.produtoidProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.itemVendaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(428, 465);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(664, 208);
            this.dataGridView2.TabIndex = 52;
            // 
            // idItemVendaDataGridViewTextBoxColumn
            // 
            this.idItemVendaDataGridViewTextBoxColumn.DataPropertyName = "idItemVenda";
            this.idItemVendaDataGridViewTextBoxColumn.HeaderText = "idItemVenda";
            this.idItemVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idItemVendaDataGridViewTextBoxColumn.Name = "idItemVendaDataGridViewTextBoxColumn";
            this.idItemVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idItemVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendasidVendaDataGridViewTextBoxColumn
            // 
            this.vendasidVendaDataGridViewTextBoxColumn.DataPropertyName = "Vendas_idVenda";
            this.vendasidVendaDataGridViewTextBoxColumn.HeaderText = "Vendas_idVenda";
            this.vendasidVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendasidVendaDataGridViewTextBoxColumn.Name = "vendasidVendaDataGridViewTextBoxColumn";
            this.vendasidVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // produtoidProdutoDataGridViewTextBoxColumn
            // 
            this.produtoidProdutoDataGridViewTextBoxColumn.DataPropertyName = "Produto_idProduto";
            this.produtoidProdutoDataGridViewTextBoxColumn.HeaderText = "Produto_idProduto";
            this.produtoidProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.produtoidProdutoDataGridViewTextBoxColumn.Name = "produtoidProdutoDataGridViewTextBoxColumn";
            this.produtoidProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalDataGridViewTextBoxColumn1
            // 
            this.valorTotalDataGridViewTextBoxColumn1.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn1.HeaderText = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.valorTotalDataGridViewTextBoxColumn1.Name = "valorTotalDataGridViewTextBoxColumn1";
            this.valorTotalDataGridViewTextBoxColumn1.Width = 125;
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataMember = "ItemVenda";
            this.itemVendaBindingSource.DataSource = this.desafioVenda_dbDataSet1;
            // 
            // itemVendaTableAdapter
            // 
            this.itemVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tbCliente
            // 
            this.tbCliente.BackColor = System.Drawing.Color.White;
            this.tbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCliente.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbCliente.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.tbCliente.Location = new System.Drawing.Point(51, 276);
            this.tbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbCliente.Multiline = true;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(330, 30);
            this.tbCliente.TabIndex = 48;
            this.tbCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btBuscarCliente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBuscarCliente.Location = new System.Drawing.Point(174, 339);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(207, 39);
            this.btBuscarCliente.TabIndex = 58;
            this.btBuscarCliente.Text = "Cadastrar Venda";
            this.btBuscarCliente.UseVisualStyleBackColor = false;
            this.btBuscarCliente.Click += new System.EventHandler(this.btBuscarCliente_Click);
            // 
            // btBuscarProduto
            // 
            this.btBuscarProduto.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btBuscarProduto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btBuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBuscarProduto.Location = new System.Drawing.Point(174, 578);
            this.btBuscarProduto.Name = "btBuscarProduto";
            this.btBuscarProduto.Size = new System.Drawing.Size(207, 39);
            this.btBuscarProduto.TabIndex = 59;
            this.btBuscarProduto.Text = "Comprar Produto";
            this.btBuscarProduto.UseVisualStyleBackColor = false;
            this.btBuscarProduto.Click += new System.EventHandler(this.btBuscarProduto_Click);
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 773);
            this.Controls.Add(this.btBuscarProduto);
            this.Controls.Add(this.btBuscarCliente);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.lblItensVendidos);
            this.Controls.Add(this.lblCpfCliente);
            this.Controls.Add(this.lblListaVenda);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.tbCodigoEAN);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.labelCodProd);
            this.Controls.Add(this.lblCadVenda);
            this.Controls.Add(this.lblSeparador);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafioVenda_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox tbCodigoEAN;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label labelCodProd;
        private System.Windows.Forms.Label lblCadVenda;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblListaVenda;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.Label lblItensVendidos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DesafioVenda_dbDataSet1 desafioVenda_dbDataSet1;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private DesafioVenda_dbDataSet1TableAdapters.VendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteidClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private DesafioVenda_dbDataSet1TableAdapters.ItemVendaTableAdapter itemVendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendasidVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoidProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Button btBuscarCliente;
        private System.Windows.Forms.Button btBuscarProduto;
    }
}