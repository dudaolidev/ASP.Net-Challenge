using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecomendacoesController : ControllerBase
    {
        private readonly RecomendacaoLookService _recomendacaoLookService;

        public RecomendacoesController(RecomendacaoLookService recomendacaoLookService)
        {
            _recomendacaoLookService = recomendacaoLookService;
        }

        // GET: api/recomendacoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecomendacaoLook>>> GetRecomendacoes()
        {
            var recomendacoes = await _recomendacaoLookService.GetAllRecomendacoesAsync();
            return Ok(recomendacoes);
        }

        // GET: api/recomendacoes/{IdRecomendacaoLook}
        [HttpGet("{IdRecomendacaoLook}")]
        public async Task<ActionResult<RecomendacaoLook>> GetRecomendacao(int IdRecomendacaoLook)
        {
            var recomendacao = await _recomendacaoLookService.GetRecomendacaoByIdAsync(IdRecomendacaoLook);
            if (recomendacao == null)
            {
                return NotFound();
            }
            return Ok(recomendacao);
        }

        // POST: api/recomendacoes
        [HttpPost]
        public async Task<ActionResult<RecomendacaoLook>> PostRecomendacao(RecomendacaoLook recomendacao)
        {
            var createdRecomendacao = await _recomendacaoLookService.CreateRecomendacaoAsync(recomendacao);
            return CreatedAtAction(nameof(GetRecomendacao), new { IdRecomendacaoLook = createdRecomendacao.IdRecomendacaoLook }, createdRecomendacao);
        }

        // PUT: api/recomendacoes/{IdRecomendacaoLook}
        [HttpPut("{IdRecomendacaoLook}")]
        public async Task<IActionResult> PutRecomendacao(int IdRecomendacaoLook, RecomendacaoLook recomendacao)
        {
            if (IdRecomendacaoLook != recomendacao.IdRecomendacaoLook)
            {
                return BadRequest();
            }
            await _recomendacaoLookService.UpdateRecomendacaoAsync(recomendacao);
            return NoContent();
        }

        // DELETE: api/recomendacoes/{IdRecomendacaoLook}
        [HttpDelete("{IdRecomendacaoLook}")]
        public async Task<IActionResult> DeleteRecomendacao(int IdRecomendacaoLook)
        {
            var exists = await _recomendacaoLookService.DeleteRecomendacaoAsync(IdRecomendacaoLook);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
