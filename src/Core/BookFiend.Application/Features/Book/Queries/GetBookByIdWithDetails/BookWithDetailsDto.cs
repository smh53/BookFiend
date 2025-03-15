using BookFiend.Application.Features.Book.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Queries.GetBookByIdWithDetails
{
    public class BookWithDetailsDto : BaseBook
    {
        public string AuthorFirstname { get; set; }
        public string AuthorLastname { get; set; }
    }
}
