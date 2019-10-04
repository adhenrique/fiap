using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_fiap.Web.AspNet.Models;
using _07_fiap.Web.AspNet.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _07_fiap.Web.AspNet.Controllers
{
    public class AlunoController : Controller
    {
        private IAlunoRepository _repository;
        private ITurmaRepository _turmaRepository;

        public AlunoController(IAlunoRepository repository, ITurmaRepository turmaRepository)
        {
            _repository = repository;
            _turmaRepository = turmaRepository;
        }

        public IActionResult Cadastrar()
        {
            var turmas = _turmaRepository.Listar();
            ViewBag.turmas = new SelectList(turmas, "TurmaId", "Nome");
            return View();
        }

        public IActionResult Index()
        {
            return View(_repository.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            _repository.Cadastrar(aluno);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado com sucesso";
            return RedirectToAction("Index");
        }
    }
}