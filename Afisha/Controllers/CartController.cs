using Afisha.Domain;
using Afisha.Domain.Entities;
using Afisha.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using System.Xml.Linq;

namespace Afisha.Controllers
{
    public class CartController : Controller
    {
        private readonly DataManager dataManager;

        public CartController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult AddToCart(Guid eventId, string userName)
        {
            if (userName != null)
            {
                Event _event = dataManager.Events.GetEventItemById(eventId);
                if (_event != null)
                {
                    dataManager.Carts.SaveCartItem(new Cart { Quantity = 1, UserName = userName, EventId = eventId });
                } 
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public IActionResult RemoveFromCart(Guid eventId, string userName)
        {
            dataManager.Carts.DeleteFromCartById(eventId, userName);
            //return RedirectToAction("ShowCart", "Cart", name = userName);
            return RedirectToRoute(new { controller = "Cart", action = "ShowCart", name = userName });
        }

        public IActionResult ShowCart(string name)
        {
            return View(dataManager.Carts.GetCartByName(name));
        }
    }
}
