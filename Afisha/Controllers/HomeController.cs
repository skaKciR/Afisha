using Afisha.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Afisha.Controllers
{
    public class HomeController : Controller
    {
     
            private readonly DataManager dataManager;

            public HomeController(DataManager dataManager)
            {
                this.dataManager = dataManager;
            }

            public IActionResult Index(Guid id)
            {
                if (id != default)
                {
                    return View("Show", dataManager.Events.GetEventItemById(id));
                }

                ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageConcerts");
                return View(dataManager.Events.GetEventItems());
            }
        
    }
}
