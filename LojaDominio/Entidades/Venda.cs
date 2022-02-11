using System;
using System.Collections.Generic;

namespace LojaDominio.Entidades
{
    public partial class Venda
    {
        public Venda()
        {
            Itens = new HashSet<Iten>();
        }

        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string? UsuarioId { get; set; }
        public virtual ICollection<Iten> Itens { get; set; }
    }
}
