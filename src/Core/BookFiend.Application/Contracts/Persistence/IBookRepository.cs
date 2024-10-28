using BookFiend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Contracts.Persistence
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<bool> IsBookUnique(string authorId, string title, string iSBN);
    }
}
