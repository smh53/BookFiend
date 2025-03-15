
using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.CustomExceptions;
using BookFiend.Application.Features.Author.Commands.DeleteAuthor;
using MediatR;

namespace BookFiend.Application.Features.Author.Commands.DeleteAuthor
{
   public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand, Unit>
    {
        private readonly IAuthorRepository _authorRepository;

        public DeleteAuthorCommandHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;

        }
        public async Task<Unit> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.GetByIdAsync(request.Id) ?? throw new NotFoundException(nameof(Author), request.Id);
            await _authorRepository.DeleteAsync(author);

            return Unit.Value;

        }
    }
}
