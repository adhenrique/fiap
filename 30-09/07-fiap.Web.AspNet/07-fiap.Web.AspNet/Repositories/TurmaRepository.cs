using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using _07_fiap.Web.AspNet.Contexts;
using _07_fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07_fiap.Web.AspNet.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        private EscolaContext _context;

        public TurmaRepository(EscolaContext context)
        {
            _context = context;
        }


        public void Atualizar(Turma turma)
        {
            _context.Turmas.Update(turma);
        }

        public IList<Turma> BuscarPor(Expression<Func<Turma, bool>> filtro)
        {

            return _context.Turmas.Where(filtro).ToList();
        }

        public Turma BuscarPorId(int id)
        {

            return _context.Turmas.Find(id);
        }

        public void Cadastrar(Turma turma)
        {
            _context.Turmas.Add(turma);
        }

        public void Deletar(int id)
        {
            var turma = _context.Turmas.Find(id);
            _context.Turmas.Remove(turma);
        }

        public IList<Turma> Listar()
        {
            return _context.Turmas.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
