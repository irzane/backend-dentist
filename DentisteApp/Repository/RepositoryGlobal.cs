﻿  using DentisteApp.IRepositories;
  using GestionBudget.Data;
  using Microsoft.EntityFrameworkCore;




namespace DentisteApp.Repository
{
  

        public class RepositoryGlobal<T> : IRepositoryGlobal<T> where T : class
        {
            protected readonly AppDbContext _context;

            public RepositoryGlobal(AppDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<T>> GetAllAsync()
            {
                return await _context.Set<T>().ToListAsync();
            }

            public async Task<T> GetByIdAsync(int id)
            {
                return await _context.Set<T>().FindAsync(id);
            }

            public async Task AddAsync(T entity)
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(T entity)
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var entity = await GetByIdAsync(id);
                if (entity != null)
                {
                    _context.Set<T>().Remove(entity);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }

