using LojaDominio.Entidades;
using System;
using System.Collections.Generic;

namespace
    LojaDominio.Entidades
{
    public partial class Categoria
    {
        public Categoria()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; } = null!;

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
