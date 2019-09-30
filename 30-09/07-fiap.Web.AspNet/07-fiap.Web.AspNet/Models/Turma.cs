using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_fiap.Web.AspNet.Models
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public string Nome { get; set; }
        public Periodo Periodo { get; set; }
        public IList<Aluno> Alunos { get; set; }
    }
}
