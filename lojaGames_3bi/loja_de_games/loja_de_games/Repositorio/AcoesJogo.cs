using MySql.Data.MySqlClient;
using loja_de_games.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loja_de_games.Repositorio
{
    public class AcoesJogo
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarJogo(Jogo jogo)
        {
            
            MySqlCommand cmd = new MySqlCommand("insert into Jogo values (@CodigoJogo,@NomeJogo,@Versao,@Desenvolvedor,@Genero,@FaixaEtaria,@Plataforma,@Sinopse,@AnoLancamento)", con.ConectarBD());
            cmd.Parameters.Add("@CodigoJogo", MySqlDbType.Int32).Value = jogo.CodigoJogo;
            cmd.Parameters.Add("@NomeJogo", MySqlDbType.VarChar).Value = jogo.NomeJogo;
            cmd.Parameters.Add("@Versao", MySqlDbType.VarChar).Value = jogo.Versao;
            cmd.Parameters.Add("@Desenvolvedor", MySqlDbType.VarChar).Value = jogo.Desenvolvedor;
            cmd.Parameters.Add("@Genero", MySqlDbType.VarChar).Value = jogo.Genero;
            cmd.Parameters.Add("@FaixaEtaria", MySqlDbType.Int32).Value = jogo.FaixaEtaria;
            cmd.Parameters.Add("@Plataforma", MySqlDbType.VarChar).Value = jogo.Plataforma;
            cmd.Parameters.Add("@Sinopse", MySqlDbType.VarChar).Value = jogo.Sinopse;
            cmd.Parameters.Add("@AnoLancamento", MySqlDbType.Int32).Value = jogo.AnoLancamento;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Jogo ListarCodJogo(int jg)
        {
            var comando = String.Format("select * from Jogo where CodigoJogo = {0}", jg);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosJogo = cmd.ExecuteReader();
            return ListarCodJogo(DadosJogo).FirstOrDefault();
        }

        public List<Jogo> ListarCodJogo(MySqlDataReader dt)
        {
            var AltAl = new List<Jogo>();
            while (dt.Read())
            {
                var AlTemp = new Jogo()
                {
                    CodigoJogo = dt["CodigoJogo"].ToString(),
                    NomeJogo = dt["NomeJogo"].ToString(),
                    Versao = dt["Versao"].ToString(),
                    Desenvolvedor = dt["Desenvolvedor"].ToString(),
                    Genero = dt["Genero"].ToString(),
                    FaixaEtaria = dt["FaixaEtaria"].ToString(),
                    Plataforma = dt["Plataforma"].ToString(),
                    Sinopse = dt["Sinopse"].ToString(),
                    AnoLancamento = dt["AnoLancamento"].ToString()
                };
                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<Jogo> ResultadoJogo()
        {
            MySqlCommand cmd = new MySqlCommand("select * from Jogo", con.ConectarBD());
            var DadosJogo = cmd.ExecuteReader();
            return ListarTodosJogo(DadosJogo);
        }

        public List<Jogo> ListarTodosJogo(MySqlDataReader dt)
        {
            var TodosJogos = new List<Jogo>();
            while (dt.Read())
            {
                var JogoTemp = new Jogo()
                {
                    CodigoJogo = dt["CodigoJogo"].ToString(),
                    NomeJogo = dt["NomeJogo"].ToString(),
                    Versao = dt["Versao"].ToString(),
                    Desenvolvedor = dt["Desenvolvedor"].ToString(),
                    Genero = dt["Genero"].ToString(),
                    FaixaEtaria = dt["FaixaEtaria"].ToString(),
                    Plataforma = dt["Plataforma"].ToString(),
                    Sinopse = dt["Sinopse"].ToString(),
                    AnoLancamento = dt["AnoLancamento"].ToString()
                };
                TodosJogos.Add(JogoTemp);
            }

            dt.Close();
            return TodosJogos;
        }
    }
}