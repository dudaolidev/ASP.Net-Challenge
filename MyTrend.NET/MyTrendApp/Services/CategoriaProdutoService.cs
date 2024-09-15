using Microsoft.EntityFrameworkCore;
using MyTrendApp.Data;
using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Serviço para gerenciar categorias de produtos.
    /// </summary>
    public class CategoriaProdutoService : ICategoriaProdutoService
    {
        private readonly ApplicationDbContext _context;

        public CategoriaProdutoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoriaProduto>> GetAllCategoriasAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<CategoriaProduto> GetCategoriaByIdAsync(int idCategoriaProduto)
        {
            return await _context.Categorias.FindAsync(idCategoriaProduto);
        }

        public async Task<CategoriaProduto> CreateCategoriaAsync(CategoriaProduto categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task UpdateCategoriaAsync(CategoriaProduto categoria)
        {
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteCategoriaAsync(int idCategoriaProduto)
        {
            var categoria = await _context.Categorias.FindAsync(idCategoriaProduto);
            if (categoria == null)
            {
                return false;
            }

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
