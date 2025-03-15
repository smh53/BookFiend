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
            var book = await _bookRepository.GetByIdAsync(request.Id) ?? throw new NotFoundException(nameof(Author), request.Id);
            var validator = new UpdateBookCommandValidator(_bookRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any()) throw new BadRequestException("Girdiğiniz bilgiler hatalıdır", validationResult);

            _mapper.Map(request, book);
            await _bookRepository.UpdateAsync(book);
            return Unit.Value;
        }
    }
}
