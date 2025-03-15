using BookFiend.Application.Features.Book.Queries.GetAllBooks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Author.Queries.GetAllAuthors
{
  public  class GetAllAuthorsQuery : IRequest<List<AuthorListDto>>
    {
    }
}
