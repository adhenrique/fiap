using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Contexts;
using _06_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class ClienteController : Controller
    {
        private CartaoContext _context;

        public ClienteController(CartaoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Clientes.ToList());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            TempData["msg"] = "Cliente cadastrado com sucesso";
            return RedirectToAction("Index");
        }
    }
}