using Microsoft.AspNetCore.Mvc;
using TestSamble.Data;
using TestSamble.Models;
using TestSamble.Services;

namespace TestSamble.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class ItemsController : Controller
    {   
        private readonly IBookInterface bookService;

        public ItemsController(IBookInterface bookService)
        { 
          this.bookService = bookService;
        }

        /// <summary>
        /// add book api
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult AddBook([FromBody] Book book)
        {
            var result = bookService.addBook(book);
            return Ok("added");
        }



        /// <summary>
        /// get all books
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpGet("")]
        public IActionResult GetBooks()
        {
            var books = bookService.getBooks();
            return Ok(books);
        }




        /// <summary>
        /// update book details
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPut("{bookId}")]
        public IActionResult UpdateBook([FromBody] UpdateBook updateBook, int bookId)
        {
            bookService.updateBook(bookId,updateBook);
            return Ok("books updated");
        }



        /// <summary>
        /// book deleted
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpDelete("{bookId}")]
        public IActionResult DeleteBook(int bookId)
        {
            bookService.deleteBook(bookId);
            return Ok("book deleted");
        }

    }
}
