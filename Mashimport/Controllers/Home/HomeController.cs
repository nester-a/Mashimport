using Microsoft.AspNetCore.Mvc;

namespace Mashimport.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello world");
        }
    }
}
