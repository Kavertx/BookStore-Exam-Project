﻿using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
using BookStore.Extensions;
using BookStore.Infrastructure.Data.Models;
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
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index([FromQuery]AllBooksQueryModel query)
        {

            var model = await bookService.AllAsync(
                query.GenreName,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.BooksPerPage,
                true
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
            if (User.Id() == null)
            {
                return BadRequest();
            }

            var model = new AllBooksQueryModel();
            int clientId = (int)await clientService.GetClientIdAsync(User.Id());
            var client = await clientService.GetClientByIdAsync(clientId);
            // there is no way for these to even come up
            if(client.UserId != User.Id())
            {
                return Unauthorized();
            }
            IEnumerable<Book> allBooks = await bookService.AllBookBooksAsync();
            var clientBooks = allBooks.Where(b=> b.ClientId == clientId).ToList();
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
            client = await clientService.GetClientByIdAsync(clientId);
            int bookId = await bookService.CreateAsync(model, clientId);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromHeader]int bookId)
        {
            try
            {
                var clientId = await clientService.GetClientIdAsync(User.Id());
                var books = await bookService.AllBookBooksAsync();
                var book = books.FirstOrDefault(x => x.Id == bookId);
                if (book == null)
                {
                    return BadRequest();
                }
                if (book.ClientId == clientId)
                {
                    await bookService.DeleteAsync(bookId);
                }
                else
                {
                    return Unauthorized();
                }
                return Ok();
            }
            catch(Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
            
        }
    }
}
