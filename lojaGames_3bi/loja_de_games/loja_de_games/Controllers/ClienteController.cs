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
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cliente()
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }
        AcoesCli ac = new AcoesCli();
        [HttpPost]

        public ActionResult CadCliente(Cliente cli)
        {
            ac.CadastrarCliente(cli);
            return View(cli);
        }

        public ActionResult ResultadoCliente()
        {
            var ExibirCli = new AcoesCli();
            var TodosCli = ExibirCli.ResultadoCliente();
            return View(TodosCli);
        }

    }
}