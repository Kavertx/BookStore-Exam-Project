using BookStore.Core.Contracts;
using BookStore.Core.Extensions;
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
        public async Task<IActionResult> Index()
        {
            var clientOrders = await orderService.AllClientOrdersAsync(User.Id());
            var model = clientOrders.Select(o => new OrderViewModel()
            {
                Id = o.Id,
                NumberOfBooks = o.NumberOfBooks,
                TimeOfOrder = o.TimeOfOrder,
                TotalPrice = o.TotalPrice,
                
            });

            return View(model);
        }
        [HttpGet]

        public async Task<IActionResult> Details(int id)
        {
            
            var order = await orderService.GetOrderByIdAsync(id);
            if(order == null)
            {
                return BadRequest();
            }
            var booksFromOrder = await orderService.GetBooksFromOrderIdAsync(id);
            var model = new OrderViewModel()
            {
                Id = order.Id,
                NumberOfBooks = order.NumberOfBooks,
                TimeOfOrder = order.TimeOfOrder,
                TotalPrice = order.TotalPrice,
                Books = booksFromOrder.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart([FromHeader]int bookId)
        {
            try
            {
                var book = await bookService.BookDetailsByIdAsync(bookId); 

                var cart = HttpContext.Session.Get<List<BookInOrderViewModel>>("Cart") ?? new List<BookInOrderViewModel>();
                BookInOrderViewModel bookToAdd = new BookInOrderViewModel()
                {
                    Id = bookId,
                    Author = book.Author,
                    ImageUrl = book.ImageUrl,
                    Price = book.Price,
                    Title = book.Title,
                };
                if (!cart.Contains(bookToAdd))
                {
                    cart.Add(bookToAdd);
                }
                HttpContext.Session.Set("Cart", cart);

                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> RemoveFromCart([FromHeader]int bookId)
        {
            try
            {
                var cart = HttpContext.Session.Get<List<BookInOrderViewModel>>("Cart") ?? new List<BookInOrderViewModel>();
                var bookToRemove = cart.FirstOrDefault(x => x.Id == bookId);
                if (bookToRemove == null) throw new NullReferenceException("Book is not in the cart");

                if (cart.Contains(bookToRemove))
                {
                    cart.Remove(bookToRemove);
                }

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
                //maybe this should be a separate method in the orderService
                decimal totalPrice = default;
                List<Book> books = new List<Book>();
                foreach (var book in cartModel)
                {
                    totalPrice += book.Price;
                    var currentBook = await bookService.BookDetailsByIdAsync(book.Id);
                    Book bookIn = new Book()
                    {
                        Id = book.Id,
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
                var clientId = (int)await clientService.GetClientIdAsync(User.Id());
                var client = await clientService.GetClientByIdAsync(clientId);
                await orderService.CreateAsync((int)await clientService.GetClientIdAsync(User.Id()), DateTime.Now, totalPrice, books.Count, books);
                var order = await orderService.GetLastClientOrderAsync(clientId);
                if (order != null)
                {
                    client?.Orders.Add(order);
                }
                HttpContext.Session.Remove("Cart");
                return RedirectToAction(nameof(Index), "Order");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }
    }
}
