using BookFiend.Application.Features.Book.Commands.CreateBook;
using BookFiend.Application.Features.Book.Commands.DeleteBook;
using BookFiend.Application.Features.Book.Commands.UpdateBook;
using BookFiend.Application.Features.Book.Queries.GetAllBooks;
using BookFiend.Application.Features.Book.Queries.GetBookById;
using BookFiend.Application.Features.Book.Queries.GetBookByIdWithDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace BookFiend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<BookController>
        [HttpGet]
        public async Task<List<BookListDto>> Get()
        {
            var books = await _mediator.Send(new GetAllBooksQuery());
            return books;
        }


        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public async Task<BookDto> Get(string id)
        {
           var book = await _mediator.Send(new GetBookByIdQuery { Id = id });
            return book;
        }


        // GET api/<BookController>/5
        [HttpGet]
        [Route("WithDetails/{id}")]
        public async Task<BookWithDetailsDto> GetWithDetails(string id)
        {
            var book = await _mediator.Send(new GetBookByIdWithDetailsQuery { Id = id });
            return book;
        }

        // POST api/<BookController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Post(CreateBookCommand book)
        {
            var response = await _mediator.Send(book);
            return CreatedAtAction(nameof(Post), new { id = response }, response);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(string id, UpdateBookCommand book)
        {
            if (book.Id != id)
                book.Id = id;
            await _mediator.Send(book);
            return NoContent();
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(string id)
        {
            var command = new DeleteBookCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
