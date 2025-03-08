using BookFiend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Persistence.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //builder.HasData(
            //    new Book
            //    {
            //        Id = "1",
            //        Title = "The Great Gatsby",
            //        CreatedDate = DateTime.Now,
            //        ISBN = "9780743273565",
            //        PublishedDate = new DateTime(1925, 4, 10),
            //        Publisher = "Scribner",
            //        PageCount = 180,
            //        Language = "English",
            //        Description = "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan.",
            //        AuthorId = "1"

            //    });

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
