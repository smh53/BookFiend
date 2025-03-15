using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.Features.Book.Queries.GetBookByIdWithDetails;
using BookFiend.Domain.Entities;
using BookFiend.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Book> GetByIdWithDetails(string id)
        {
            var bookWithDetails = await _dbContext.Books.Include(f => f.Author).FirstOrDefaultAsync(f => f.Id == id);
            return bookWithDetails;
        }

        public async Task<bool> IsBookUnique(string authorId, string title, string iSBN)
        {
            var isExist = await _dbContext.Books.AnyAsync(f => f.ISBN == iSBN && f.Title == title && f.AuthorId == authorId);
            return !isExist;
        }
    }
}
