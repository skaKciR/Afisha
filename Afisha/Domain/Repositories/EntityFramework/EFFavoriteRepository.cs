using Afisha.Domain.Entities;
using Afisha.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace Afisha.Domain.Repositories.EntityFramework
{
    public class EFFavoriteRepository : IFavoriteRepository
    {
        private readonly AppDbContext context;

        public EFFavoriteRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Favorite> GetEventItems()
        {
            return context.Favorites;
        }

        public IQueryable<Favorite> GetEventItemsByName(string userName)
        {
            return context.Favorites.Where(x => x.UserName == userName);
        }

        public void SaveFavoriteItem(Favorite entity)
        {
            context.Add(entity);

            context.SaveChanges();
        }

        public IQueryable<Event> GetFavoriteByName(string name)
        {
            if (context == null) return null;

            return from c in context.Favorites.Where(x => x.UserName == name)
                   join e in context.Events on c.EventId equals e.Id
                   select context.Events.FirstOrDefault(x => x.Id == e.Id);
        }

        public void DeleteFromFavoriteById(Guid eventId, string userName)
        {
            context.Favorites.Remove(context.Favorites.FirstOrDefault(x => (x.UserName == userName && x.EventId == eventId)));
            context.SaveChanges();
        }


        public void RemoveFavorite(IQueryable<Favorite> entity)
        {
            context.Favorites.RemoveRange(entity);
            context.SaveChanges();
        }
    }
}
