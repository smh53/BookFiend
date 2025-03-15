using AutoMapper;
using MediatR;
using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.Features.Author.Commands.UpdateAuthor;
using BookFiend.Application.CustomExceptions;


namespace BookFiend.Application.Features.Author.Commands.UpdateAuthor
{
   public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;

        public UpdateAuthorCommandHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.GetByIdAsync(request.Id) ?? throw new NotFoundException(nameof(Author), request.Id);
            var validator = new UpdateAuthorCommandValidator(_authorRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any()) throw new BadRequestException("Girdiğiniz bilgiler hatalıdır", validationResult);

             _mapper.Map(request, author);
            await _authorRepository.UpdateAsync(author);
            return Unit.Value;
        }
    }
}
