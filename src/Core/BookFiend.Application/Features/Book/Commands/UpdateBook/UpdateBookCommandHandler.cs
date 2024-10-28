using AutoMapper;
using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.CustomExceptions;
using BookFiend.Application.Features.Book.Commands.CreateBook;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Commands.UpdateBook
{
  
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;

        public UpdateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateBookCommandValidator(_bookRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Girdiğiniz bilgiler hatalıdır", validationResult);
            }

            var updateBook = _mapper.Map<BookFiend.Domain.Entities.Book>(request);
            await _bookRepository.UpdateAsync(updateBook);
            return Unit.Value;
        }
    }
}
