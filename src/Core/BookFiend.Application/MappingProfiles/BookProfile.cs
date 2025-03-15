using AutoMapper;
using BookFiend.Application.Features.Book.Commands.CreateBook;
using BookFiend.Application.Features.Book.Commands.UpdateBook;
using BookFiend.Application.Features.Book.Queries.GetAllBooks;
using BookFiend.Application.Features.Book.Queries.GetBookById;
using BookFiend.Application.Features.Book.Queries.GetBookByIdWithDetails;
using BookFiend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.MappingProfiles
{
    public class BookProfile : Profile
    {
        public BookProfile() 
        {
            CreateMap<Book, BookListDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, BookWithDetailsDto>()
            .ForMember(dest => dest.AuthorFirstname, opt => opt.MapFrom(src => src.Author.Firstname))
            .ForMember(dest => dest.AuthorLastname, opt => opt.MapFrom(src => src.Author.Lastname))
            .ReverseMap();
            CreateMap<CreateBookCommand, Book>();
            CreateMap<UpdateBookCommand, Book>();
        }

    }
}
