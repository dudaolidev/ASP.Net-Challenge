using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de cores.
    /// </summary>
    public interface ICorService
    {
        /// <summary>
        /// Obtém todas as cores.
        /// </summary>
        /// <returns>Lista de cores.</returns>
        Task<IEnumerable<Cor>> GetAllCoresAsync();

        /// <summary>
        /// Obtém uma cor pelo seu idCor.
        /// </summary>
        /// <param name="idCor">idCor da cor.</param>
        /// <returns>Cor correspondente ao idCor.</returns>
        Task<Cor> GetCorByIdAsync(int idCor);

        /// <summary>
        /// Cria uma nova cor.
        /// </summary>
        /// <param name="cor">Objeto cor a ser criado.</param>
        Task<Cor> CreateCorAsync(Cor cor);

        /// <summary>
        /// Atualiza uma cor existente.
        /// </summary>
        /// <param name="cor">Objeto cor com dados atualizados.</param>
        Task UpdateCorAsync(Cor cor);

        /// <summary>
        /// Remove uma cor pelo seu idCor.
        /// </summary>
        /// <param name="idCor">idCor da cor a ser removida.</param>
        Task<bool> DeleteCorAsync(int idCor);
    }
}
