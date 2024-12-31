﻿using DentisteApp.IRepositories;
using DentisteApp.Models.Entities;
using GestionBudget.Data;
using Microsoft.EntityFrameworkCore;


namespace DentisteApp.Repositories
{
    public class CertificatMedicalRepository : ICertificatMedicalRepository
    {
        private readonly AppDbContext _context;

        public CertificatMedicalRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CertificatMedical>> GetAllAsync()
        {
            return await _context.CertificatsMedicaux.ToListAsync();
        }

        public async Task<CertificatMedical> GetByIdAsync(int id)
        {
            return await _context.CertificatsMedicaux.FindAsync(id);
        }

        public async Task AddAsync(CertificatMedical certificatMedical)
        {
            await _context.CertificatsMedicaux.AddAsync(certificatMedical);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CertificatMedical certificatMedical)
        {
            _context.CertificatsMedicaux.Update(certificatMedical);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var certificatMedical = await GetByIdAsync(id);
            if (certificatMedical != null)
            {
                _context.CertificatsMedicaux.Remove(certificatMedical);
                await _context.SaveChangesAsync();
            }
        }
    }
}
