using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de pedidos.
    /// </summary>
    public interface IPedidoService
    {
        /// <summary>
        /// Obtém todos os pedidos.
        /// </summary>
        /// <returns>Lista de pedidos.</returns>
        Task<IEnumerable<Pedido>> GetAllPedidosAsync();

        /// <summary>
        /// Obtém um pedido pelo seu idPedido.
        /// </summary>
        /// <param name="idPedido">idPedido do pedido.</param>
        /// <returns>Pedido correspondente ao idPedido.</returns>
        Task<Pedido> GetPedidoByIdAsync(int idPedido);

        /// <summary>
        /// Cria um novo pedido.
        /// </summary>
        /// <param name="pedido">Objeto pedido a ser criado.</param>
        Task<Pedido> CreatePedidoAsync(Pedido pedido);

        /// <summary>
        /// Atualiza um pedido existente.
        /// </summary>
        /// <param name="pedido">Objeto pedido com dados atualizados.</param>
        Task UpdatePedidoAsync(Pedido pedido);

        /// <summary>
        /// Remove um pedido pelo seu idPedido.
        /// </summary>
        /// <param name="idPedido">idPedido do pedido a ser removido.</param>
        Task<bool> DeletePedidoAsync(int idPedido);
    }
}
