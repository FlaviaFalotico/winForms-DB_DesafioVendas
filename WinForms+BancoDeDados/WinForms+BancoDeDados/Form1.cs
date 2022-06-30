using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_BancoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tbNome.Clear();
            tbSexo.Clear();
            tbIdade.Clear();
            tbAltura.Clear();
            tbPeso.Clear();
            tbCpf.Clear();
            tbEndereco.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            tbEstado.Clear();
            tbCep.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa(tbNome.Text, tbSexo.Text, int.Parse(tbIdade.Text), 
                float.Parse(tbAltura.Text), float.Parse(tbPeso.Text), tbCpf.Text, 
                tbEndereco.Text, tbBairro.Text, tbCidade.Text, tbEstado.Text, tbCep.Text);
            MessageBox.Show("Nome Completo: " + p.Nome + "\nSexo: " + p.Sexo + "\nIdade: "
                + p.Idade + "\nAltura: " + p.Altura + "\nPeso: " + p.Peso + "\nCPF: " 
                + p.Cpf + "\nEndereço: " + p.Endereco + "\nBairro: " + p.Bairro 
                + "\nCidade: " + p.Cidade + "\nEstado: " + p.Estado + "\nCEP: " + p.Cep);

            LimparCampos();
            p.gravarPessoa();
            //this.pessoaTableAdapter.Fill(this.cadastroDePessoas_DBDataSet.pessoa);

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            
           LimparCampos();
           Pessoa.removerPessoa(tbCpf.Text);
           //this.pessoaTableAdapter.Fill(this.cadastroDePessoas_DBDataSet.pessoa);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.pessoaTableAdapter.Fill(this.cadastroDePessoas_DBDataSet.pessoa);
        }
    }
}

