using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.Features.Book.Commands.CreateBook;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Shared
{
  public  class BaseBookValidator : AbstractValidator<BaseBook>
    {
        private readonly IBookRepository _bookRepository;
        public BaseBookValidator(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(150).WithMessage("{PropertyName} must be fewer than 150 characters");

            RuleFor(p => p.ISBN)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull()
               .MaximumLength(150).WithMessage("{PropertyName} must be fewer than 150 characters");

            RuleFor(q => q)
                .MustAsync(BookMustBeUnique)
                .WithMessage("This book already exists");

        }

        private async Task<bool> BookMustBeUnique(BaseBook command, CancellationToken token)
        {
            var result = await _bookRepository.IsBookUnique(command.AuthorId, command.Title, command.ISBN);
            return result;
        }
    }
}
