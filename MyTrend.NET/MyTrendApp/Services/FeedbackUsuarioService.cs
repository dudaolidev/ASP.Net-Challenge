using Microsoft.EntityFrameworkCore;
using MyTrendApp.Data;
using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Serviço para gerenciar feedbacks de usuários.
    /// </summary>
    public class FeedbackUsuarioService : IFeedbackUsuarioService
    {
        private readonly ApplicationDbContext _context;

        public FeedbackUsuarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FeedbackUsuario>> GetAllFeedbacksAsync()
        {
            return await _context.Feedbacks.ToListAsync();
        }

        public async Task<FeedbackUsuario> GetFeedbackByIdAsync(int idFeedbackUsuario)
        {
            return await _context.Feedbacks.FindAsync(idFeedbackUsuario);
        }

        public async Task<FeedbackUsuario> CreateFeedbackAsync(FeedbackUsuario feedback)
        {
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return feedback;
        }

        public async Task UpdateFeedbackAsync(FeedbackUsuario feedback)
        {
            _context.Feedbacks.Update(feedback);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteFeedbackAsync(int idFeedbackUsuario)
        {
            var feedback = await _context.Feedbacks.FindAsync(idFeedbackUsuario);
            if (feedback == null)
            {
                return false;
            }

            _context.Feedbacks.Remove(feedback);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
