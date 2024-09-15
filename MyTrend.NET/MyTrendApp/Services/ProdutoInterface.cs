using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Interface para o serviço de produtos.
    /// </summary>
    public interface IProdutoService
    {
        /// <summary>
        /// Obtém todos os produtos.
        /// </summary>
        /// <returns>Lista de produtos.</returns>
        Task<IEnumerable<Produto>> GetAllProdutosAsync();

        /// <summary>
        /// Obtém um produto pelo seu idProduto.
        /// </summary>
        /// <param name="idProduto">idProduto do produto.</param>
        /// <returns>Produto correspondente ao idProduto.</returns>
        Task<Produto> GetProdutoByIdAsync(int idProduto);

        /// <summary>
        /// Cria um novo produto.
        /// </summary>
        /// <param name="produto">Objeto produto a ser criado.</param>
        Task<Produto> CreateProdutoAsync(Produto produto);

        /// <summary>
        /// Atualiza um produto existente.
        /// </summary>
        /// <param name="produto">Objeto produto com dados atualizados.</param>
        Task UpdateProdutoAsync(Produto produto);

        /// <summary>
        /// Remove um produto pelo seu idProduto.
        /// </summary>
        /// <param name="idProduto">idProduto do produto a ser removido.</param>
        Task<bool> DeleteProdutoAsync(int idProduto);
    }
}
