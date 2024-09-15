using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutosController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET: api/produtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            var produtos = await _produtoService.GetAllProdutosAsync();
            return Ok(produtos);

        }

        // GET: api/produtos/{IdProduto}
        [HttpGet("{IdProduto}")]
        public async Task<ActionResult<Produto>> GetProduto(int IdProduto)
        {
            var produto = await _produtoService.GetProdutoByIdAsync(IdProduto);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        // POST: api/produtos
        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            var createdProduto = await _produtoService.CreateProdutoAsync(produto);
            return CreatedAtAction(nameof(GetProduto), new { IdProduto = createdProduto.IdProduto }, createdProduto);
        }

        // PUT: api/produtos/{IdProduto}
        [HttpPut("{IdProduto}")]
        public async Task<IActionResult> PutProduto(int IdProduto, Produto produto)
        {
            if (IdProduto != produto.IdProduto)
            {
                return BadRequest();
            }
            await _produtoService.UpdateProdutoAsync(produto);
            return NoContent();
        }

        // DELETE: api/produtos/{IdProduto}
        [HttpDelete("{IdProduto}")]
        public async Task<IActionResult> DeleteProduto(int IdProduto)
        {
            var exists = await _produtoService.DeleteProdutoAsync(IdProduto);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}

