using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Queries.GetBookById
{
    public class BookDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Publisher { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string AuthorFirstname { get; set; }
        public string AuthorLastname { get; set; }
    }
}
