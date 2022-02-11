using System;
using System.Collections.Generic;

namespace LojaDominio.Entidades
{
    public partial class Produto
    {
        public Produto()
        {
            Itens = new HashSet<Iten>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public decimal Valor { get; set; }
        public DateTime DataCriacao { get; set; }
        public string UrlImagem { get; set; } = null!;
        public int? CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
        public virtual ICollection<Iten> Itens { get; set; }
    }
}
