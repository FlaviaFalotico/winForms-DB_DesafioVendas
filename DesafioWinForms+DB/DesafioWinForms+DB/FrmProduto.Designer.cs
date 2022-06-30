namespace DesafioWinForms_DB
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.btFechar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.labelCodProd = new System.Windows.Forms.Label();
            this.tbDescricaoProd = new System.Windows.Forms.TextBox();
            this.lblCadProduto = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.tbCodigoProd = new System.Windows.Forms.TextBox();
            this.tbEstoqueProd = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblCategoriaProd = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbCategoriaProd = new System.Windows.Forms.TextBox();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblListaProdutos = new System.Windows.Forms.Label();
            this.desafioVenda_dbDataSet1 = new DesafioWinForms_DB.DesafioVenda_dbDataSet1();
            this.produtoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new DesafioWinForms_DB.DesafioVenda_dbDataSet1TableAdapters.ProdutoTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafioVenda_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btFechar.Location = new System.Drawing.Point(967, 702);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(119, 39);
            this.btFechar.TabIndex = 26;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLimpar.Location = new System.Drawing.Point(241, 635);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(134, 39);
            this.btLimpar.TabIndex = 25;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btCadastrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCadastrar.Location = new System.Drawing.Point(50, 635);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(134, 39);
            this.btCadastrar.TabIndex = 24;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblPreco.Location = new System.Drawing.Point(47, 463);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(69, 25);
            this.lblPreco.TabIndex = 22;
            this.lblPreco.Text = "Preço:";
            // 
            // labelCodProd
            // 
            this.labelCodProd.AutoSize = true;
            this.labelCodProd.BackColor = System.Drawing.Color.Transparent;
            this.labelCodProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodProd.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelCodProd.Location = new System.Drawing.Point(45, 386);
            this.labelCodProd.Name = "labelCodProd";
            this.labelCodProd.Size = new System.Drawing.Size(81, 25);
            this.labelCodProd.TabIndex = 18;
            this.labelCodProd.Text = "Código:";
            // 
            // tbDescricaoProd
            // 
            this.tbDescricaoProd.BackColor = System.Drawing.Color.White;
            this.tbDescricaoProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescricaoProd.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbDescricaoProd.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.tbDescricaoProd.Location = new System.Drawing.Point(50, 248);
            this.tbDescricaoProd.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescricaoProd.Multiline = true;
            this.tbDescricaoProd.Name = "tbDescricaoProd";
            this.tbDescricaoProd.Size = new System.Drawing.Size(325, 30);
            this.tbDescricaoProd.TabIndex = 17;
            this.tbDescricaoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCadProduto
            // 
            this.lblCadProduto.AutoSize = true;
            this.lblCadProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProduto.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCadProduto.Location = new System.Drawing.Point(51, 58);
            this.lblCadProduto.Name = "lblCadProduto";
            this.lblCadProduto.Size = new System.Drawing.Size(598, 69);
            this.lblCadProduto.TabIndex = 16;
            this.lblCadProduto.Text = "Cadastro de Produto";
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeparador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeparador.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblSeparador.Location = new System.Drawing.Point(50, 169);
            this.lblSeparador.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(904, 10);
            this.lblSeparador.TabIndex = 15;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblNomeProduto.Location = new System.Drawing.Point(45, 221);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(105, 25);
            this.lblNomeProduto.TabIndex = 14;
            this.lblNomeProduto.Text = "Descrição:";
            // 
            // tbCodigoProd
            // 
            this.tbCodigoProd.BackColor = System.Drawing.Color.White;
            this.tbCodigoProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigoProd.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbCodigoProd.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.tbCodigoProd.Location = new System.Drawing.Point(50, 413);
            this.tbCodigoProd.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoProd.Multiline = true;
            this.tbCodigoProd.Name = "tbCodigoProd";
            this.tbCodigoProd.Size = new System.Drawing.Size(325, 30);
            this.tbCodigoProd.TabIndex = 27;
            this.tbCodigoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEstoqueProd
            // 
            this.tbEstoqueProd.BackColor = System.Drawing.Color.White;
            this.tbEstoqueProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstoqueProd.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbEstoqueProd.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.tbEstoqueProd.Location = new System.Drawing.Point(50, 573);
            this.tbEstoqueProd.Margin = new System.Windows.Forms.Padding(2);
            this.tbEstoqueProd.Multiline = true;
            this.tbEstoqueProd.Name = "tbEstoqueProd";
            this.tbEstoqueProd.Size = new System.Drawing.Size(325, 30);
            this.tbEstoqueProd.TabIndex = 29;
            this.tbEstoqueProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblEstoque.Location = new System.Drawing.Point(47, 546);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(90, 25);
            this.lblEstoque.TabIndex = 28;
            this.lblEstoque.Text = "Estoque:";
            // 
            // lblCategoriaProd
            // 
            this.lblCategoriaProd.AutoSize = true;
            this.lblCategoriaProd.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoriaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProd.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCategoriaProd.Location = new System.Drawing.Point(47, 304);
            this.lblCategoriaProd.Name = "lblCategoriaProd";
            this.lblCategoriaProd.Size = new System.Drawing.Size(103, 25);
            this.lblCategoriaProd.TabIndex = 31;
            this.lblCategoriaProd.Text = "Categoria:";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AutoGenerateColumns = false;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvProduto.DataSource = this.produtoBindingSource2;
            this.dgvProduto.GridColor = System.Drawing.Color.White;
            this.dgvProduto.Location = new System.Drawing.Point(412, 248);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.RowTemplate.Height = 24;
            this.dgvProduto.Size = new System.Drawing.Size(674, 426);
            this.dgvProduto.TabIndex = 32;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            // 
            // tbCategoriaProd
            // 
            this.tbCategoriaProd.BackColor = System.Drawing.Color.White;
            this.tbCategoriaProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCategoriaProd.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbCategoriaProd.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.tbCategoriaProd.Location = new System.Drawing.Point(50, 331);
            this.tbCategoriaProd.Margin = new System.Windows.Forms.Padding(2);
            this.tbCategoriaProd.Multiline = true;
            this.tbCategoriaProd.Name = "tbCategoriaProd";
            this.tbCategoriaProd.Size = new System.Drawing.Size(325, 30);
            this.tbCategoriaProd.TabIndex = 33;
            this.tbCategoriaProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbPreco
            // 
            this.mtbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbPreco.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.mtbPreco.Location = new System.Drawing.Point(50, 491);
            this.mtbPreco.Mask = "$ 0000,00";
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(192, 30);
            this.mtbPreco.TabIndex = 34;
            this.mtbPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbPreco.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            // 
            // lblListaProdutos
            // 
            this.lblListaProdutos.AutoSize = true;
            this.lblListaProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblListaProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProdutos.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblListaProdutos.Location = new System.Drawing.Point(407, 220);
            this.lblListaProdutos.Name = "lblListaProdutos";
            this.lblListaProdutos.Size = new System.Drawing.Size(286, 25);
            this.lblListaProdutos.TabIndex = 35;
            this.lblListaProdutos.Text = "Lista de Produtos Cadastrados:";
            // 
            // desafioVenda_dbDataSet1
            // 
            this.desafioVenda_dbDataSet1.DataSetName = "DesafioVenda_dbDataSet1";
            this.desafioVenda_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource2
            // 
            this.produtoBindingSource2.DataMember = "Produto";
            this.produtoBindingSource2.DataSource = this.desafioVenda_dbDataSet1;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProduto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "categoria";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codEAN";
            this.dataGridViewTextBoxColumn4.HeaderText = "codEAN";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "preco";
            this.dataGridViewTextBoxColumn5.HeaderText = "preco";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "estoque";
            this.dataGridViewTextBoxColumn6.HeaderText = "estoque";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 773);
            this.Controls.Add(this.lblListaProdutos);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.tbCategoriaProd);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.lblCategoriaProd);
            this.Controls.Add(this.tbEstoqueProd);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.tbCodigoProd);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.labelCodProd);
            this.Controls.Add(this.tbDescricaoProd);
            this.Controls.Add(this.lblCadProduto);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.lblNomeProduto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProduto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafioVenda_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label labelCodProd;
        private System.Windows.Forms.TextBox tbDescricaoProd;
        private System.Windows.Forms.Label lblCadProduto;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox tbCodigoProd;
        private System.Windows.Forms.TextBox tbEstoqueProd;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblCategoriaProd;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox tbCategoriaProd;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.Label lblListaProdutos;
        private DesafioVenda_dbDataSet1 desafioVenda_dbDataSet1;
        private System.Windows.Forms.BindingSource produtoBindingSource2;
        private DesafioVenda_dbDataSet1TableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}