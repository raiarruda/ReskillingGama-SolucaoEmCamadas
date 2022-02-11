using System;
using System.Collections.Generic;

namespace LojaDominio.Entidades
{
    public partial class Iten
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }

        public virtual Produto Produto { get; set; } = null!;
        public virtual Venda Venda { get; set; } = null!;
    }
}
