using AutoMapper;
using BookFiend.Application.Features.Author.Commands.UpdateAuthor;
using BookFiend.Application.Features.Author.Queries.GetAllAuthors;
using BookFiend.Application.Features.Author.Queries.GetAuthorById;
using BookFiend.Application.Features.Book.Commands.CreateAuthor;
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
   public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorListDto>()
           .ReverseMap();

            CreateMap<Author, AuthorDto>()
            //.ForMember(dest => dest.AuthorFirstname, opt => opt.MapFrom(src => src.Author.Firstname))
            //.ForMember(dest => dest.AuthorLastname, opt => opt.MapFrom(src => src.Author.Lastname))
            .ReverseMap();

            CreateMap<CreateAuthorCommand, Author>();
            CreateMap<UpdateAuthorCommand, Author>();
        }
    }
}
