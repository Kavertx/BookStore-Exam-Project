using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
using BookStore.Core.Models.Review;
using BookStore.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    public class ReviewController : AdminBaseController
    {
        private readonly IReviewService reviewService;
        public ReviewController(IReviewService _reviewService)
        {
            reviewService = _reviewService;
        }


        public async Task<IActionResult> ReviewsForApproval([FromQuery] AllReviewsQueryModel query)
        {
            var model = await reviewService.AllAsync(
                query.SearchTerm,
                query.CurrentPage,
                query.ReviewsPerPage,
                false);
            query.TotalReviewsCount = model.TotalReviewsCount;
            query.Reviews = model.Reviews;
            return View(query);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {

            var model = await reviewService.GetReviewDetailsByIdAsync(id) ?? throw new NullReferenceException("Review with id does not exist");

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Approve([FromHeader] int reviewId)
        {
            try
            {
                var review = await reviewService.GetReviewByIdAsync(reviewId);
                if (review == null)
                {
                    return BadRequest();
                }
                await reviewService.ApproveReviewAsync(reviewId);
                return RedirectToAction(nameof(ReviewsForApproval));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        public async Task<IActionResult> Delete([FromHeader] int reviewId)
        {
            try
            {
                var review = await reviewService.GetReviewByIdAsync(reviewId);
                if (review == null)
                {
                    return BadRequest();
                }
                await reviewService.DeleteAsync(reviewId);
                return RedirectToAction(nameof(ReviewsForApproval));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
