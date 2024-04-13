using BookStore.Core.Models.Review;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class ReviewController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Mine()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ReviewFormModel review)
        {
            return View();
        }
    }
}
