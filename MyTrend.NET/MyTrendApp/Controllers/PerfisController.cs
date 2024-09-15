using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfisController : ControllerBase
    {
        private readonly PerfilUsuarioService _perfilUsuarioService;

        public PerfisController(PerfilUsuarioService perfilUsuarioService)
        {
            _perfilUsuarioService = perfilUsuarioService;
        }

        // GET: api/perfis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilUsuario>>> GetPerfis()
        {
            var perfis = await _perfilUsuarioService.GetAllPerfisAsync();
            return Ok(perfis);
        }

        // GET: api/perfis/{IdPerfilUsuario}
        [HttpGet("{IdPerfilUsuario}")]
        public async Task<ActionResult<PerfilUsuario>> GetPerfil(int IdPerfilUsuario)
        {
            var perfil = await _perfilUsuarioService.GetPerfilByIdAsync(IdPerfilUsuario);
            if (perfil == null)
            {
                return NotFound();
            }
            return Ok(perfil);
        }

        // POST: api/perfis
        [HttpPost]
        public async Task<ActionResult<PerfilUsuario>> PostPerfil(PerfilUsuario perfil)
        {
            var createdPerfil = await _perfilUsuarioService.CreatePerfilAsync(perfil);
            return CreatedAtAction(nameof(GetPerfil), new { IdPerfilUsuario = createdPerfil.IdPerfilUsuario }, createdPerfil);
        }

        // PUT: api/perfis/{IdPerfilUsuario}
        [HttpPut("{IdPerfilUsuario}")]
        public async Task<IActionResult> PutPerfil(int IdPerfilUsuario, PerfilUsuario perfil)
        {
            if (IdPerfilUsuario != perfil.IdPerfilUsuario)
            {
                return BadRequest();
            }
            await _perfilUsuarioService.UpdatePerfilAsync(perfil);
            return NoContent();
        }

        // DELETE: api/perfis/{IdPerfilUsuario}
        [HttpDelete("{IdPerfilUsuario}")]
        public async Task<IActionResult> DeletePerfil(int IdPerfilUsuario)
        {
            var exists = await _perfilUsuarioService.DeletePerfilAsync(IdPerfilUsuario);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
