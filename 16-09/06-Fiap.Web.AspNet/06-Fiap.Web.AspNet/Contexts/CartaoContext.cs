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
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<FundoInvestimento> FundoInvestimentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Confiurar as chaves da tabela
            modelBuilder.Entity<FundoInvestimentoBanco>()
                .HasKey(f => new { f.BancoId, f.FundoInvestimentoId });

            //Configurar o relacionamento com o Banco
            modelBuilder.Entity<FundoInvestimentoBanco>()
                .HasOne(f => f.Banco)
                .WithMany(f => f.FundoInvestimentoBancos)
                .HasForeignKey(f => f.BancoId);

            //Configurar o relacionamento com o FundoInvestimento
            modelBuilder.Entity<FundoInvestimentoBanco>()
                .HasOne(f => f.FundoInvestimento)
                .WithMany(f => f.FundoInvestimentoBancos)
                .HasForeignKey(f => f.FundoInvestimentoId);

            base.OnModelCreating(modelBuilder);
        }

        public CartaoContext(DbContextOptions options): base(options)
        {

        }
    }
}
