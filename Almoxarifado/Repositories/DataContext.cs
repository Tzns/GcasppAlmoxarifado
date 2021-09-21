using Almoxarifado.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<GEntrada> Gentrada { get; set; }
        public DbSet<GEntradaItem> GentradaItem { get; set; }
        public DbSet<GEstoque> GEstoque { get; set; }
        public DbSet<GFornecedor> GFornecedor { get; set; }
        public DbSet<GProduto> GProduto { get; set; }
        public DbSet<GProdutoUnidade> GProdutoUnidade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configuração do GEntrada
            modelBuilder.Entity<GEntrada>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<GEntrada>()
            .HasMany(t => t.GEntradaItem)
                .WithOne(t => t.GEntrada);                    
            modelBuilder.Entity<GEntrada>()
                .HasOne(t => t.GFornecedor);

            //configuração do GEntradaItem
            modelBuilder.Entity<GEntradaItem>()
            .HasKey(t => t.Id);
            modelBuilder.Entity<GEntradaItem>()
                .HasOne(t => t.GEntrada);
            modelBuilder.Entity<GEntradaItem>()
                .HasOne(t => t.GProduto);
            modelBuilder.Entity<GEntradaItem>()
                .Property(t => t.PrecoMedio).HasColumnType("real");
            modelBuilder.Entity<GEntradaItem>()
                 .Property(t => t.ValorTotal).HasColumnType("money");

            //configuração do GEstoque           
            modelBuilder.Entity<GEstoque>()
                .HasOne(t => t.GProduto).WithOne().HasForeignKey<GEstoque>(t => t.Id);
            modelBuilder.Entity<GEstoque>()
                .Property(t => t.PrecoMedio).HasColumnType("real");
            modelBuilder.Entity<GEstoque>()
                .Property(t => t.ValorTotal).HasColumnType("money");
            










            //configuração do GFornecedor
            modelBuilder.Entity<GFornecedor>()
            .HasKey(t => t.Id);

            //configuração do GProduto
            modelBuilder.Entity<GProduto>()
            .HasKey(t => t.Id);
            modelBuilder.Entity<GProduto>()
            .HasOne(t => t.GPrudutoUnidade);

            //configuração do GProdutoUnidade
            modelBuilder.Entity<GProdutoUnidade>()
            .HasKey(t => t.Id);


        }




    }
}
