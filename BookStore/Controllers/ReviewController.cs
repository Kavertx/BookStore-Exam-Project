using BookStore.Core.Contracts;
using BookStore.Core.Models.Review;
using BookStore.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class ReviewController : BaseController
    {
        private readonly IReviewService reviewService;
        private readonly IClientService clientService;
        private readonly IBookService bookService;
        public ReviewController(IReviewService _reviewService, IClientService _clientService, IBookService _bookService) 
        { 
            reviewService = _reviewService;
            clientService = _clientService;
            bookService = _bookService;
        }
        [AllowAnonymous]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index([FromQuery] AllReviewsQueryModel query)
        {
            var model = await reviewService.AllAsync(
                query.SearchTerm);
            query.TotalReviewsCount = model.TotalReviewsCount;
            query.Reviews = model.Reviews;
            return View(query);
        }
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Mine([FromQuery]AllReviewsQueryModel query)
        {
            int clientId = await clientService.GetClientIdAsync(User.Id())?? throw new NullReferenceException();
            var model = await reviewService.AllAsync(query.SearchTerm);
            query.Reviews = model.Reviews.Where(r => r.ClientId == clientId);
            query.TotalReviewsCount = model.TotalReviewsCount;
            return View(query);
        }
        [HttpGet]
        public async Task<IActionResult> Add(int id)
        {
            var book = await bookService.BookDetailsByIdAsync(id);
            var model = new ReviewFormModel()
            {
                AuthorName = book.Author,
                BookId = id,
                BookTitle = book.Title,
                ImageUrl = book.ImageUrl
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ReviewFormModel review)
        {
            if (!ModelState.IsValid)
            {
                return View(review);
            }
            var clientId = await clientService.GetClientIdAsync(User.Id())?? throw new NullReferenceException("Client with id doesn't exist");
            var client = await clientService.GetClientByIdAsync(clientId) ?? throw new NullReferenceException("Client with id doesn't exist");
            if (client.UserId!= User.Id())
            {
                return BadRequest("Review");
            }
            await reviewService.CreateAsync(review, clientId);
            return RedirectToAction(nameof(Mine));
        }
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {

            var model = await reviewService.GetReviewDetailsByIdAsync(id)?? throw new NullReferenceException("Review with id does not exist");
            
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
             await reviewService.DeleteAsync(id);
            return RedirectToAction(nameof(Mine));
        }
    }
}
