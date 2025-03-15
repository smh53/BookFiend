using BookFiend.Application.Features.Author.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Book.Commands.CreateAuthor
{
    public class CreateAuthorCommand : BaseAuthor, IRequest<string>
    {
   
    }
}
