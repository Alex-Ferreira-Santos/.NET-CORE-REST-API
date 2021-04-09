using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TesteWS.models;

namespace TesteWS.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController: ControllerBase{
        [HttpGet]
        public IActionResult ObterTodos(){
            List<Produto> todos = BDMock.Produtos;
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult Obter(int id){
            Produto item = BDMock.Produtos.Find(p => p.Id == id);
            if(item == null){
                return NotFound();
            }
            return Ok(item);
        }
        [HttpPost]
        public IActionResult Gravar(Produto p){
            //definido um ID para o novo produto
            p.Id = BDMock.Produtos.Count + 1; 
            //incluindo em nosso banco "fake"
            BDMock.Produtos.Add(p);
            return CreatedAtAction("Obter", new {id = p.Id},p);
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Produto p){
            Produto item = BDMock.Produtos.Find(p => p.Id == id);
            if(item == null){
                return NotFound();
            }
            item.Descricao = p.Descricao;
            item.Preco = p.Preco;
            item.Novo = p.Novo;
            return NoContent();
        }
    }
}