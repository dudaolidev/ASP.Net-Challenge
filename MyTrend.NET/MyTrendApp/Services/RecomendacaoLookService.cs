using Microsoft.EntityFrameworkCore;
using MyTrendApp.Data;
using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Serviço para gerenciar recomendações de looks.
    /// </summary>
    public class RecomendacaoLookService : IRecomendacaoLookService
    {
        private readonly ApplicationDbContext _context;

        public RecomendacaoLookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RecomendacaoLook>> GetAllRecomendacoesAsync()
        {
            return await _context.Recomendacoes.ToListAsync();
        }

        public async Task<RecomendacaoLook> GetRecomendacaoByIdAsync(int idRecomendacaoLook)
        {
            return await _context.Recomendacoes.FindAsync(idRecomendacaoLook);
        }

        public async Task<RecomendacaoLook> CreateRecomendacaoAsync(RecomendacaoLook recomendacao)
        {
            _context.Recomendacoes.Add(recomendacao);
            await _context.SaveChangesAsync();
            return recomendacao;
        }

        public async Task UpdateRecomendacaoAsync(RecomendacaoLook recomendacao)
        {
            _context.Recomendacoes.Update(recomendacao);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteRecomendacaoAsync(int idRecomendacaoLook)
        {
            var recomendacao = await _context.Recomendacoes.FindAsync(idRecomendacaoLook);
            if (recomendacao == null)
            {
                return false;
            }
            _context.Recomendacoes.Remove(recomendacao);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
