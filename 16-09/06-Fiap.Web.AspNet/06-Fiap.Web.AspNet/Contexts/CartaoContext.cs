using _06_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Contexts
{
    public class CartaoContext: DbContext
    {
        public DbSet<Cartao> Cartoes { get; set; }

        public CartaoContext(DbContextOptions options): base(options)
        {

        }
    }
}
