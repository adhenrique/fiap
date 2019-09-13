using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Contexts;
using _05_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class SorveteController : Controller
    {
        private SorveteriaContext _context;

        public SorveteController(SorveteriaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Sorvete sorvete)
        {
            _context.Sorvetes.Add(sorvete);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Sorvetes.ToList());
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var sorvete = _context.Sorvetes.Find(id);
            return View(sorvete);
        }

        [HttpPut]
        public IActionResult Editar(Sorvete sorvete)
        {
            _context.Attach(sorvete).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Salvo!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Remover(int codigo)
        {
            var sorvete = _context.Sorvetes.Find(codigo);
            _context.Sorvetes.Remove(sorvete);
            _context.SaveChanges();
            TempData["msg"] = "Item removido";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Buscar(string nome)
        {
            /* uma opcao para limpar a url
            if (nome == null)
            {
                return RedirectToAction("Listar");
            }
            */
            TempData["pesquisa"] = nome;
            // opcao para buscar somente se propriedade nao for vazia
            var sorvetes = _context.Sorvetes.Where(p => p.Nome.Contains(nome) || string.IsNullOrWhiteSpace(nome)).ToList();
            return View("Listar", sorvetes);
        }
    }
}