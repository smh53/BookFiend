
using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.Features.Author.Shared;
using BookFiend.Application.Features.Book.Commands.CreateAuthor;
using FluentValidation;

namespace BookFiend.Application.Features.Author.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        private readonly IAuthorRepository _authorRepository;
        public CreateAuthorCommandValidator(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
            Include(new BaseAuthorValidator(_authorRepository));


        }

    
    }
}
