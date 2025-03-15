
using MediatR;

namespace BookFiend.Application.Features.Author.Queries.GetAuthorById
{
   public class GetAuthorByIdQuery : IRequest<AuthorDto>
    {
        public string Id { get; set; }
    }
}
