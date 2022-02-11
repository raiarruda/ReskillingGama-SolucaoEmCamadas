using System;
using System.Collections.Generic;

namespace LojaDominio.Entidades
{
    public partial class Produtoviewmodel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public string UrlImagem { get; set; } = null!;
        public int? CategoriaId { get; set; }
        public string? CategoriaNome { get; set; }
    }
}
