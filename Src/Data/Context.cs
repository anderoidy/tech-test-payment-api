using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Src.Models;

namespace Src.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaVendedores> VendaVendedores { get; set; }

        //Aeeeee aqui eu vou falar que o baguiu VendaVdendores nao precisa de uma Primary Key
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<VendaVendedores>(entity => 
            {
                entity.HasKey(e => new { e.IdVenda, e.IdVendedor });
            });
        }
    }
}