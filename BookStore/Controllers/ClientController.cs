using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class ClientController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
