using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Author.Commands.DeleteAuthor
{
   public class DeleteAuthorCommand : IRequest<Unit>
    {
        public string Id { get; set; }
    }
}
