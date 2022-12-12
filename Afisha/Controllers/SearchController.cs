using Afisha.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Afisha.Controllers
{
    public class SearchController : Controller
    {
        private readonly DataManager dataManager;

        public SearchController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        [HttpGet]
        public IActionResult Search(string searchString)
        {
            return View(dataManager.Events.GetEventsByString(searchString));
        }
    }
}
