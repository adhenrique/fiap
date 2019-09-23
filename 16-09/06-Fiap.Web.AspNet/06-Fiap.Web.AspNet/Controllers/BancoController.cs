using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Contexts;
using _06_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class BancoController : Controller
    {
        private CartaoContext _context;

        public BancoController(CartaoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Bancos.ToList());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Banco banco)
        {
            _context.Bancos.Add(banco);
            _context.SaveChanges();
            TempData["msg"] = "Banco cadastrado com sucesso";
            return RedirectToAction("Index");
        }
    }
}