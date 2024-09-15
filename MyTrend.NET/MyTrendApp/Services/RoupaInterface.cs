using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de gerenciamento de roupas.
    /// </summary>
    public interface IRoupaService
    {
        /// <summary>
        /// Obtém todas as roupas.
        /// </summary>
        /// <returns>Lista de roupas.</returns>
        Task<IEnumerable<Roupa>> GetAllRoupasAsync();

        /// <summary>
        /// Obtém uma roupa pelo seu idRoupa.
        /// </summary>
        /// <param name="idRoupa">idRoupa da roupa.</param>
        /// <returns>Roupa correspondente ao idRoupa.</returns>
        Task<Roupa> GetRoupaByIdAsync(int idRoupa);

        /// <summary>
        /// Cria uma nova roupa.
        /// </summary>
        /// <param name="roupa">Objeto roupa a ser criado.</param>
        Task<Roupa> CreateRoupaAsync(Roupa roupa);

        /// <summary>
        /// Atualiza uma roupa existente.
        /// </summary>
        /// <param name="roupa">Objeto roupa com dados atualizados.</param>
        Task UpdateRoupaAsync(Roupa roupa);

        /// <summary>
        /// Remove uma roupa pelo seu idRoupa.
        /// </summary>
        /// <param name="idRoupa">idRoupa da roupa a ser removida.</param>
        Task<bool> DeleteRoupaAsync(int idRoupa);
    }
}
