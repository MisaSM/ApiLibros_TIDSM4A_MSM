using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P2_TIDSM4A_MSM_U3.Data.Models.Services;
using P2_TIDSM4A_MSM_U3.Data.ViewModels;

namespace P2_TIDSM4A_MSM_U3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;

        public BooksController(BooksService booksService) 
        {
            _booksService= booksService;
        }
        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allbooks = _booksService.GetAllBks();
            return Ok(allbooks);
        }

        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _booksService.GetBookById(id);
            return Ok(book);
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book) 
        {
           _booksService.AddBook(book);
            return Ok();
        }
    }
}
