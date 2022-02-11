using LojaData.Contexto;
using LojaDominio.Entidades;
using LojaDominio.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaData.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(curso2022Context context) : base(context)
        {
        }

        public override List<Produto> ObterTodos()
        {
            return _context.Produtos.ToList();
            //return _context.Produtos.Include(p => p.Categoria).ToList();
        }

        public override Produto ObterPorId(int id)
        {
            return _context.Produtos
                .Include(p => p.Categoria)
                .Where(produto => produto.Id == id)
                .First();
        }

        public override bool Exists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }

    }
}
