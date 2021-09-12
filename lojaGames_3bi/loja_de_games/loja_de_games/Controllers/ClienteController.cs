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
        public ActionResult IndexCliente()
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }
        AcoesCli ac = new AcoesCli();
        [HttpPost]

        public ActionResult CadCliente(Cliente cli)
        public ActionResult IndexCliente(Cliente cliente)
        {
            ac.CadastrarCliente(cli);
            return View(cli);
            if (ModelState.IsValid)
            {
                return View("ResultadoCliente", cliente);
            }
            return View(cliente);
        }

        public ActionResult ResultadoCliente()
        public ActionResult ResultadoCliente(Cliente cliente)
        {
        }
    }
}