using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoresController : ControllerBase
    {
        private readonly CorService _corService;

        public CoresController(CorService corService)
        {
            _corService = corService;
        }

        // GET: api/cores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cor>>> GetCores()
        {
            var cores = await _corService.GetAllCoresAsync();
            return Ok(cores);
        }

        // GET: api/cores/{IdCor}
        [HttpGet("{IdCor}")]
        public async Task<ActionResult<Cor>> GetCor(int IdCor)
        {
            var cor = await _corService.GetCorByIdAsync(IdCor);
            if (cor == null)
            {
                return NotFound();
            }
            return Ok(cor);
        }

        // POST: api/cores
        [HttpPost]
        public async Task<ActionResult<Cor>> PostCor(Cor cor)
        {
            var createdCor = await _corService.CreateCorAsync(cor);
            return CreatedAtAction(nameof(GetCor), new { IdCor = createdCor.IdCor }, createdCor);
        }

        // PUT: api/cores/{IdCor}
        [HttpPut("{IdCor}")]
        public async Task<IActionResult> PutCor(int IdCor, Cor cor)
        {
            if (IdCor != cor.IdCor)
            {
                return BadRequest();
            }
            await _corService.UpdateCorAsync(cor);
            return NoContent();
        }

        // DELETE: api/cores/{IdCor}
        [HttpDelete("{IdCor}")]
        public async Task<IActionResult> DeleteCor(int IdCor)
        {
            var exists = await _corService.DeleteCorAsync(IdCor);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
