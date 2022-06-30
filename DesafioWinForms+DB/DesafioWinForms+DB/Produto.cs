using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SimplesWindowsFormsBanco;

namespace DesafioWinForms_DB
{
    internal class Produto
    {
        int idProduto;
        string descricao;
        string categoria;
        string codEAN;
        float preco;
        int estoque;

        public Produto(string descricao, string categoria, string codEAN, float preco, int estoque)
        {
            this.descricao = descricao;
            this.categoria = categoria;
            this.codEAN = Guid.NewGuid().ToString().Substring(1,9);
            this.preco = preco;
            this.estoque = estoque;
        }

        public Produto(string codEAN)
        {
            this.codEAN = codEAN;

        }

        public bool CadastrarProduto()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Produto values (@descricao, @categoria, @codEAN, @preco, @estoque);";
            command.Parameters.Add("@descricao", SqlDbType.VarChar);
            command.Parameters.Add("@categoria", SqlDbType.VarChar);
            command.Parameters.Add("@codEAN", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Float);
            command.Parameters.Add("@estoque", SqlDbType.Int);
            command.Parameters[0].Value = Descricao;
            command.Parameters[1].Value = Categoria;
            command.Parameters[2].Value = CodEAN;
            command.Parameters[3].Value = Preco.ToString("F2");
            command.Parameters[4].Value = Estoque;

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

        public static bool RemoverProduto(string codEAN)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Produto where codEAN = @codEAN";
            command.Parameters.AddWithValue("@codEAN", codEAN);

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

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string CodEAN { get => codEAN; set => codEAN = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }
    }
}
