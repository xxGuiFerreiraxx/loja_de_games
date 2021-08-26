using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loja_de_games.Models;

namespace loja_de_games.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult IndexJogo()
        {
            Jogo jogo = new Jogo();
            return View(jogo);
        }
        [HttpPost]

        public ActionResult IndexJogo(Jogo jogo)
        {
            if(ModelState.IsValid)
            {
                return View("ResultadoJogo", jogo);
            }
            return View(jogo);
        }

        public ActionResult ResultadoJogo(Jogo jogo)
        {
            return View(jogo);
        }

    }
}