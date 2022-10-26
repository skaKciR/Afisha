
using Microsoft.AspNetCore.Mvc;

using Afisha.Domain;

namespace Afisha.Controllers
{
    public class EventController : Controller
    {
        private readonly DataManager dataManager;

        public EventController(DataManager dataManager)
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