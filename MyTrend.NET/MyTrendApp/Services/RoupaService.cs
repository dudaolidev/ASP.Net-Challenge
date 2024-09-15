using Microsoft.EntityFrameworkCore;
using MyTrendApp.Data;
using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Serviço para gerenciar roupas.
    /// </summary>
    public class RoupaService : IRoupaService
    {
        private readonly ApplicationDbContext _context;

        public RoupaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Roupa>> GetAllRoupasAsync()
        {
            return await _context.Roupas.ToListAsync();
        }

        public async Task<Roupa> GetRoupaByIdAsync(int idRoupa)
        {
            return await _context.Roupas.FindAsync(idRoupa);
        }

        public async Task<Roupa> CreateRoupaAsync(Roupa roupa)
        {
            _context.Roupas.Add(roupa);
            await _context.SaveChangesAsync();
            return roupa;
        }

        public async Task UpdateRoupaAsync(Roupa roupa)
        {
            _context.Roupas.Update(roupa);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteRoupaAsync(int idRoupa)
        {
            var roupa = await _context.Roupas.FindAsync(idRoupa);
            if (roupa == null)
            {
                return false;
            }
            _context.Roupas.Remove(roupa);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
