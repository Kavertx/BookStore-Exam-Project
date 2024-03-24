using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
