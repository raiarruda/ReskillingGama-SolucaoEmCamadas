using LojaDominio.Entidades;
using LojaDominio.Interfaces.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace LojaService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        IProdutoRepository _produtoRepository;
        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
         [HttpGet]
        public IActionResult Get()
        {
            return Ok(_produtoRepository.ObterTodos());
        }

         [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_produtoRepository.ObterPorId(id));
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
