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
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }
        Acoes ac = new Acoes();
        [HttpPost]

        public ActionResult CadFuncionario(Funcionario fun)
        {
            ac.CadastrarFuncionario(fun);
            return View(fun);
        }

        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);
        }
    }
}