
using MySql.Data.MySqlClient;
using loja_de_games.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loja_de_games.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarFuncionario(Funcionario func)
        {
            string data_sistema = Convert.ToDateTime(func.DataNascimento).ToString("yyyy/MM/dd");
            MySqlCommand cmd = new MySqlCommand("insert into Funcionario values (@CodigoFunc,@NomeFunc,@CPF_Func,@RGFunc,@Email,@Celular,@Estado,@Cidade,@Logradouro,@Cargo,@DataNascimento)", con.ConectarBD());
            cmd.Parameters.Add("@CodigoFunc", MySqlDbType.VarChar).Value = func.CodigoFunc;
            cmd.Parameters.Add("@NomeFunc", MySqlDbType.VarChar).Value = func.NomeFunc;
            cmd.Parameters.Add("@CPF_Func", MySqlDbType.VarChar).Value = func.CPF_Func;
            cmd.Parameters.Add("@RGFunc", MySqlDbType.VarChar).Value = func.RgFunc;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = func.Email;
            cmd.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = func.Celular;
            cmd.Parameters.Add("@Estado", MySqlDbType.VarChar).Value = func.Estado;
            cmd.Parameters.Add("@Cidade", MySqlDbType.VarChar).Value = func.Cidade;
            cmd.Parameters.Add("@Logradouro", MySqlDbType.VarChar).Value = func.Logradouro;
            cmd.Parameters.Add("@Cargo", MySqlDbType.VarChar).Value = func.Cargo;
            cmd.Parameters.Add("@DataNascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Funcionario ListarCodFuncionario(int cod)
        {
            var comando = String.Format("select * from Funcionario where CodigoFunc = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarCodFunc(DadosCodFunc).FirstOrDefault();
        }

        public List<Funcionario> ListarCodFunc(MySqlDataReader dt)
        {
            var AltAl = new List<Funcionario>();
            while (dt.Read())
            {
                var AlTemp = new Funcionario()
                {
                    CodigoFunc = dt["CodigoFunc"].ToString(),
                    NomeFunc = dt["NomeFunc"].ToString(),
                    CPF_Func = dt["CPF_Func"].ToString(),
                    RgFunc = dt["RGFunc"].ToString(),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Estado = dt["Estado"].ToString(),
                    Cidade = dt["Cidade"].ToString(),
                    Logradouro = dt["Logradouro"].ToString(),
                    Cargo = dt["Cargo"].ToString(),
                    DataNascimento = DateTime.Parse(dt["DataNascimento"].ToString())
                };
                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;


        }

        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("select * from Funcionario", con.ConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionario(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionario(MySqlDataReader dt)
        {
            var TodosFuncionarios = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {
                    CodigoFunc = dt["CodigoFunc"].ToString(),
                    NomeFunc = dt["NomeFunc"].ToString(),
                    CPF_Func = dt["CPF_Func"].ToString(),
                    RgFunc = dt["RGFunc"].ToString(),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Estado = dt["Estado"].ToString(),
                    Cidade = dt["Cidade"].ToString(),
                    Logradouro = dt["Logradouro"].ToString(),
                    Cargo = dt["Cargo"].ToString(),
                    DataNascimento = DateTime.Parse(dt["DataNascimento"].ToString())
                };
                TodosFuncionarios.Add(FuncionarioTemp);
            }

            dt.Close();
            return TodosFuncionarios;
        }

        public void CadastrarCliente(Cliente cli)
        {
            string data_sistema = Convert.ToDateTime(cli.DataNascimento).ToString("yyyy/MM/dd");
            MySqlCommand cmd = new MySqlCommand("insert into Cliente values (@NomeCLi,@CPFCli,@Email,@Celular,@Cidade,@Estado,@Logradouro,@DataNascimento)", con.ConectarBD());
            cmd.Parameters.Add("@NomeCLi", MySqlDbType.VarChar).Value = cli.NomeCli;
            cmd.Parameters.Add("@CPFCli", MySqlDbType.VarChar).Value = cli.CPFCli;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = cli.Email;
            cmd.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = cli.Celular;
            cmd.Parameters.Add("@Cidade", MySqlDbType.VarChar).Value = cli.Cidade;
            cmd.Parameters.Add("@Estado", MySqlDbType.VarChar).Value = cli.Estado;
            cmd.Parameters.Add("@Logradouro", MySqlDbType.VarChar).Value = cli.Logradouro;
            cmd.Parameters.Add("@DataNascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Cliente ListarCPFCli(int cpf)
        {
            var comando2 = String.Format("select * from Cliente where CPFCli = {0}", cpf);
            MySqlCommand cmd = new MySqlCommand(comando2, con.ConectarBD());
            var DadosCPFCli = cmd.ExecuteReader();
            return ListarCPFCli(DadosCPFCli).FirstOrDefault();
        }
        public List<Cliente> ListarCPFCli(MySqlDataReader dt2)
        {
            var AltAl2 = new List<Cliente>();
            while (dt2.Read())
            {
                var AlTemp2 = new Cliente()
                {
                    NomeCli = dt2["NomeCli"].ToString(),
                    CPFCli = dt2["NomeFunc"].ToString(),
                    Email = dt2["Email"].ToString(),
                    Celular = dt2["Celular"].ToString(),
                    Cidade = dt2["Cidade"].ToString(),
                    Estado = dt2["Estado"].ToString(),
                    Logradouro = dt2["Logradouro"].ToString(),
                    DataNascimento = DateTime.Parse(dt2["DataNascimento"].ToString())
                };
                AltAl2.Add(AlTemp2);
            }

            dt2.Close();
            return AltAl2;


        }

        public List<Cliente> ResultadoCliente()
        {
            MySqlCommand cmd = new MySqlCommand("select * from Cliente", con.ConectarBD());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosCliente(DadosCliente);
        }

        public List<Cliente> ListarTodosCliente(MySqlDataReader dt2)
        {
            var TodosClientes = new List<Cliente>();
            while (dt2.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    NomeCli = dt2["NomeCli"].ToString(),
                    CPFCli = dt2["NomeFunc"].ToString(),
                    Email = dt2["Email"].ToString(),
                    Celular = dt2["Celular"].ToString(),
                    Cidade = dt2["Cidade"].ToString(),
                    Estado = dt2["Estado"].ToString(),
                    Logradouro = dt2["Logradouro"].ToString(),
                    DataNascimento = DateTime.Parse(dt2["DataNascimento"].ToString())
                };
                TodosClientes.Add(ClienteTemp);
            }

            dt2.Close();
            return TodosClientes;
        }
    }
}