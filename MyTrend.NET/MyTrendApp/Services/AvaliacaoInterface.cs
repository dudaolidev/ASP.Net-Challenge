using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de avaliação.
    /// </summary>
    public interface IAvaliacaoService
    {
        /// <summary>
        /// Obtém todas as avaliações.
        /// </summary>
        /// <returns>Lista de avaliações.</returns>
        Task<IEnumerable<Avaliacao>> GetAllAvaliacoesAsync();

        /// <summary>
        /// Obtém uma avaliação pelo seu idAvaliacao.
        /// </summary>
        /// <param name="idAvaliacao">idAvaliacao da avaliação.</param>
        /// <returns>Avaliação correspondente ao idAvaliacao.</returns>
        Task<Avaliacao> GetAvaliacaoByIdAsync(int idAvaliacao);

        /// <summary>
        /// Cria uma nova avaliação.
        /// </summary>
        /// <param name="avaliacao">Objeto avaliação a ser criado.</param>
        Task<Avaliacao> CreateAvaliacaoAsync(Avaliacao avaliacao);

        /// <summary>
        /// Atualiza uma avaliação existente.
        /// </summary>
        /// <param name="avaliacao">Objeto avaliação com dados atualizados.</param>
        Task UpdateAvaliacaoAsync(Avaliacao avaliacao);

        /// <summary>
        /// Remove uma avaliação pelo seu idAvaliacao.
        /// </summary>
        /// <param name="idAvaliacao">idAvaliacao da avaliação a ser removida.</param>
        Task<bool> DeleteAvaliacaoAsync(int idAvaliacao);
    }
}
