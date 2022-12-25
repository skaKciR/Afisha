using Afisha.Domain.Entities;
using Afisha.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Afisha.Controllers
{
    public class TicketController : Controller
    {
        private readonly DataManager dataManager;

        public TicketController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Buy(string userName)
        {
            var cart = dataManager.Carts.GetEventItemsByName(userName);
            //foreach (var item in cart)
            // {
            dataManager.Tickets.SaveTicketItem(cart);
            // }

            dataManager.Carts.RemoveCart(cart);
            return RedirectToAction("Index", "Home");

        }

        public IActionResult ShowTickets(string name)
        {
            return View(dataManager.Tickets.GetTicketsByName(name));
        }

        public IActionResult TicketInfo(int number)
        {

            return View("TicketInfo", dataManager.Tickets.GetTicketItemByNumber(number));
        }
    }
}
