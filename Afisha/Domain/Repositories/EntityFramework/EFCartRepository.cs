using Afisha.Domain.Entities;
using Afisha.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace Afisha.Domain.Repositories.EntityFramework
{
    public class EFCartRepository : ICartRepository
    {
        private readonly AppDbContext context;

        public EFCartRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Cart> GetEventItems()
        {
            return context.Carts;
        }
    
        public void SaveCartItem(Cart entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            
            context.SaveChanges();
        }

        public IQueryable<Event> GetCartByName(string name)
        {
            if (context == null) return null;

            return from c in context.Carts.Where(x => x.UserName == name)
                       join e in context.Events on c.EventId equals e.Id
                       select context.Events.FirstOrDefault(x => x.Id == e.Id);

        }

        public void DeleteFromCartById(Guid eventId, string userName)
        {
            context.Carts.Remove(context.Carts.FirstOrDefault(x => (x.UserName == userName && x.EventId == eventId)));
            context.SaveChanges();
        }
    }
}
