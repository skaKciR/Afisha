using Afisha.Domain.Entities;
using Afisha.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Afisha.Service;
using Microsoft.AspNetCore.Identity;
using Afisha.Models;
using Microsoft.AspNetCore.Authorization;

namespace Afisha.Controllers
{
    public class TicketController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public TicketController(DataManager dataManager, IWebHostEnvironment hostEnvironment, UserManager<IdentityUser> userMananger)
        {
            this.userManager = userMananger;
            this.dataManager = dataManager;
            this.hostingEnvironment = hostEnvironment;
        }

       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Buy(Guid EventID, string session, string hall, string selectedSeats,string userName)
        {
            dataManager.Tickets.SaveTicketItem(EventID,session,hall,selectedSeats,userName);
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
