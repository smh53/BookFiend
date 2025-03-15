using AutoMapper;
using MediatR;
using BookFiend.Application.Features.Author.Queries.GetAllAuthors;
using BookFiend.Application.Contracts.Persistence;

namespace BookFiend.Application.Features.Author.Queries.GetAllAuthors
{
  public class GetAllAuthorsHandler : IRequestHandler<GetAllAuthorsQuery, List<AuthorListDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;
        public GetAllAuthorsHandler(IMapper mapper, IAuthorRepository authorRepository)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
        }

        public IMapper Mapper { get; }
        public IAuthorRepository AuthorRepository { get; }

        public async Task<List<AuthorListDto>> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
        {
            var authors = await _authorRepository.GetAllAsync();
            var data = _mapper.Map<List<AuthorListDto>>(authors);
            return data;
        }
    }
}
