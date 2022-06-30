using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SimplesWindowsFormsBanco;
using System.Windows.Forms;

namespace DesafioWinForms_DB
{
    internal class Venda
    {
        int idVenda;        
        int idCliente;
        float valorTotal;

        public Venda( int idCliente, float valorTotal)
        {
            this.idCliente = idCliente;
            this.valorTotal = valorTotal;
        }

        public static int SelecionarCliente(string cpf)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandType = CommandType.Text;
            SqlParameter idCliente = new SqlParameter("@idCliente", SqlDbType.Int);
            command.Parameters.Add(idCliente);
            idCliente.Direction = ParameterDirection.Output;
            command.CommandText = "select @idCliente=idCliente from Cliente where cpf = @cpf";
            command.Parameters.AddWithValue("@cpf", cpf); 
            
            try
            {
                command.ExecuteNonQuery();
                return int.Parse(idCliente.Value.ToString());
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

        public static int SelecionarUltimaVenda()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandType = CommandType.Text;
            SqlParameter idVenda = new SqlParameter("@idVenda", SqlDbType.Int);
            command.Parameters.Add(idVenda);
            idVenda.Direction = ParameterDirection.Output;
            command.CommandText = "select top 1 @idVenda=idVenda from Vendas order by idVenda DESC";
            
            try
            {
                command.ExecuteNonQuery();
                return int.Parse(idVenda.Value.ToString());
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

        public static float PrecoProduto(int idProduto)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandType = CommandType.Text;
            SqlParameter preco = new SqlParameter("@preco", SqlDbType.Float);
            command.Parameters.Add(preco);
            preco.Direction = ParameterDirection.Output;
            command.CommandText = "select @preco=preco from Produto where idProduto = @idProduto";
            command.Parameters.AddWithValue("@idProduto", idProduto);

            try
            {
                command.ExecuteNonQuery();
                return float.Parse(preco.Value.ToString());
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

        public bool CadastrarVenda()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Vendas(Cliente_idCliente, valorTotal) values (@idCliente, @valorTotal);";
            command.Parameters.AddWithValue("@idCliente", idCliente);
            command.Parameters.AddWithValue("@valorTotal", valorTotal);

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        public bool AtualizarVenda()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update Vendas set valorTotal=@valorTotal where idVenda= @idVenda;";
            command.Parameters.AddWithValue("@idVenda", idVenda);
            command.Parameters.AddWithValue("@valorTotal", valorTotal);

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
