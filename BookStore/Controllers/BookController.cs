using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
using BookStore.Extensions;
using BookStore.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var model = new AllBooksQueryModel();
            int clientId = (int)await clientService.GetClientIdAsync(User.Id());
            IEnumerable<Book> clientBooks = await clientService.GetClientAddedBooksAsync(clientId);
            model.Books = clientBooks.Select(b => new BookCardViewModel()
            {
                Author = b.AuthorName,
                Id = b.Id,
                ImageUrl = b.ImageUrl,
                InStock = b.InStock,
                Price = b.Price,
                Rating = b.Rating,
                Title = b.Title,
            }).ToList();
            model.TotalBooksCount = model.Books.Count();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new BookFormModel();
            model.Genres = await bookService.AllGenresAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(BookFormModel model)
        {
            if(!await bookService.GenreExistsAsync(model.GenreId))
            {
                ModelState.AddModelError(nameof(model.GenreId), "Genre does not exist");
            }
            if (!ModelState.IsValid)
            {
                model.Genres = await bookService.AllGenresAsync();
                return View(model);
            }
            Client client;
            int clientId = await clientService.GetClientIdAsync(User.Id()) ?? throw new NullReferenceException("Client does not exist");
            await bookService.CreateAsync(model);
            client = await clientService.GetClientByIdAsync(clientId) ?? throw new NullReferenceException("Client does not exist");
            client.MyBooks.Add(new Book()
            {
                AuthorName = model.AuthorName,
                Description = model.Description,
                GenreId = model.GenreId,
                ImageUrl = model.ImageUrl,
                InStock = true,
                Price = model.Price,
                Rating = model.Rating,
                Title = model.Title,
            });
            return RedirectToAction(nameof(Index));
        }
    }
}
