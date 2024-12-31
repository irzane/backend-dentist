using DentisteApp.IRepositories;
using DentisteApp.Models.Entities;
using GestionBudget.Data;
using Microsoft.EntityFrameworkCore;


namespace DentisteApp.Repositories
{
    public class ImagerieRepository : IImagerieRepository
    {
        private readonly AppDbContext _context;

        public ImagerieRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Imagerie>> GetAllAsync()
        {
            return await _context.Imageries.ToListAsync();
        }

        public async Task<Imagerie> GetByIdAsync(int id)
        {
            return await _context.Imageries.FindAsync(id);
        }

        public async Task AddAsync(Imagerie imagerie)
        {
            await _context.Imageries.AddAsync(imagerie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Imagerie imagerie)
        {
            _context.Imageries.Update(imagerie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var imagerie = await GetByIdAsync(id);
            if (imagerie != null)
            {
                _context.Imageries.Remove(imagerie);
                await _context.SaveChangesAsync();
            }
        }
    }
}
