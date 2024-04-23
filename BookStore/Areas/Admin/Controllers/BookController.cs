using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
using BookStore.Core.Services;
using BookStore.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    public class BookController : AdminBaseController
    {
        private readonly IBookService bookService;


        public BookController(IBookService _bookService)
        {
            bookService = _bookService;
        }
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> BooksForApproval([FromQuery] AllBooksQueryModel query)
        {
            var model = await bookService.AllAsync(
                query.GenreName,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.BooksPerPage,
                false
                );
            query.TotalBooksCount = model.TotalBooksCount;
            query.Books = model.Books;
            return View(query);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (!await bookService.BookExistsByIdAsync(id))
            {
                return BadRequest();
            }
            var model = await bookService.BookDetailsByIdAsync(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Approve([FromHeader] int bookId)
        {
            try
            {
                var books = await bookService.AllBookBooksAsync();
                var book = books.FirstOrDefault(x => x.Id == bookId);
                if (book == null)
                {
                    return BadRequest();
                }
                await bookService.ApproveBookAsync(bookId);
                return RedirectToAction(nameof(BooksForApproval));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromHeader] int bookId)
        {
            try
            {
                var books = await bookService.AllBookBooksAsync();
                var book = books.FirstOrDefault(x => x.Id == bookId);
                if (book == null)
                {
                    return BadRequest();
                }
                await bookService.DeleteAsync(bookId);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
