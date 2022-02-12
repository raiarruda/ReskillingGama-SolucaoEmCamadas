using LojaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDominio.Interfaces.Aplicacao
{
    public interface IProdutoAplicacao
    {


    
        public List<Produto> ObterTodos();

        public Produto ObterPorId(int id);

        public void CriarNovo(Produto produto);

        public void Atualiza(Produto produto);

        public void Deleta(int id);

    }


}
