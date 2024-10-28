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
using static BookFiend.Application.CustomExceptions.NotFoundException;

namespace BookFiend.Application.Features.Book.Commands.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, string>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;

        public CreateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<string> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateBookCommandValidator(_bookRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Girdiğiniz bilgiler hatalıdır", validationResult);
            }
           var newBook = _mapper.Map<BookFiend.Domain.Entities.Book>(request);
            await _bookRepository.CreateAsync(newBook);
            return newBook.Id;
        }
    }
}
