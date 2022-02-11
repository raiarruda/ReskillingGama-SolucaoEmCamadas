using LojaData.Contexto;
using LojaDominio.Entidades;
using LojaDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaData.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository

    {
        public CategoriaRepository(curso2022Context context) : base(context)
        {
        }

        public override bool Exists(int id)
        {
            return _context.Categorias.Any(c => c.Id == id);
        }

        public override Categoria ObterPorId(int id)
        {
            return _context.Categorias.Find(id);
        }

        public override List<Categoria> ObterTodos()
        {
            return _context.Categorias.ToList();
        }
    }
}
