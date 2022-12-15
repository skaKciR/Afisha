using Afisha.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Afisha.Domain.Repositories.Abstract
{
    public interface IFavoriteRepository
    {
        public IQueryable<Favorite> GetEventItems();

        public void SaveFavoriteItem(Favorite entity);

        public IQueryable<Event> GetFavoriteByName(string name);
        public void DeleteFromFavoriteById(Guid eventId, string userName);
        public IQueryable<Favorite> GetEventItemsByName(string userName);

        public void RemoveFavorite(IQueryable<Favorite> entity);
  

    }
}
