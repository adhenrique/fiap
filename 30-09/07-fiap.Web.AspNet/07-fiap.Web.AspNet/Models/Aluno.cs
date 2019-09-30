using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _07_fiap.Web.AspNet.Models
{
    public class Aluno
    {
        [Key]
        public int Rm { get; set; }
        public string Nome { get; set; }
        public Genero Genero { get; set; }
        public bool Retido { get; set; }
        public Turma Turma { get; set; }
        public int TurmaId { get; set; }
    }
}
