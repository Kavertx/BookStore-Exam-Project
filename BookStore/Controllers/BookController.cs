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
        public async Task<IActionResult> Index()
        { 
            var model = await bookService.AllAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Favourites()
        {
            var model = await clientService.AllFavouriteBooksAsync(User.Id());
            return View(model);
        }
    }
}
