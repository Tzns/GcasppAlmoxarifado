using Almoxarifado.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<GEntrada> GEntrada { get; set; }
        public DbSet<GEntradaItem> GEntradaItem { get; set; }
        public DbSet<GEstoque> GEstoque { get; set; }  
        public DbSet<GFornecedor> GFornecedor { get; set; }
        public DbSet<GProduto> GProduto { get; set; }
        public DbSet<GProdutoUnidade> GProdutoUnidade { get; set; }
        public DbSet<GEntrada> GSaida { get; set; }
        public DbSet<GEntradaItem> GSaidaItem { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configuração do GEntrada
            modelBuilder.Entity<GEntrada>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<GEntrada>()
            .HasMany(t => t.GEntradaItem)
                .WithOne(t => t.GEntrada)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GEntrada>()
                .HasOne(t => t.GFornecedor)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict); 
         

            //configuração do GEntradaItem
            modelBuilder.Entity<GEntradaItem>()
            .HasKey(t => t.Id);
            modelBuilder.Entity<GEntradaItem>()
                .HasOne(t => t.GEntrada)
                .WithMany(t => t.GEntradaItem)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GEntradaItem>()
                .HasOne(t => t.GProduto)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GEntradaItem>()
                .Property(t => t.PrecoMedio).HasColumnType("real");
            modelBuilder.Entity<GEntradaItem>()
                 .Property(t => t.ValorTotal).HasColumnType("money");

            //configuração do GEstoque           
            modelBuilder.Entity<GEstoque>()
                .HasOne(t => t.GProduto).WithOne().HasForeignKey<GEstoque>(t => t.Id).OnDelete(DeleteBehavior.Restrict);
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
            modelBuilder.Entity<GProduto>().HasIndex(t => t.Codigo).IsUnique();
            modelBuilder.Entity<GProduto>().HasIndex(t => t.Descricao).IsUnique();


            //configuração do GProdutoUnidade
            modelBuilder.Entity<GProdutoUnidade>()
            .HasKey(t => t.Id);

            //configuração do GSaida
            modelBuilder.Entity<GSaida>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<GSaida>()
            .HasMany(t => t.GSaidaItem)
                .WithOne(t => t.GSaida);

            //configuração do GSaidaItem
            modelBuilder.Entity<GSaidaItem>()
            .HasKey(t => t.Id);
            modelBuilder.Entity<GSaidaItem>()
                .HasOne(t => t.GSaida)
                .WithMany(t => t.GSaidaItem)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GSaidaItem>()
                .HasOne(t => t.GProduto)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GSaidaItem>()
                .Property(t => t.PrecoMedio).HasColumnType("real");
            modelBuilder.Entity<GSaidaItem>()
                 .Property(t => t.ValorTotal).HasColumnType("money");


        }




    }
}
