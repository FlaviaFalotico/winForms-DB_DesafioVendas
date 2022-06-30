using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SimplesWindowsFormsBanco;


namespace WinForms_BancoDeDados
{
    internal class Pessoa
    {
        string nome;
        string sexo;
        int idade;
        float altura;
        float peso;
        string cpf;
        string endereco;
        string bairro;
        string cidade;
        string estado;
        string cep;

        public Pessoa(string nome, string sexo, int idade, float altura, float peso, string cpf, 
            string endereco, string bairro, string cidade, string estado, string cep)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.Idade = idade;
            this.Altura = altura;
            this.Peso = peso;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep; 
        }

        public Pessoa(string cpf)
        {
            this.cpf = cpf;
        }

        public bool gravarPessoa()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into pessoa values (@nome, @sexo, @idade, " +
                "@altura, @peso, @cpf, @endereco, @bairro, @cidade, @estado, @cep);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@sexo", SqlDbType.VarChar);
            command.Parameters.Add("@idade", SqlDbType.Int);
            command.Parameters.Add("@altura", SqlDbType.Float);
            command.Parameters.Add("@peso", SqlDbType.Float);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@endereco", SqlDbType.VarChar);
            command.Parameters.Add("@bairro", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters.Add("@estado", SqlDbType.VarChar);
            command.Parameters.Add("@cep", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Sexo;
            command.Parameters[2].Value = Idade;
            command.Parameters[3].Value = Altura.ToString("F2");
            command.Parameters[4].Value = Peso.ToString("F2");
            command.Parameters[5].Value = Cpf;
            command.Parameters[6].Value = Endereco;
            command.Parameters[7].Value = Bairro;
            command.Parameters[8].Value = Cidade;
            command.Parameters[9].Value = Estado;
            command.Parameters[10].Value = Cep;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        public static bool removerPessoa(string cpf)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from pessoa where cpf = @cpf";
            command.Parameters.AddWithValue("@cpf", cpf); //adicionando um parâmetro para 

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }
        public float Altura { get => altura; set => altura = value; }
        public float Peso { get => peso; set => peso = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
    }
}
