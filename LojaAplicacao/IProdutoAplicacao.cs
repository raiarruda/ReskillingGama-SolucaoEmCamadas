using LojaDominio.Entidades;
using LojaDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaAplicacao
{
    public class IProdutoAplicacao
    {
        private readonly IProdutoRepository _produtoRepository;
        public IProdutoAplicacao(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public List<Produto> ObterTodos()
        {
            return _produtoRepository.ObterTodos();
        }

        public Produto ObterPorId(int id)
        {
            return _produtoRepository.ObterPorId(id);

        }

        public void CriarNovo(Produto produto)
        {
            _produtoRepository.CriarNovo(produto);
            _produtoRepository.Salvar();

        }

        public void Atualiza(Produto produto)
        {
            if (_produtoRepository.Exists(produto.Id){
                _produtoRepository.Atualiza(produto);
                _produtoRepository.Salvar();

            }
        }

        public void Deleta(int id)
        {
            if (_produtoRepository.Exists(id))
            {
                var produto = _produtoRepository.ObterPorId(id);
                _produtoRepository.Deleta(produto);
                _produtoRepository.Salvar();
            }
        }

    }
}
