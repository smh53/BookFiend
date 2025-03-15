using AutoMapper;
using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.CustomExceptions;
using BookFiend.Application.Features.Book.Commands.CreateAuthor;
using MediatR;


namespace BookFiend.Application.Features.Author.Commands.CreateAuthor
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, string>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;

        public CreateAuthorCommandHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<string> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateAuthorCommandValidator(_authorRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Girdiğiniz bilgiler hatalıdır", validationResult);
            }
           var newAuthor = _mapper.Map<BookFiend.Domain.Entities.Author>(request);
            await _authorRepository.CreateAsync(newAuthor);
            return newAuthor.Id;
        }
    }
}
