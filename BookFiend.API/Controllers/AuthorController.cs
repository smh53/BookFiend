using MediatR;
using Microsoft.AspNetCore.Mvc;
using BookFiend.Application.Features.Author.Queries.GetAllAuthors;
using BookFiend.Application.Features.Author.Queries.GetAuthorById;
using BookFiend.Application.Features.Book.Commands.CreateAuthor;
using BookFiend.Application.Features.Author.Commands.UpdateAuthor;
using BookFiend.Application.Features.Author.Commands.DeleteAuthor;


namespace BookFiend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<AuthorController>
        [HttpGet]
        public async Task<List<AuthorListDto>> Get()
        {
            var authors = await _mediator.Send(new GetAllAuthorsQuery());
            return authors;
        }

        // GET api/<AuthorController>/5
        [HttpGet("{id}")]
        public async Task<AuthorDto> Get(string id)
        {
            var author = await _mediator.Send(new GetAuthorByIdQuery { Id = id });
            return author;
        }

        // POST api/<AuthorController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Post(CreateAuthorCommand author)
        {
            var response = await _mediator.Send(author);
            return CreatedAtAction(nameof(Get), new { id = response }, response);
        }

        // PUT api/<AuthorController>/5
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateAuthorCommand author)
        {
            await _mediator.Send(author);
            return NoContent();
        }

        // DELETE api/<AuthorController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(string id)
        {
            var command = new DeleteAuthorCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
