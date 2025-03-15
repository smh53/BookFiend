
using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.Features.Author.Commands.UpdateAuthor;
using BookFiend.Application.Features.Author.Shared;
using FluentValidation;

namespace BookFiend.Application.Features.Author.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
    {
        private readonly IAuthorRepository _authorRepository;
        public UpdateAuthorCommandValidator(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
            Include(new BaseAuthorValidator(_authorRepository));



        }

      
    }
}
