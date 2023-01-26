using Afisha.Domain;
using Afisha.Domain.Entities;
using Afisha.Models;
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
            HomeIndexViewModel hivm = new HomeIndexViewModel
            {
                Slider = dataManager.Events.GetElements(5, null),
                Concerts = dataManager.Events.GetElements(3, "Концерт"),
                Cinemas = dataManager.Events.GetElements(3, "Кино"),
                StandUps = dataManager.Events.GetElements(3, "StandUP Шоу"),
                Plays = dataManager.Events.GetElements(3, "Спектакль")
            };
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageConcerts");
            return View(hivm);
        }
        
    }
}
