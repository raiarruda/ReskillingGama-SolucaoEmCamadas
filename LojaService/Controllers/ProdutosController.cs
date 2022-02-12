using LojaDominio.Entidades;
using LojaDominio.Interfaces.Aplicacao;
using LojaDominio.Interfaces.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace LojaService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoAplicacao _produtoAplicacao;

        public ProdutosController(IProdutoAplicacao produtoAplicacao)
        {
            _produtoAplicacao = produtoAplicacao;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoAplicacao.ObterTodos());
            }
            catch (Exception)
            {
                return BadRequest("Erro ao busca produtos");

            }
        }

         [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try { 
            return Ok(_produtoAplicacao.ObterPorId(id));

        }
            catch (Exception)
            {
                return BadRequest("Erro ao busca produtos");

    }
}

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            _produtoRepository.CriarNovo(produto);
            _produtoRepository.Salvar();
            return Ok();

            
        }

       [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Produto produto)
        {
            if (_produtoRepository.Exists(id))
            {
                _produtoRepository.Atualiza(produto);
                _produtoRepository.Salvar();
                return Ok();
            }
            else
                return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_produtoRepository.Exists(id))
            {
                var produto = _produtoRepository.ObterPorId(id);
                _produtoRepository.Deleta(produto);
                _produtoRepository.Salvar();
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}
