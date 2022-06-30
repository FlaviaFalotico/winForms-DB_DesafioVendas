using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioWinForms_DB
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tbNomeCompleto.Clear();
            tbEmail.Clear();
            mtbCpf.Clear();
            mtbCelular.Clear();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(tbNomeCompleto.Text, tbEmail.Text, mtbCpf.Text, mtbCelular.Text);
            bool ok = c.CadastrarCliente();
            if (ok)
            {
                MessageBox.Show("Nome Completo: " + c.NomeCompleto + "\nEmail: " + c.Email + "\nCPF: " 
                    + c.Cpf + "\nCelular: " + c.Celular, "Cadastro Realizado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clienteTableAdapter.Fill(this.desafioVenda_dbDataSet1.Cliente);
            }
            else
            {
                MessageBox.Show("Não foi Possível Realizar o Cadastro!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LimparCampos();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafioVenda_dbDataSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.desafioVenda_dbDataSet1.Cliente);

        }
    }
}
