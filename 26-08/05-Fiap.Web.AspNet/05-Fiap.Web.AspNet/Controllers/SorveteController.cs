using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class SorveteController : Controller
    {
        private static IList<Sorvete> _lista = new List<Sorvete>();

        // GET: Sorvete
        public ActionResult Index()
        {
            return View(_lista);
        }

        // GET: Sorvete/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sorvete/Create
        [HttpPost]
        public ActionResult Create(Sorvete sorvete)
        {
            try
            {
                _lista.Add(sorvete);
                TempData["msg"] = "Cadastrado";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}