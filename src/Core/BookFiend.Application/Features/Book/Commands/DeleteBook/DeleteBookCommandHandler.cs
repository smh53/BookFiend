using AutoMapper;
using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.CustomExceptions;
using BookFiend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Commands.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, Unit>
    {
        private readonly IBookRepository _bookRepository;

        public DeleteBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
          
        }
        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetByIdAsync(request.Id) ?? throw new NotFoundException(nameof(Book), request.Id);
            await _bookRepository.DeleteAsync(book);

            return Unit.Value;
           
        }
    }
}
