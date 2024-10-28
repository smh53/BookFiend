using AutoMapper;
using BookFiend.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Queries.GetAllBooks
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, List<BookListDto>>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;
        public GetAllBooksHandler(IMapper mapper, IBookRepository bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public IMapper Mapper { get; }
        public IBookRepository BookRepository { get; }

        public async Task<List<BookListDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllAsync();
            var data = _mapper.Map<List<BookListDto>>(books);
            return data;
        }
    }
}
