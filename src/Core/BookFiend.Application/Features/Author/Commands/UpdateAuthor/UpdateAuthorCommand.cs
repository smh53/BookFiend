using BookFiend.Application.Features.Author.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Author.Commands.UpdateAuthor
{
  public class UpdateAuthorCommand : BaseAuthor, IRequest<Unit>
    {
        public string Id { get; set; }
    }
}
