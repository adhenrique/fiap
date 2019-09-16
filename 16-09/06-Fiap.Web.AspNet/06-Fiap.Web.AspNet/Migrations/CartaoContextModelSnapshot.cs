﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _06_Fiap.Web.AspNet.Contexts;

namespace _06_Fiap.Web.AspNet.Migrations
{
    [DbContext(typeof(CartaoContext))]
    partial class CartaoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Cartao", b =>
                {
                    b.Property<int>("CartaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bandeira");

                    b.Property<DateTime>("DataValidade");

                    b.Property<bool>("Internacional");

                    b.Property<decimal>("Limite");

                    b.Property<string>("Nome");

                    b.HasKey("CartaoId");

                    b.ToTable("Cartoes");
                });
#pragma warning restore 612, 618
        }
    }
}
