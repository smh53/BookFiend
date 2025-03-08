using BookFiend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Persistence.DatabaseContext
{
    public class BookFiendDatabaseContext : DbContext
    {
        public BookFiendDatabaseContext(DbContextOptions<BookFiendDatabaseContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookFiendDatabaseContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
