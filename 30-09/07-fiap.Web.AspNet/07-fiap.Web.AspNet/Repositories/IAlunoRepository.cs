using _07_fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace _07_fiap.Web.AspNet.Repositories
{
    public interface IAlunoRepository
    {
        void Cadastrar(Aluno aluno);
        void Atualizar(Aluno aluno);
        void Deletar(int id);
        Aluno BuscarPorId(int id);
        IList<Aluno> Listar();
        IList<Aluno> BuscarPor(Expression<Func<Aluno, bool>> filtro);
        void Salvar();
    }
}
