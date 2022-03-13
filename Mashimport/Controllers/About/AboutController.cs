using Microsoft.AspNetCore.Mvc;

namespace Mashimport.Controllers.Home
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
