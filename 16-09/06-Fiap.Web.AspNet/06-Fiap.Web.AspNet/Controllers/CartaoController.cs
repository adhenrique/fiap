using _06_Fiap.Web.AspNet.Contexts;
using _06_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class CartaoController : Controller
    {
        private CartaoContext _context;

        public CartaoController(CartaoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Cartoes.ToList());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var cartao = _context.Cartoes.Find(id);
            return View(cartao);
        }

        [HttpGet]
        public IActionResult Buscar(string bandeira)
        {
            TempData["bandeira"] = bandeira;
            var cartoes = _context.Cartoes.Where(p => p.Bandeira.Equals(bandeira)).ToList();
            return View("Listar", cartoes);
        }

        [HttpPost]
        public IActionResult Cadastrar(Cartao cartao)
        {
            _context.Cartoes.Add(cartao);
            _context.SaveChanges();
            TempData["msg"] = "Cartao cadastrado com sucesso.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Cartao cartao)
        {
            _context.Attach(cartao).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Cartao editado com sucesso.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int codigo)
        {
            var cartao = _context.Cartoes.Find(codigo);
            _context.Cartoes.Remove(cartao);
            _context.SaveChanges();
            TempData["msg"] = "Cartao removido.";
            return RedirectToAction("Index");
        }
    }
}
