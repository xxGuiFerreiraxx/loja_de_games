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
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Funcionario()
        public ActionResult IndexFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }
        Acoes ac = new Acoes();
        [HttpPost]

        public ActionResult CadFuncionario(Funcionario fun)
        public ActionResult IndexFuncionario(Funcionario funcionario)
        {
            ac.CadastrarFuncionario(fun);
            return View(fun);
            if (ModelState.IsValid)
            {
                return View("ResultadoFuncionario", funcionario);
            }
            return View(funcionario);
        }

        public ActionResult ListarFuncionario()
        public ActionResult ResultadoFuncionario(Funcionario funcionario)
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);

            return View(funcionario);
        }
    }
}