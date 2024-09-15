using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de gerenciamento de usuários.
    /// </summary>
    public interface IUsuarioService
    {
        /// <summary>
        /// Obtém todos os usuários.
        /// </summary>
        /// <returns>Lista de usuários.</returns>
        Task<IEnumerable<Usuario>> GetAllUsuariosAsync();

        /// <summary>
        /// Obtém um usuário pelo seu idUsuario.
        /// </summary>
        /// <param name="idUsuario">idUsuario do usuário.</param>
        /// <returns>Usuário correspondente ao idUsuario.</returns>
        Task<Usuario> GetUsuarioByIdAsync(int idUsuario);

        /// <summary>
        /// Cria um novo usuário.
        /// </summary>
        /// <param name="usuario">Objeto usuário a ser criado.</param>
        Task<Usuario> CreateUsuarioAsync(Usuario usuario);

        /// <summary>
        /// Atualiza um usuário existente.
        /// </summary>
        /// <param name="usuario">Objeto usuário com dados atualizados.</param>
        Task UpdateUsuarioAsync(Usuario usuario);

        /// <summary>
        /// Remove um usuário pelo seu idUsuario.
        /// </summary>
        /// <param name="idUsuario">idUsuario do usuário a ser removido.</param>
        Task<bool> DeleteUsuarioAsync(int idUsuario);
    }
}
