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
            var hivm = new HomeIndexViewModel();
            hivm.Slider = dataManager.Events.GetElements(5, null);
            hivm.Concerts = dataManager.Events.GetElements(3, "Концерт");
            hivm.Cinemas = dataManager.Events.GetElements(3, "Кино");
            hivm.StandUPs = dataManager.Events.GetElements(3, "StandUP Шоу");
            hivm.Plays = dataManager.Events.GetElements(3, "Спектакль");
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageConcerts");
            return View(hivm);
        }
    }
}
