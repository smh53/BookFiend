using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.Features.Author.Commands.UpdateAuthor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Author.Shared
{
    public class BaseAuthorValidator : AbstractValidator<BaseAuthor>
    {
        private readonly IAuthorRepository _authorRepository;
        public BaseAuthorValidator(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;

            RuleFor(p => p.Firstname)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(150).WithMessage("{PropertyName} must be fewer than 150 characters");

            RuleFor(p => p.Lastname)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull()
               .MaximumLength(150).WithMessage("{PropertyName} must be fewer than 150 characters");
        }
    }
}
