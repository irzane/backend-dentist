﻿using DentisteApp.IRepositories;
using DentisteApp.Models.Entities;
using GestionBudget.Data;
using Microsoft.EntityFrameworkCore;


namespace DentisteApp.Repositories
{
    public class FeuilleDeSoinRepository : IFeuilleDeSoinRepository
    {
        private readonly AppDbContext _context;

        public FeuilleDeSoinRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FeuilleDeSoin>> GetAllAsync()
        {
            return await _context.FeuillesDeSoin.ToListAsync();
        }

        public async Task<FeuilleDeSoin> GetByIdAsync(int id)
        {
            return await _context.FeuillesDeSoin.FindAsync(id);
        }

        public async Task AddAsync(FeuilleDeSoin feuilleDeSoin)
        {
            await _context.FeuillesDeSoin.AddAsync(feuilleDeSoin);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(FeuilleDeSoin feuilleDeSoin)
        {
            _context.FeuillesDeSoin.Update(feuilleDeSoin);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var feuilleDeSoin = await GetByIdAsync(id);
            if (feuilleDeSoin != null)
            {
                _context.FeuillesDeSoin.Remove(feuilleDeSoin);
                await _context.SaveChangesAsync();
            }
        }
    }
}
