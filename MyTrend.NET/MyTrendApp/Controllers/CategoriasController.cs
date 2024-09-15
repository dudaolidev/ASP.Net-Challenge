using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly CategoriaProdutoService _categoriaProdutoService;

        public CategoriasController(CategoriaProdutoService categoriaProdutoService)
        {
            _categoriaProdutoService = categoriaProdutoService;
        }

        // GET: api/categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaProduto>>> GetCategorias()
        {
            var categorias = await _categoriaProdutoService.GetAllCategoriasAsync();
            return Ok(categorias);
        }

        // GET: api/categorias/{IdCategoriaProduto}
        [HttpGet("{IdCategoriaProduto}")]
        public async Task<ActionResult<CategoriaProduto>> GetCategoria(int IdCategoriaProduto)
        {
            var categoria = await _categoriaProdutoService.GetCategoriaByIdAsync(IdCategoriaProduto);
            if (categoria == null)
            {
                return NotFound();
            }
            return Ok(categoria);
        }

        // POST: api/categorias
        [HttpPost]
        public async Task<ActionResult<CategoriaProduto>> PostCategoria(CategoriaProduto categoria)
        {
            var createdCategoria = await _categoriaProdutoService.CreateCategoriaAsync(categoria);
            return CreatedAtAction(nameof(GetCategoria), new { IdCategoriaProduto = createdCategoria.IdCategoriaProduto }, createdCategoria);
        }

        // PUT: api/categorias/{IdCategoriaProduto}
        [HttpPut("{IdCategoriaProduto}")]
        public async Task<IActionResult> PutCategoria(int IdCategoriaProduto, CategoriaProduto categoria)
        {
            if (IdCategoriaProduto != categoria.IdCategoriaProduto)
            {
                return BadRequest();
            }
            await _categoriaProdutoService.UpdateCategoriaAsync(categoria);
            return NoContent();
        }

        // DELETE: api/categorias/{IdCategoriaProduto}
        [HttpDelete("{IdCategoriaProduto}")]
        public async Task<IActionResult> DeleteCategoria(int IdCategoriaProduto)
        {
            var exists = await _categoriaProdutoService.DeleteCategoriaAsync(IdCategoriaProduto);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}

