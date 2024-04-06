using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class OrderController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}
