using Afisha.Domain.Entities;
using Afisha.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Afisha.Service;

namespace Afisha.Controllers
{
    public class TicketController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public TicketController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostEnvironment;
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
            dataManager.Tickets.SaveTicketItem(cart, "192.168.146.127");
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
