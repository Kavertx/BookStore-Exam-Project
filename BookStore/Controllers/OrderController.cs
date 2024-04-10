using BookStore.Core.Contracts;
using BookStore.Core.Extensions;
using BookStore.Core.Models.Book;
using BookStore.Core.Models.Order;
using BookStore.Extensions;
using BookStore.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderService orderService;
        private readonly IBookService bookService;
        private readonly IClientService clientService;

        public OrderController(IOrderService _orderService, IBookService _bookService, IClientService _clientService)
        {
            orderService = _orderService;
            bookService = _bookService;
            clientService = _clientService;

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart([FromHeader]int bookId)
        {
            try
            {
                var book = await bookService.BookDetailsByIdAsync(bookId); 

                var cart = HttpContext.Session.Get<List<BookInOrderViewModel>>("Cart") ?? new List<BookInOrderViewModel>();
                BookInOrderViewModel bookToAdd = new BookInOrderViewModel
                {
                    Id = bookId,
                    Author = book.Author,
                    ImageUrl = book.ImageUrl,
                    Price = book.Price,
                    Title = book.Title,
                };

                cart.Add(bookToAdd);
                HttpContext.Session.Set("Cart", cart);

                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        public IActionResult RemoveFromCart([FromHeader]int bookId)
        {
            try
            {

                var cart = HttpContext.Session.Get<List<BookInOrderViewModel>>("Cart") ?? new List<BookInOrderViewModel>();
                var bookToRemove = cart.FirstOrDefault(x => x.Id == bookId);

 
                if (bookToRemove == null) throw new NullReferenceException("Book is not in the cart");
                cart.Remove(bookToRemove);


                HttpContext.Session.Set("Cart", cart);


                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Cart()
        {
            List<BookInOrderViewModel>? cart = HttpContext.Session.Get<List<BookInOrderViewModel>>("Cart");
            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder()
        {
            try
            {
                var cartModel = HttpContext.Session.Get<List<BookInOrderViewModel>>("Cart") ?? throw new NullReferenceException("Invalid request, cart is empty");
                decimal totalPrice = default;
                List<Book> books = new List<Book>();
                foreach (var book in cartModel)
                {
                    totalPrice += book.Price;
                    var currentBook = await bookService.BookDetailsByIdAsync(book.Id);
                    Book bookIn = new Book()
                    {
                        AuthorName = currentBook.Author,
                        Description = currentBook.Description,
                        GenreId = (int)await bookService.GetGenreIdByNameAsync(currentBook.GenreName),
                        Price = currentBook.Price,
                        Title = currentBook.Title,
                        Rating = currentBook.Rating,
                        ImageUrl = currentBook.ImageUrl,
                    };
                    books.Add(bookIn);
                }
                await orderService.CreateAsync(books, (int)await clientService.GetClientIdAsync(User.Id()), DateTime.Now, totalPrice);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }
    }
}
