using SimplesWindowsFormsBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesafioWinForms_DB
{
    internal class ItemVenda
    {
        int idItemVenda;
        int idVenda;
        int idProduto;
        int quantidade;
        float valorTotal;

        public ItemVenda(int idVenda, int idProduto, int quantidade, float valorTotal)
        {
            this.idVenda = idVenda;
            this.idProduto = idProduto;
            this.quantidade = quantidade;
            this.valorTotal = valorTotal;
        }

        public static int SelecionarProduto(string codEAN)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandType = CommandType.Text;
            SqlParameter idProduto = new SqlParameter("@idProduto", SqlDbType.Int);
            command.Parameters.Add(idProduto);
            idProduto.Direction = ParameterDirection.Output;
            command.CommandText = "select @idProduto=idProduto from Produto where codEAN = @codEAN";
            command.Parameters.AddWithValue("@codEAN", codEAN);

            try
            {
                command.ExecuteNonQuery();
                return int.Parse(idProduto.Value.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        public static bool SelecionarVenda(int idVendas)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Vendas where idVenda = @idVendas";
            command.Parameters.AddWithValue("@idVendas", idVendas);

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        public bool CadastrarItemVenda()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into ItemVenda values (@idVenda, @idProdutos, @quantidade, @valorTotal);";
            command.Parameters.Add("@idVenda", SqlDbType.Int);
            command.Parameters.Add("@idProdutos", SqlDbType.Int);
            command.Parameters.Add("@quantidade", SqlDbType.Int);
            command.Parameters.Add("@valorTotal", SqlDbType.Float);
            command.Parameters[0].Value = IdVenda;
            command.Parameters[1].Value = IdProduto;
            command.Parameters[2].Value = Quantidade;
            command.Parameters[3].Value = ValorTotal;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        public int IdItemVenda { get => idItemVenda; set => idItemVenda = value; }
        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
