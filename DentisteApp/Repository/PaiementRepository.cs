using DentisteApp.IRepositories;
using DentisteApp.Models.Entities;
using GestionBudget.Data;
using Microsoft.EntityFrameworkCore;


namespace DentisteApp.Repositories
{
    public class PaiementRepository : IPaiementRepository
    {
        private readonly AppDbContext _context;

        public PaiementRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Paiement>> GetAllAsync()
        {
            return await _context.Paiements.ToListAsync();
        }

        public async Task<Paiement> GetByIdAsync(int id)
        {
            return await _context.Paiements.FindAsync(id);
        }

        public async Task AddAsync(Paiement paiement)
        {
            await _context.Paiements.AddAsync(paiement);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Paiement paiement)
        {
            _context.Paiements.Update(paiement);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var paiement = await GetByIdAsync(id);
            if (paiement != null)
            {
                _context.Paiements.Remove(paiement);
                await _context.SaveChangesAsync();
            }
        }
    }
}
