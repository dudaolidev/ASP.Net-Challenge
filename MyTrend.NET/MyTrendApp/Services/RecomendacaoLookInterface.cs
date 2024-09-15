using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de recomendações de looks.
    /// </summary>
    public interface IRecomendacaoLookService
    {
        /// <summary>
        /// Obtém todas as recomendações de looks.
        /// </summary>
        /// <returns>Lista de recomendações de looks.</returns>
        Task<IEnumerable<RecomendacaoLook>> GetAllRecomendacoesAsync();

        /// <summary>
        /// Obtém uma recomendação de look pelo seu idRecomendacaoLook.
        /// </summary>
        /// <param name="idRecomendacaoLook">idRecomendacaoLook da recomendação de look.</param>
        /// <returns>Recomendação de look correspondente ao idRecomendacaoLook.</returns>
        Task<RecomendacaoLook> GetRecomendacaoByIdAsync(int idRecomendacaoLook);

        /// <summary>
        /// Cria uma nova recomendação de look.
        /// </summary>
        /// <param name="recomendacao">Objeto recomendação de look a ser criado.</param>
        Task<RecomendacaoLook> CreateRecomendacaoAsync(RecomendacaoLook recomendacao);

        /// <summary>
        /// Atualiza uma recomendação de look existente.
        /// </summary>
        /// <param name="recomendacao">Objeto recomendação de look com dados atualizados.</param>
        Task UpdateRecomendacaoAsync(RecomendacaoLook recomendacao);

        /// <summary>
        /// Remove uma recomendação de look pelo seu idRecomendacaoLook.
        /// </summary>
        /// <param name="idRecomendacaoLook">idRecomendacaoLook da recomendação de look a ser removida.</param>
        Task<bool> DeleteRecomendacaoAsync(int idRecomendacaoLook);
    }
}
