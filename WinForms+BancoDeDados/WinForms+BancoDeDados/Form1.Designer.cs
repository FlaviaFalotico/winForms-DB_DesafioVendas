namespace WinForms_BancoDeDados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lblEsndereco = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.cadastroDePessoas_DBDataSet = new WinForms_BancoDeDados.cadastroDePessoas_DBDataSet();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new WinForms_BancoDeDados.cadastroDePessoas_DBDataSetTableAdapters.pessoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDePessoas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo:";
            // 
            // tbNome
            // 
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Location = new System.Drawing.Point(144, 43);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(316, 22);
            this.tbNome.TabIndex = 1;
            // 
            // tbCpf
            // 
            this.tbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCpf.Location = new System.Drawing.Point(142, 356);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(316, 22);
            this.tbCpf.TabIndex = 3;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(25, 358);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(36, 16);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            // 
            // tbPeso
            // 
            this.tbPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPeso.Location = new System.Drawing.Point(142, 291);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(316, 22);
            this.tbPeso.TabIndex = 5;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(25, 293);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 16);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso:";
            // 
            // tbAltura
            // 
            this.tbAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAltura.Location = new System.Drawing.Point(144, 221);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(316, 22);
            this.tbAltura.TabIndex = 7;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(27, 223);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(44, 16);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura:";
            // 
            // tbIdade
            // 
            this.tbIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIdade.Location = new System.Drawing.Point(144, 159);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(316, 22);
            this.tbIdade.TabIndex = 9;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(27, 161);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(45, 16);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "Idade:";
            // 
            // tbSexo
            // 
            this.tbSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSexo.Location = new System.Drawing.Point(144, 97);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(316, 22);
            this.tbSexo.TabIndex = 11;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(27, 99);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 16);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndereco.Location = new System.Drawing.Point(595, 37);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(316, 22);
            this.tbEndereco.TabIndex = 13;
            // 
            // lblEsndereco
            // 
            this.lblEsndereco.AutoSize = true;
            this.lblEsndereco.Location = new System.Drawing.Point(514, 43);
            this.lblEsndereco.Name = "lblEsndereco";
            this.lblEsndereco.Size = new System.Drawing.Size(69, 16);
            this.lblEsndereco.TabIndex = 12;
            this.lblEsndereco.Text = "Endereço:";
            // 
            // tbBairro
            // 
            this.tbBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBairro.Location = new System.Drawing.Point(595, 97);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(316, 22);
            this.tbBairro.TabIndex = 15;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(514, 108);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 16);
            this.lblBairro.TabIndex = 14;
            this.lblBairro.Text = "Bairro:";
            // 
            // tbCidade
            // 
            this.tbCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCidade.Location = new System.Drawing.Point(595, 166);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(316, 22);
            this.tbCidade.TabIndex = 17;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(514, 172);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 16);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade:";
            // 
            // tbCep
            // 
            this.tbCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCep.Location = new System.Drawing.Point(593, 291);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(316, 22);
            this.tbCep.TabIndex = 19;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(514, 297);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(37, 16);
            this.lblCep.TabIndex = 18;
            this.lblCep.Text = "CEP:";
            // 
            // tbEstado
            // 
            this.tbEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstado.Location = new System.Drawing.Point(595, 233);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(316, 22);
            this.tbEstado.TabIndex = 21;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(514, 239);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado:";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(600, 347);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(84, 31);
            this.btSalvar.TabIndex = 22;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(827, 347);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(84, 31);
            this.btRemover.TabIndex = 23;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(716, 347);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(84, 31);
            this.btLimpar.TabIndex = 24;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // cadastroDePessoas_DBDataSet
            // 
            this.cadastroDePessoas_DBDataSet.DataSetName = "cadastroDePessoas_DBDataSet";
            this.cadastroDePessoas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "pessoa";
            this.pessoaBindingSource.DataSource = this.cadastroDePessoas_DBDataSet;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 635);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tbCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lblEsndereco);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDePessoas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lblEsndereco;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btLimpar;
        private cadastroDePessoas_DBDataSet cadastroDePessoas_DBDataSet;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private cadastroDePessoas_DBDataSetTableAdapters.pessoaTableAdapter pessoaTableAdapter;
    }
}

