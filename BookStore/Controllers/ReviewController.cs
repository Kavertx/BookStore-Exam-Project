using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class ReviewController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
