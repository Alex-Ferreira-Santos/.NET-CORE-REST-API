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
    }
}