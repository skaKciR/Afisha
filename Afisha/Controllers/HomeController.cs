using Microsoft.AspNetCore.Mvc;

namespace Afisha.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
