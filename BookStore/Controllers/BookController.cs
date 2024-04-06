using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
using BookStore.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : BaseController
    {
        private readonly IBookService bookService;
        private readonly IClientService clientService;
        public BookController(IBookService _bookService, IClientService _clientService)
        {
            bookService = _bookService;
            clientService = _clientService;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index([FromQuery]AllBooksQueryModel query)
        {

            var model = await bookService.AllAsync(
                query.GenreName,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.BooksPerPage
                );
            query.TotalBooksCount = model.TotalBooksCount;
            query.Books = model.Books;
            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> Favourites()
        {
            var model = await clientService.AllFavouriteBooksAsync(User.Id());
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if (!await bookService.BookExistsByIdAsync(id))
            {
                return BadRequest();
            }
            var model = await bookService.BookDetailsByIdAsync(id);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> MyBooks()
        {
            return View();
        }
    }
}
