using BookFiend.Application.Features.Book.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Commands.CreateBook
{
    public class CreateBookCommand : BaseBook, IRequest<string>
    {
    }
}
