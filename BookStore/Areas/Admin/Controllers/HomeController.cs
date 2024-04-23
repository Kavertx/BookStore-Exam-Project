using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
using BookStore.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        
        
        public IActionResult Dashboard()
        {
            return View();
        }
        

    }
}
