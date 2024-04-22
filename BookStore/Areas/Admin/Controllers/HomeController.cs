using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult BooksForApproval()
        {
            return View();
        }
        public IActionResult ReviewsForApproval()
        {
            return View();
        }
    }
}
