using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using _07_fiap.Web.AspNet.Contexts;
using _07_fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace _07_fiap.Web.AspNet.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private EscolaContext _context;

        public AlunoRepository(EscolaContext context)
        {
            _context = context;
        }

        public void Atualizar(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
        }

        public IList<Aluno> BuscarPor(Expression<Func<Aluno, bool>> filtro)
        {
            return _context.Alunos.Where(filtro).ToList();
        }

        public Aluno BuscarPorId(int id)
        {
            return _context.Alunos.Find(id);
        }

        public void Cadastrar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
        }

        public void Deletar(int id)
        {
            var aluno = _context.Alunos.Find(id);
            _context.Alunos.Remove(aluno);
        }

        public IList<Aluno> Listar()
        {
            return _context.Alunos.Include(a => a.Turma).ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
