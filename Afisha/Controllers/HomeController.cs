using Afisha.Domain;
using Afisha.Domain.Entities;
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
            var list = dataManager.Events.GetSliderElements(dataManager.Events.GetEventItems());
            if (id != default)
                {
                    return View("Show", dataManager.Events.GetEventItemById(id));
                
                }

                ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageConcerts");
            return View(dataManager.Events.GetEventItems()) ;
            }
        
    }
}
