using Microsoft.EntityFrameworkCore;
using MyTrendApp.Data;
using MyTrendApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Services
{
    /// <summary>
    /// Serviço para gerenciar perfis de usuário.
    /// </summary>
    public class PerfilUsuarioService : IPerfilUsuarioService
    {
        private readonly ApplicationDbContext _context;

        public PerfilUsuarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PerfilUsuario>> GetAllPerfisAsync()
        {
            return await _context.Perfis.ToListAsync();
        }

        public async Task<PerfilUsuario> GetPerfilByIdAsync(int idPerfilUsuario)
        {
            return await _context.Perfis.FindAsync(idPerfilUsuario);
        }

        public async Task<PerfilUsuario> CreatePerfilAsync(PerfilUsuario perfil)
        {
            _context.Perfis.Add(perfil);
            await _context.SaveChangesAsync();
            return perfil;
        }

        public async Task UpdatePerfilAsync(PerfilUsuario perfil)
        {
            _context.Perfis.Update(perfil);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeletePerfilAsync(int idPerfilUsuario)
        {
            var perfil = await _context.Perfis.FindAsync(idPerfilUsuario);
            if (perfil == null)
            {
                return false;
            }

            _context.Perfis.Remove(perfil);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
