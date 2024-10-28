using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Queries.GetAllBooks
{
    public class BookListDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string AuthorFirstname { get; set; }
        public string AuthorLastname { get; set; }
    }
}
