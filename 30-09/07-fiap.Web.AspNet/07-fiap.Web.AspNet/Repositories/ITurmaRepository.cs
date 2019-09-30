using _07_fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace _07_fiap.Web.AspNet.Repositories
{
    public interface ITurmaRepository
    {
        void Cadastrar(Turma turma);
        void Atualizar(Turma turma);
        void Deletar(int id);
        Turma BuscarPorId(int id);
        IList<Turma> Listar();
        IList<Turma> BuscarPor(Expression<Func<Turma, bool>> filtro);
        void Salvar();
    }
}
