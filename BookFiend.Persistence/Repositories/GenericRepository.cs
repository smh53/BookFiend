using BookFiend.Application.Contracts.Persistence;
using BookFiend.Domain.BaseEntity;
using BookFiend.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly BookFiendDatabaseContext _dbContext;

        public GenericRepository(BookFiendDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(T entity)
        {
           await _dbContext.AddAsync(entity);
           await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
             _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
           return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
           return await _dbContext.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(f => f.Id == id);

        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Update(entity);
           await _dbContext.SaveChangesAsync();
        }
    }
}
