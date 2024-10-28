using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Commands.DeleteBook
{
    public class DeleteBookCommand : IRequest<Unit>
    {
        public string Id { get; set; }
    }
}
