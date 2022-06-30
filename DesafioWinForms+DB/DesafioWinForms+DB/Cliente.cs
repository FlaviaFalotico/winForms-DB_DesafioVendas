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
    internal class Cliente
    {
        int idCliente;
        string nomeCompleto;
        string email;
        string cpf;
        string celular;

        public Cliente(string nomeCompleto, string email, string cpf, string celular)
        {
            this.nomeCompleto = nomeCompleto;
            this.email = email;
            this.cpf = cpf;
            this.celular = celular;
        }

        public Cliente(string cpf)
        {
            this.cpf = cpf;
        }

        public bool CadastrarCliente()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Cliente values (@nomeCompleto, @email, @cpf, @celular);";
            command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@celular", SqlDbType.VarChar);
            command.Parameters[0].Value = NomeCompleto;
            command.Parameters[1].Value = Email;
            command.Parameters[2].Value = Cpf;
            command.Parameters[3].Value = Celular;

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

        public static bool RemoverCliente(string cpf)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Cliente where cpf = @cpf";
            command.Parameters.AddWithValue("@cpf", cpf);

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

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Celular { get => celular; set => celular = value; }        
    }
}
