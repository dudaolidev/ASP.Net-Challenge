using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuariosController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: api/usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            var usuarios = await _usuarioService.GetAllUsuariosAsync();
            return Ok(usuarios);
        }

        // GET: api/usuarios/{IdUsuario}
        [HttpGet("{IdUsuario}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int IdUsuario)
        {
            var usuario = await _usuarioService.GetUsuarioByIdAsync(IdUsuario);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        // POST: api/usuarios
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            var createdUsuario = await _usuarioService.CreateUsuarioAsync(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { IdUsuario = createdUsuario.IdUsuario }, createdUsuario);
        }

        // PUT: api/usuarios/{IdUsuario}
        [HttpPut("{IdUsuario}")]
        public async Task<IActionResult> PutUsuario(int IdUsuario, Usuario usuario)
        {
            if (IdUsuario != usuario.IdUsuario)
            {
                return BadRequest();
            }
            await _usuarioService.UpdateUsuarioAsync(usuario);
            return NoContent();
        }

        // DELETE: api/usuarios/{IdUsuario}
        [HttpDelete("{IdUsuario}")]
        public async Task<IActionResult> DeleteUsuario(int IdUsuario)
        {
            var exists = await _usuarioService.DeleteUsuarioAsync(IdUsuario);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
