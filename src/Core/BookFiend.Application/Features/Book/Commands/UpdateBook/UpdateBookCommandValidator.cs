using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.Features.Book.Commands.CreateBook;
using BookFiend.Application.Features.Book.Shared;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Commands.UpdateBook
{
    public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
    {
        private readonly IBookRepository _bookRepository;
        public UpdateBookCommandValidator(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            Include(new BaseBookValidator(_bookRepository));

        }

      
    }
}
