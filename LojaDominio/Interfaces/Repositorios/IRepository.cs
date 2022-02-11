using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDominio.Interfaces.Repositorios
{
    public interface IRepository<Tipo> where Tipo : class
    {
        List<Tipo> ObterTodos();
        Tipo ObterPorId(int id);
        void CriarNovo(Tipo entidade);
        void Atualiza(Tipo entidade);
        void Deleta(Tipo entidade);
        bool Salvar();
        bool Exists(int id);
    }

}
