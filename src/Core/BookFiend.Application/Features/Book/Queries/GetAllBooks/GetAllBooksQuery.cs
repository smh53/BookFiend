using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Queries.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<BookListDto>>
    {

    }
}
