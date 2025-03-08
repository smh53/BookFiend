using BookFiend.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
    }
}
