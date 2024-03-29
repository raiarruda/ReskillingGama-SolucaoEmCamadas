﻿using LojaDominio.Entidades;
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
            try
            {
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
            try
            {
                _produtoAplicacao.CriarNovo(produto);
                return Created("Get", new {id=produto.Id});
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Produto produto)
        {
            try
            {
                _produtoAplicacao.Atualiza(produto);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _produtoAplicacao.Deleta(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
