using _07_fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_fiap.Web.AspNet.Contexts
{
    public class EscolaContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        public EscolaContext(DbContextOptions o) : base(o)
        {

        }
    }
}
