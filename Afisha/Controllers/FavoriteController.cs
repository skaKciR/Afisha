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
    public class FavoriteController : Controller
    {
        private readonly DataManager dataManager;

        public FavoriteController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult AddToFavorite(Guid eventId, string userName)
        {
            if (userName != null)
            {
                Event _event = dataManager.Events.GetEventItemById(eventId);
                if (_event != null)
                {
                    dataManager.Favorites.SaveFavoriteItem(new Favorite { UserName = userName, EventId = eventId });
                } 
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public IActionResult RemoveFromFavorite(Guid eventId, string userName)
        {
            dataManager.Favorites.DeleteFromFavoriteById(eventId, userName);
            return RedirectToRoute(new { controller = "Favorite", action = "ShowFavorite", name = userName });
        }

        public IActionResult ShowFavorite(string name)
        {
            return View(dataManager.Favorites.GetFavoriteByName(name));
        }
    }
}
