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
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookFiendDatabaseContext dbContext) : base(dbContext)
        {
        }
    }
    
}
