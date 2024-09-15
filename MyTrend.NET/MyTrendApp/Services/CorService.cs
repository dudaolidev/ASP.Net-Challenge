using Microsoft.EntityFrameworkCore;
using MyTrendApp.Data;
using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Serviço para gerenciar cores.
    /// </summary>
    public class CorService : ICorService
    {
        private readonly ApplicationDbContext _context;

        public CorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cor>> GetAllCoresAsync()
        {
            return await _context.Cores.ToListAsync();
        }

        public async Task<Cor> GetCorByIdAsync(int idCor)
        {
            return await _context.Cores.FindAsync(idCor);
        }

        public async Task<Cor> CreateCorAsync(Cor cor)
        {
            _context.Cores.Add(cor);
            await _context.SaveChangesAsync();
            return cor;
        }

        public async Task UpdateCorAsync(Cor cor)
        {
            _context.Cores.Update(cor);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteCorAsync(int idCor)
        {
            var cor = await _context.Cores.FindAsync(idCor);
            if (cor == null)
            {
                return false;
            }

            _context.Cores.Remove(cor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
