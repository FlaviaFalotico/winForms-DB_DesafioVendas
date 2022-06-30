namespace DesafioWinForms_DB
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEmail = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btFechar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lblPCelular = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.tbNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblCadCliente = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCadClientes = new System.Windows.Forms.Label();
            this.desafioVenda_dbDataSet1 = new DesafioWinForms_DB.DesafioVenda_dbDataSet1();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new DesafioWinForms_DB.DesafioVenda_dbDataSet1TableAdapters.ClienteTableAdapter();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new DesafioWinForms_DB.DesafioVenda_dbDataSet1TableAdapters.ProdutoTableAdapter();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafioVenda_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbCelular.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.mtbCelular.Location = new System.Drawing.Point(55, 529);
            this.mtbCelular.Mask = "(00) 0 0000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(215, 30);
            this.mtbCelular.TabIndex = 50;
            this.mtbCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbEmail.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.tbEmail.Location = new System.Drawing.Point(55, 351);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(325, 30);
            this.tbEmail.TabIndex = 49;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoGenerateColumns = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvCliente.DataSource = this.clienteBindingSource2;
            this.dgvCliente.GridColor = System.Drawing.Color.White;
            this.dgvCliente.Location = new System.Drawing.Point(417, 259);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(674, 402);
            this.dgvCliente.TabIndex = 48;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblEmail.Location = new System.Drawing.Point(52, 324);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Email:";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btFechar.Location = new System.Drawing.Point(972, 689);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(119, 39);
            this.btFechar.TabIndex = 43;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLimpar.Location = new System.Drawing.Point(246, 622);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(134, 39);
            this.btLimpar.TabIndex = 42;
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
            this.btCadastrar.Location = new System.Drawing.Point(55, 622);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(134, 39);
            this.btCadastrar.TabIndex = 41;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lblPCelular
            // 
            this.lblPCelular.AutoSize = true;
            this.lblPCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblPCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCelular.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblPCelular.Location = new System.Drawing.Point(52, 501);
            this.lblPCelular.Name = "lblPCelular";
            this.lblPCelular.Size = new System.Drawing.Size(80, 25);
            this.lblPCelular.TabIndex = 40;
            this.lblPCelular.Text = "Celular:";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.BackColor = System.Drawing.Color.Transparent;
            this.labelCpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelCpf.Location = new System.Drawing.Point(50, 412);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(58, 25);
            this.labelCpf.TabIndex = 39;
            this.labelCpf.Text = "CPF:";
            // 
            // tbNomeCompleto
            // 
            this.tbNomeCompleto.BackColor = System.Drawing.Color.White;
            this.tbNomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomeCompleto.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbNomeCompleto.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.tbNomeCompleto.Location = new System.Drawing.Point(55, 259);
            this.tbNomeCompleto.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeCompleto.Multiline = true;
            this.tbNomeCompleto.Name = "tbNomeCompleto";
            this.tbNomeCompleto.Size = new System.Drawing.Size(325, 30);
            this.tbNomeCompleto.TabIndex = 38;
            this.tbNomeCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCadCliente
            // 
            this.lblCadCliente.AutoSize = true;
            this.lblCadCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliente.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCadCliente.Location = new System.Drawing.Point(56, 45);
            this.lblCadCliente.Name = "lblCadCliente";
            this.lblCadCliente.Size = new System.Drawing.Size(574, 69);
            this.lblCadCliente.TabIndex = 37;
            this.lblCadCliente.Text = "Cadastro de Cliente";
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeparador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeparador.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblSeparador.Location = new System.Drawing.Point(55, 156);
            this.lblSeparador.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(904, 10);
            this.lblSeparador.TabIndex = 36;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblNomeCompleto.Location = new System.Drawing.Point(50, 232);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(159, 25);
            this.lblNomeCompleto.TabIndex = 35;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbCpf.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.mtbCpf.Location = new System.Drawing.Point(55, 440);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(215, 30);
            this.mtbCpf.TabIndex = 51;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCadClientes
            // 
            this.lblCadClientes.AutoSize = true;
            this.lblCadClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblCadClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadClientes.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCadClientes.Location = new System.Drawing.Point(412, 231);
            this.lblCadClientes.Name = "lblCadClientes";
            this.lblCadClientes.Size = new System.Drawing.Size(206, 25);
            this.lblCadClientes.TabIndex = 52;
            this.lblCadClientes.Text = "Clientes Cadastrados:";
            // 
            // desafioVenda_dbDataSet1
            // 
            this.desafioVenda_dbDataSet1.DataSetName = "DesafioVenda_dbDataSet1";
            this.desafioVenda_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.desafioVenda_dbDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.desafioVenda_dbDataSet1;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            this.clienteBindingSource2.DataSource = this.desafioVenda_dbDataSet1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "idCliente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeCompleto";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeCompleto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn3.HeaderText = "email";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cpf";
            this.dataGridViewTextBoxColumn4.HeaderText = "cpf";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "celular";
            this.dataGridViewTextBoxColumn5.HeaderText = "celular";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 773);
            this.Controls.Add(this.lblCadClientes);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lblPCelular);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.tbNomeCompleto);
            this.Controls.Add(this.lblCadCliente);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.lblNomeCompleto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafioVenda_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lblPCelular;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.TextBox tbNomeCompleto;
        private System.Windows.Forms.Label lblCadCliente;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblCadClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private DesafioVenda_dbDataSet1 desafioVenda_dbDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private DesafioVenda_dbDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private DesafioVenda_dbDataSet1TableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
    }
}