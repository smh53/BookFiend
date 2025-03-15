using BookFiend.Application.Features.Book.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Commands.UpdateBook
{
    public class UpdateBookCommand : BaseBook, IRequest<Unit>
    {
        public string Id { get; set; }
    }
}
