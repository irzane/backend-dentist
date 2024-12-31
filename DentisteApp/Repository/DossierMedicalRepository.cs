using DentisteApp.IRepositories;
using DentisteApp.Models.Entities;
using GestionBudget.Data;
using Microsoft.EntityFrameworkCore;


namespace DentisteApp.Repositories
{
    public class DossierMedicalRepository : IDossierMedicalRepository
    {
        private readonly AppDbContext _context;

        public DossierMedicalRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DossierMedical>> GetAllAsync()
        {
            return await _context.DossiersMedicaux.ToListAsync();
        }

        public async Task<DossierMedical> GetByIdAsync(int id)
        {
            return await _context.DossiersMedicaux.FindAsync(id);
        }

        public async Task AddAsync(DossierMedical dossier)
        {
            await _context.DossiersMedicaux.AddAsync(dossier);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(DossierMedical dossier)
        {
            _context.DossiersMedicaux.Update(dossier);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var dossier = await GetByIdAsync(id);
            if (dossier != null)
            {
                _context.DossiersMedicaux.Remove(dossier);
                await _context.SaveChangesAsync();
            }
        }
    }
}
