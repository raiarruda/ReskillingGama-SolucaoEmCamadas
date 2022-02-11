using LojaData.Contexto;
using LojaDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaData.Repositories
{
    public abstract class Repository<Tipo> : IRepository<Tipo> where Tipo : class
    {
        protected readonly curso2022Context _context;
        public Repository(curso2022Context context)
        {
            _context = context;
        }
        public void Atualiza(Tipo entidade)
        {
            _context.Update(entidade);
        }

        public void CriarNovo(Tipo entidade)
        {
            _context.Add(entidade);
        }

        public void Deleta(Tipo entidade)
        {
            _context.Remove(entidade);
        }

        public abstract bool Exists(int id);

        public abstract Tipo ObterPorId(int id);

        public abstract List<Tipo> ObterTodos();

        public bool Salvar()
        {
            return _context.SaveChanges() > 0;

        }
    }
}
