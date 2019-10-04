using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_fiap.Web.AspNet.Models;
using _07_fiap.Web.AspNet.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _07_fiap.Web.AspNet.Controllers
{
    public class TurmaController : Controller
    {
        private ITurmaRepository _repository;

        public TurmaController(ITurmaRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(_repository.Listar());
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Turma turma)
        {
            _repository.Cadastrar(turma);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado com sucesso";
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var turma = _repository.BuscarPorId(id);
            return View(turma);
        }
    }
}