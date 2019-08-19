using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exercicio2.Controllers
{
    public class UsuarioController : Controller
    {
        // armazena os usuarios em memoria
        private static IList<Usuario> _lista = new List<Usuario>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public void Cadastrar(Usuario usuario)
        {
            ViewBag.nome = usuario.Nome;
            ViewBag.dataNascimento = usuario.DataNascimento;
            ViewBag.email = usuario.Email;

            TempData["msg"] = "Cadastrado!";

            _lista.Add(usuario);

            // enviando objeto usuario para view
            return View("index", _lista); //sobrecarga
        }
    }
}
