using BookFiend.Application.Contracts.Persistence;
using BookFiend.Domain.Entities;
using BookFiend.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Persistence.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(BookFiendDatabaseContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsBookUnique(string authorId, string title, string iSBN)
        {
            throw new NotImplementedException();
        }
    }
}
