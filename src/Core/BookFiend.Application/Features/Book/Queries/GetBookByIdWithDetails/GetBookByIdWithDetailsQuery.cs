using BookFiend.Application.Features.Book.Queries.GetBookById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Queries.GetBookByIdWithDetails
{
   public class GetBookByIdWithDetailsQuery : IRequest<BookWithDetailsDto>
    {
        public string Id { get; set; }
    }
}
