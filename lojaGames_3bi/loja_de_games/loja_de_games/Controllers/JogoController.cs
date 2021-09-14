using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loja_de_games.Models;
using loja_de_games.Repositorio;
using System.Collections.ObjectModel;

namespace loja_de_games.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Jogo()
        {
            Jogo jogo = new Jogo();
            return View(jogo);
        }
        AcoesJogo ac = new AcoesJogo();
        [HttpPost]

        public ActionResult CadJogo(Jogo jogo)
        {
            ac.CadastrarJogo(jogo);
            return View(jogo);
        }

        public ActionResult ResultadoJogo()
        {
            var ExibirJogo = new AcoesJogo();
            var TodosJogos = ExibirJogo.ResultadoJogo();
            return View(TodosJogos);
        }

    }
}