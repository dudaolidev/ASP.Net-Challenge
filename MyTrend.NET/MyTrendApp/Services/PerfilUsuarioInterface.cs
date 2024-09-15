using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de perfis de usuário.
    /// </summary>
    public interface IPerfilUsuarioService
    {
        /// <summary>
        /// Obtém todos os perfis de usuário.
        /// </summary>
        /// <returns>Lista de perfis de usuário.</returns>
        Task<IEnumerable<PerfilUsuario>> GetAllPerfisAsync();

        /// <summary>
        /// Obtém um perfil de usuário pelo seu idPerfilUsuario.
        /// </summary>
        /// <param name="idPerfilUsuario">idPerfilUsuario do perfil de usuário.</param>
        /// <returns>Perfil de usuário correspondente ao idPerfilUsuario.</returns>
        Task<PerfilUsuario> GetPerfilByIdAsync(int idPerfilUsuario);

        /// <summary>
        /// Cria um novo perfil de usuário.
        /// </summary>
        /// <param name="perfil">Objeto perfil de usuário a ser criado.</param>
        Task<PerfilUsuario> CreatePerfilAsync(PerfilUsuario perfil);

        /// <summary>
        /// Atualiza um perfil de usuário existente.
        /// </summary>
        /// <param name="perfil">Objeto perfil de usuário com dados atualizados.</param>
        Task UpdatePerfilAsync(PerfilUsuario perfil);

        /// <summary>
        /// Remove um perfil de usuário pelo seu idPerfilUsuario.
        /// </summary>
        /// <param name="idPerfilUsuario">idPerfilUsuario do perfil de usuário a ser removido.</param>
        Task<bool> DeletePerfilAsync(int idPerfilUsuario);
    }
}
