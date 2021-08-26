using MySql.Data.MySqlClient;
using loja_de_games.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loja_de_games.Repositorio
{
    public class AcoesCli
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarCliente(Cliente cli)
        {
            string data_sistema = Convert.ToDateTime(cli.DataNascimento).ToString("yyyy/MM/dd");
            MySqlCommand cmd = new MySqlCommand("insert into Cliente values (@NomeCLi,@CPFCli,@Email,@Celular,@Cidade,@Estado,@Logradouro,@DataNascimento)", con.ConectarBD());
            cmd.Parameters.Add("@NomeCLi", MySqlDbType.VarChar).Value = cli.NomeCli;
            cmd.Parameters.Add("@CPFCli", MySqlDbType.VarChar).Value = cli.CPFCli;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = cli.Email;
            cmd.Parameters.Add("@Celular", MySqlDbType.Int32).Value = cli.Celular;
            cmd.Parameters.Add("@Cidade", MySqlDbType.VarChar).Value = cli.Cidade;
            cmd.Parameters.Add("@Estado", MySqlDbType.VarChar).Value = cli.Estado;
            cmd.Parameters.Add("@Logradouro", MySqlDbType.VarChar).Value = cli.Logradouro;
            cmd.Parameters.Add("@DataNascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Cliente ListarCPFCli(int cpf)
        {
            var comando = String.Format("select * from Cliente where CPFCli = {0}", cpf);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCPFCli = cmd.ExecuteReader();
            return ListarCPFCli(DadosCPFCli).FirstOrDefault();
        }
        public List<Cliente> ListarCPFCli(MySqlDataReader dt)
        {
            var AltAl = new List<Cliente>();
            while (dt.Read())
            {
                var AlTemp = new Cliente()
                {
                    NomeCli = dt["NomeCli"].ToString(),
                    CPFCli = dt["NomeFunc"].ToString(),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Cidade = dt["Cidade"].ToString(),
                    Estado = dt["Estado"].ToString(),
                    Logradouro = dt["Logradouro"].ToString(),
                    DataNascimento = DateTime.Parse(dt["DataNascimento"].ToString())
                };
                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;


        }

        public List<Cliente> ResultadoCliente()
        {
            MySqlCommand cmd = new MySqlCommand("select * from Cliente", con.ConectarBD());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosCliente(DadosCliente);
        }

        public List<Cliente> ListarTodosCliente(MySqlDataReader dt)
        {
            var TodosClientes = new List<Cliente>();
            while (dt.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    NomeCli = dt["NomeCli"].ToString(),
                    CPFCli = dt["CPFCli"].ToString(),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Cidade = dt["Cidade"].ToString(),
                    Estado = dt["Estado"].ToString(),
                    Logradouro = dt["Logradouro"].ToString(),
                    DataNascimento = DateTime.Parse(dt["DataNascimento"].ToString())
                };
                TodosClientes.Add(ClienteTemp);
            }

            dt.Close();
            return TodosClientes;
        }
    }
}