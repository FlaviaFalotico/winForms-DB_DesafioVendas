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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tbDescricaoProd.Clear();
            tbCategoriaProd.Clear();
            tbCodigoProd.Clear();
            mtbPreco.Clear();
            tbEstoqueProd.Clear();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto(tbDescricaoProd.Text, tbCategoriaProd.Text, tbCodigoProd.Text, 
                float.Parse(mtbPreco.Text), int.Parse(tbEstoqueProd.Text));
            bool ok = p.CadastrarProduto();
            if (ok)
            {
                MessageBox.Show("Descrição: " + p.Descricao + "\nCategoria: " + p.Categoria + "\nCódigo: "
                    + p.CodEAN + "\nPreço: R$" + p.Preco.ToString("F2") + "\nEstoque: " + p.Estoque, 
                    "Cadastro Realizado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.produtoTableAdapter.Fill(this.desafioVenda_dbDataSet1.Produto);
            }
            else
            {
                MessageBox.Show("Não foi Possível Realizar o Cadastro!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LimparCampos();

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafioVenda_dbDataSet1.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.desafioVenda_dbDataSet1.Produto);

        }
    }
}
