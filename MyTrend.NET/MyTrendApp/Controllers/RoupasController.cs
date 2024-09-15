using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoupasController : ControllerBase
    {
        private readonly RoupaService _roupaService;

        public RoupasController(RoupaService roupaService)
        {
            _roupaService = roupaService;
        }

        // GET: api/roupas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Roupa>>> GetRoupas()
        {
            var roupas = await _roupaService.GetAllRoupasAsync();
            return Ok(roupas);
        }

        // GET: api/roupas/{IdRoupa}
        [HttpGet("{IdRoupa}")]
        public async Task<ActionResult<Roupa>> GetRoupa(int IdRoupa)
        {
            var roupa = await _roupaService.GetRoupaByIdAsync(IdRoupa);
            if (roupa == null)
            {
                return NotFound();
            }
            return Ok(roupa);
        }

        // POST: api/roupas
        [HttpPost]
        public async Task<ActionResult<Roupa>> PostRoupa(Roupa roupa)
        {
            var createdRoupa = await _roupaService.CreateRoupaAsync(roupa);
            return CreatedAtAction(nameof(GetRoupa), new { IdRoupa = createdRoupa.IdRoupa }, createdRoupa);
        }

        // PUT: api/roupas/{IdRoupa}
        [HttpPut("{IdRoupa}")]
        public async Task<IActionResult> PutRoupa(int IdRoupa, Roupa roupa)
        {
            if (IdRoupa != roupa.IdRoupa)
            {
                return BadRequest();
            }
            await _roupaService.UpdateRoupaAsync(roupa);
            return NoContent();
        }

        // DELETE: api/roupas/{IdRoupa}
        [HttpDelete("{IdRoupa}")]
        public async Task<IActionResult> DeleteRoupa(int IdRoupa)
        {
            var exists = await _roupaService.DeleteRoupaAsync(IdRoupa);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
