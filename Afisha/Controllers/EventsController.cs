
using Microsoft.AspNetCore.Mvc;

using Afisha.Domain;

namespace Afisha.Controllers
{
    public class EventsController : Controller
    {
        private readonly DataManager dataManager;

        public EventsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Events.GetEventItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.Events.GetEventItems());
        }
    }
}