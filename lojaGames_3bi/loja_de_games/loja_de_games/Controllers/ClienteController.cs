using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loja_de_games.Models;
using System.Collections.ObjectModel;

namespace loja_de_games.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult IndexCliente()
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }
        [HttpPost]

        public ActionResult IndexCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoCliente", cliente);
            }
            return View(cliente);
        }

        public ActionResult ResultadoCliente(Cliente cliente)
        {
            return View(cliente);
        }
    }
}