using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de categorias de produtos.
    /// </summary>
    public interface ICategoriaProdutoService
    {
        /// <summary>
        /// Obtém todas as categorias de produtos.
        /// </summary>
        /// <returns>Lista de categorias de produtos.</returns>
        Task<IEnumerable<CategoriaProduto>> GetAllCategoriasAsync();

        /// <summary>
        /// Obtém uma categoria de produto pelo seu idProduto.
        /// </summary>
        /// <param name="idProduto">idProduto da categoria de produto.</param>
        /// <returns>Categoria de produto correspondente ao idProduto.</returns>
        Task<CategoriaProduto> GetCategoriaByIdAsync(int idProduto);

        /// <summary>
        /// Cria uma nova categoria de produto.
        /// </summary>
        /// <param name="categoria">Objeto categoria de produto a ser criado.</param>
        Task<CategoriaProduto> CreateCategoriaAsync(CategoriaProduto categoria);

        /// <summary>
        /// Atualiza uma categoria de produto existente.
        /// </summary>
        /// <param name="categoria">Objeto categoria de produto com dados atualizados.</param>
        Task UpdateCategoriaAsync(CategoriaProduto categoria);

        /// <summary>
        /// Remove uma categoria de produto pelo seu idProduto.
        /// </summary>
        /// <param name="idProduto">idProduto da categoria de produto a ser removida.</param>
        Task<bool> DeleteCategoriaAsync(int idProduto);
    }
}
