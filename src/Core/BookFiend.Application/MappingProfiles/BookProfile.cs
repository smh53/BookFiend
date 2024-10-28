using AutoMapper;
using BookFiend.Application.Features.Book.Queries.GetAllBooks;
using BookFiend.Application.Features.Book.Queries.GetBookById;
using BookFiend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.MappingProfiles
{
    internal class BookProfile : Profile
    {
        public BookProfile() 
        {
            CreateMap<Book, BookListDto>()
            .ForMember(dest => dest.AuthorFirstname, opt => opt.MapFrom(src => src.Author.Firstname))
            .ForMember(dest => dest.AuthorLastname, opt => opt.MapFrom(src => src.Author.Lastname))
            .ReverseMap();

            CreateMap<Book, BookDto>()
            .ForMember(dest => dest.AuthorFirstname, opt => opt.MapFrom(src => src.Author.Firstname))
            .ForMember(dest => dest.AuthorLastname, opt => opt.MapFrom(src => src.Author.Lastname))
            .ReverseMap();
        }

    }
}
