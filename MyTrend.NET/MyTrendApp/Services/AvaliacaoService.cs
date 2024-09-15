using Microsoft.EntityFrameworkCore;
using MyTrendApp.Data;
using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly ApplicationDbContext _context;

        public AvaliacaoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Avaliacao>> GetAllAvaliacoesAsync()
        {
            return await _context.Avaliacoes.ToListAsync();
        }

        public async Task<Avaliacao> GetAvaliacaoByIdAsync(int idAvaliacao)
        {
            return await _context.Avaliacoes.FindAsync(idAvaliacao);
        }

        public async Task<Avaliacao> CreateAvaliacaoAsync(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Add(avaliacao);
            await _context.SaveChangesAsync();
            return avaliacao;
        }

        public async Task UpdateAvaliacaoAsync(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Update(avaliacao);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAvaliacaoAsync(int idAvaliacao)
        {
            var avaliacao = await _context.Avaliacoes.FindAsync(idAvaliacao);
            if (avaliacao == null)
            {
                return false;
            }

            _context.Avaliacoes.Remove(avaliacao);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
