using _05_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Contexts
{
    public class SorveteriaContext : DbContext
    {
        public DbSet<Sorvete> Sorvetes { get; set; }

        //construtor
        public SorveteriaContext(DbContextOptions options) : base(options)
        {

        }
    }
}
