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
    public partial class FrmVenda : Form
    {
        static Venda venda ;
        public FrmVenda()
        {
            InitializeComponent();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafioVenda_dbDataSet1.ItemVenda'. Você pode movê-la ou removê-la conforme necessário.
            this.itemVendaTableAdapter.Fill(this.desafioVenda_dbDataSet1.ItemVenda);
            // TODO: esta linha de código carrega dados na tabela 'desafioVenda_dbDataSet1.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.desafioVenda_dbDataSet1.Vendas);

        }

        private void LimparCampos()
        {
            tbCliente.Clear();
            tbCodigoEAN.Clear();
            tbQuantidade.Clear();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Venda.SelecionarCliente(tbCliente.Text);
            //MessageBox.Show(idCliente.ToString());
            venda = new Venda(idCliente, 0);
            venda.CadastrarVenda();
            this.vendasTableAdapter.Fill(this.desafioVenda_dbDataSet1.Vendas);
            LimparCampos();
            venda.IdVenda = Venda.SelecionarUltimaVenda();
            MessageBox.Show(venda.IdVenda.ToString());
        }

        private void btBuscarProduto_Click(object sender, EventArgs e)
        {
            int idProduto = ItemVenda.SelecionarProduto(tbCodigoEAN.Text);
            //MessageBox.Show(idProduto.ToString());
            float preco = Venda.PrecoProduto(idProduto);
            int quantidade = int.Parse(tbQuantidade.Text);
            ItemVenda i = new ItemVenda(venda.IdVenda, idProduto, quantidade, preco*quantidade);
            MessageBox.Show(preco.ToString());
            bool ok = i.CadastrarItemVenda();
            if (ok)
            {
                MessageBox.Show("Venda: " + i.IdVenda + "\nProduto: " + i.IdProduto + "\nQuantidade: " + i.Quantidade + "\nValor Total: " + i.ValorTotal);
                this.itemVendaTableAdapter.Fill(this.desafioVenda_dbDataSet1.ItemVenda);
            }
            else
            {
                MessageBox.Show("Não foi Possível Realizar o Cadastro da Venda do Item!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            venda.ValorTotal += preco*quantidade;
            venda.AtualizarVenda();
            this.vendasTableAdapter.Fill(this.desafioVenda_dbDataSet1.Vendas);
        }
    }
}
