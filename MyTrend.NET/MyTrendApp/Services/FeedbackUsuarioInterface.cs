using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de feedbacks de usuários.
    /// </summary>
    public interface IFeedbackUsuarioService
    {
        /// <summary>
        /// Obtém todos os feedbacks de usuários.
        /// </summary>
        /// <returns>Lista de feedbacks de usuários.</returns>
        Task<IEnumerable<FeedbackUsuario>> GetAllFeedbacksAsync();

        /// <summary>
        /// Obtém um feedback de usuário pelo seu idFeedbackUsuario.
        /// </summary>
        /// <param name="idFeedbackUsuario">idFeedbackUsuario do feedback de usuário.</param>
        /// <returns>Feedback de usuário correspondente ao idFeedbackUsuario.</returns>
        Task<FeedbackUsuario> GetFeedbackByIdAsync(int idFeedbackUsuario);

        /// <summary>
        /// Cria um novo feedback de usuário.
        /// </summary>
        /// <param name="feedback">Objeto feedback de usuário a ser criado.</param>
        Task<FeedbackUsuario> CreateFeedbackAsync(FeedbackUsuario feedback);

        /// <summary>
        /// Atualiza um feedback de usuário existente.
        /// </summary>
        /// <param name="feedback">Objeto feedback de usuário com dados atualizados.</param>
        Task UpdateFeedbackAsync(FeedbackUsuario feedback);

        /// <summary>
        /// Remove um feedback de usuário pelo seu idFeedbackUsuario.
        /// </summary>
        /// <param name="idFeedbackUsuario">idFeedbackUsuario do feedback de usuário a ser removido.</param>
        Task<bool> DeleteFeedbackAsync(int idFeedbackUsuario);
    }
}
