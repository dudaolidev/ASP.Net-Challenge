using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvaliacoesController : ControllerBase
    {
        private readonly AvaliacaoService _avaliacaoService;

        public AvaliacoesController(AvaliacaoService avaliacaoService)
        {
            _avaliacaoService = avaliacaoService;
        }

        // GET: api/avaliacoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Avaliacao>>> GetAvaliacoes()
        {
            var avaliacoes = await _avaliacaoService.GetAllAvaliacoesAsync();
            return Ok(avaliacoes);
        }

        // GET: api/avaliacoes/{IdAvaliacao}
        [HttpGet("{IdAvaliacao}")]
        public async Task<ActionResult<Avaliacao>> GetAvaliacao(int IdAvaliacao)
        {
            var avaliacao = await _avaliacaoService.GetAvaliacaoByIdAsync(IdAvaliacao);
            if (avaliacao == null)
            {
                return NotFound();
            }
            return Ok(avaliacao);
        }

        // POST: api/avaliacoes
        [HttpPost]
        public async Task<ActionResult<Avaliacao>> PostAvaliacao(Avaliacao avaliacao)
        {
            var createdAvaliacao = await _avaliacaoService.CreateAvaliacaoAsync(avaliacao);
            return CreatedAtAction(nameof(GetAvaliacao), new { IdAvaliacao = createdAvaliacao.IdAvaliacao }, createdAvaliacao);
        }

        // PUT: api/avaliacoes/{IdAvaliacao}
        [HttpPut("{IdAvaliacao}")]
        public async Task<IActionResult> PutAvaliacao(int IdAvaliacao, Avaliacao avaliacao)
        {
            if (IdAvaliacao != avaliacao.IdAvaliacao)
            {
                return BadRequest();
            }
            await _avaliacaoService.UpdateAvaliacaoAsync(avaliacao);
            return NoContent();
        }

        // DELETE: api/avaliacoes/{IdAvaliacao}
        [HttpDelete("{IdAvaliacao}")]
        public async Task<IActionResult> DeleteAvaliacao(int IdAvaliacao)
        {
            var exists = await _avaliacaoService.DeleteAvaliacaoAsync(IdAvaliacao);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
