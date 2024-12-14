using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : BaseController
    {

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error(int statusCode)
        {
            switch (statusCode)
            {
                case 400:
                    return View("Error400");
                case 401:
                    return View("Error401");
                case 404:
                    return View("Error404");
                case 500:
                    return View("Error500");
            }
            return View();
        }
    }
}
