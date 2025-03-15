using AutoMapper;
using MediatR;
using BookFiend.Application.Features.Author.Queries.GetAuthorById;
using BookFiend.Application.Contracts.Persistence;

namespace BookFiend.Application.Features.Author.Queries.GetAuthorById
{
   public class GetAuthorByIdHandler : IRequestHandler<GetAuthorByIdQuery, AuthorDto>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;

        public GetAuthorByIdHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<AuthorDto> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.GetByIdAsync(request.Id);
            var data = _mapper.Map<AuthorDto>(author);
            return data;
        }
    }
}
