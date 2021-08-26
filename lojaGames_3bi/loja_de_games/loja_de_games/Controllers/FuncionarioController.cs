using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loja_de_games.Models;
using System.Collections.ObjectModel;

namespace loja_de_games.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult IndexFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }
        [HttpPost]

        public ActionResult IndexFuncionario(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoFuncionario", funcionario);
            }
            return View(funcionario);
        }

        public ActionResult ResultadoFuncionario(Funcionario funcionario)
        {
            return View(funcionario);
        }
    }
}