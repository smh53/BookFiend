using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.Features.Book.Shared;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Commands.CreateBook
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        private readonly IBookRepository _bookRepository;
        public CreateBookCommandValidator(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            Include(new BaseBookValidator(_bookRepository));


        }

       
    }
}
