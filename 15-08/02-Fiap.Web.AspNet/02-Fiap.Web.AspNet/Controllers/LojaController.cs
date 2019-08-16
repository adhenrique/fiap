using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_Fiap.Web.AspNet.Controllers
{
    public class LojaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet] // abre a pagina do form
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost] // recupera os dados do form
        public IActionResult Cadastrar(Loja loja)
        {
            // envia valores para view
            ViewData["sergio"] = loja.Nome;
            ViewBag.churros = loja.Faturamento;

            // sobrevive após um redirect
            TempData["msg"] = "Cadastrado!";
            return View();
        }
    }
}