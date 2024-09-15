using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly PedidoService _pedidoService;

        public PedidosController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        // GET: api/pedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
        {
            var pedidos = await _pedidoService.GetAllPedidosAsync();
            return Ok(pedidos);
        }

        // GET: api/pedidos/{IdPedido}
        [HttpGet("{IdPedido}")]
        public async Task<ActionResult<Pedido>> GetPedido(int IdPedido)
        {
            var pedido = await _pedidoService.GetPedidoByIdAsync(IdPedido);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        // POST: api/pedidos
        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
        {
            var createdPedido = await _pedidoService.CreatePedidoAsync(pedido);
            return CreatedAtAction(nameof(GetPedido), new { IdPedido = createdPedido.IdPedido }, createdPedido);
        }

        // PUT: api/pedidos/{IdPedido}
        [HttpPut("{IdPedido}")]
        public async Task<IActionResult> PutPedido(int IdPedido, Pedido pedido)
        {
            if (IdPedido != pedido.IdPedido)
            {
                return BadRequest();
            }
            await _pedidoService.UpdatePedidoAsync(pedido);
            return NoContent();
        }

        // DELETE: api/pedidos/{IdPedido}
        [HttpDelete("{IdPedido}")]
        public async Task<IActionResult> DeletePedido(int IdPedido)
        {
            var exists = await _pedidoService.DeletePedidoAsync(IdPedido);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
