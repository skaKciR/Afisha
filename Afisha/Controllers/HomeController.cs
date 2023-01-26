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
      

            public IActionResult Index()
            {
            var list = new List<IQueryable<Event>>();
            list.Add(dataManager.Events.GetElements(5, null));
            list.Add(dataManager.Events.GetElements(3, "Концерт"));
            list.Add(dataManager.Events.GetElements(3, "Кино"));
            list.Add(dataManager.Events.GetElements(3, "StandUP Шоу"));
            list.Add(dataManager.Events.GetElements(3, "Спектакль"));
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageConcerts");
            return View(list);
        }
        
    }
}
