using AutoMapper;
using BookFiend.Application.Contracts.Persistence;
using BookFiend.Application.Features.Book.Queries.GetBookById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Queries.GetBookByIdWithDetails
{
   public class GetBookByIdWithDetailsHandler : IRequestHandler<GetBookByIdWithDetailsQuery, BookWithDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;

        public GetBookByIdWithDetailsHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookWithDetailsDto> Handle(GetBookByIdWithDetailsQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetByIdWithDetails(request.Id);
            var data = _mapper.Map<BookWithDetailsDto>(book);
            return data;
        }
    }
}
