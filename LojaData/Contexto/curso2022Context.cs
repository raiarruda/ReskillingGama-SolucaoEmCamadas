using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LojaDominio.Entidades;


namespace LojaData.Contexto
{
    public partial class curso2022Context : DbContext
    {
        public curso2022Context()
        {
        }

        public curso2022Context(DbContextOptions<curso2022Context> options)
            : base(options)
        {
        }

    
        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Iten> Itens { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<Venda> Vendas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=curso2022;user id=root;port=3307", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.26-mysql"));
            }
        }

    }
}
