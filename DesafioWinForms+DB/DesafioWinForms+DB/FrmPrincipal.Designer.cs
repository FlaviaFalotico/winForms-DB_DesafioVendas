namespace DesafioWinForms_DB
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btCliente = new System.Windows.Forms.Button();
            this.labelLicenca = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.btVenda = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelMenu.Controls.Add(this.labelLicenca);
            this.panelMenu.Controls.Add(this.btCliente);
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btProduto);
            this.panelMenu.Controls.Add(this.btVenda);
            this.panelMenu.Controls.Add(this.btHome);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenu.Location = new System.Drawing.Point(-3, 96);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(321, 676);
            this.panelMenu.TabIndex = 0;
            // 
            // btCliente
            // 
            this.btCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCliente.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCliente.Location = new System.Drawing.Point(3, 124);
            this.btCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(316, 110);
            this.btCliente.TabIndex = 5;
            this.btCliente.Text = "Clientes ";
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // labelLicenca
            // 
            this.labelLicenca.AutoSize = true;
            this.labelLicenca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLicenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelLicenca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLicenca.Location = new System.Drawing.Point(15, 638);
            this.labelLicenca.Name = "labelLicenca";
            this.labelLicenca.Size = new System.Drawing.Size(210, 15);
            this.labelLicenca.TabIndex = 4;
            this.labelLicenca.Text = "© 2022 Rhapsody. All rights reserved.";
            // 
            // btSair
            // 
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSair.Location = new System.Drawing.Point(3, 466);
            this.btSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(316, 110);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Location = new System.Drawing.Point(-3, -1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(321, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // btHome
            // 
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btHome.Location = new System.Drawing.Point(3, 10);
            this.btHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(316, 110);
            this.btHome.TabIndex = 2;
            this.btHome.Text = "Home  ";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btProduto
            // 
            this.btProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProduto.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btProduto.FlatAppearance.BorderSize = 0;
            this.btProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduto.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btProduto.Location = new System.Drawing.Point(3, 238);
            this.btProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(316, 110);
            this.btProduto.TabIndex = 6;
            this.btProduto.Text = "Produtos";
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // btVenda
            // 
            this.btVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVenda.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btVenda.FlatAppearance.BorderSize = 0;
            this.btVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVenda.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVenda.Location = new System.Drawing.Point(3, 352);
            this.btVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(316, 110);
            this.btVenda.TabIndex = 7;
            this.btVenda.Text = "Venda";
            this.btVenda.UseVisualStyleBackColor = true;
            this.btVenda.Click += new System.EventHandler(this.btVenda_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelForm.BackgroundImage")));
            this.panelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelForm.Location = new System.Drawing.Point(315, -1);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1142, 773);
            this.panelForm.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1455, 772);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Rhapsody";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLicenca;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.Button btSair;
    }
}

