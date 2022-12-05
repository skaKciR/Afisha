using Afisha.Domain;
using Afisha.Domain.Entities;
using Afisha.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;

namespace Afisha.Domain.Repositories.EntityFramework
{
    public class EFEventRepository : IEventRepository
    {
        private readonly AppDbContext context;

        public EFEventRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Event> GetEventItems()
        {
            return context.Events;
        }

    
        public Event GetEventItemById(Guid id)
        {
            return context.Events.FirstOrDefault(x => x.Id == id);
        }
        public Event GetEventItemByDate(DateTime date)
        {
            return context.Events.FirstOrDefault(x => x.Date == date);
        }
        public IQueryable<Event> GetEventsByString(string searchString)
        {
            if (context == null) return null;
            return context.Events.Where(x => x.Title.Contains(searchString));
        }

        public void SaveEventItem(Event entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteEventItem(Guid id)
        {
            context.Events.Remove(new Event() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<Event> GetElements(int count, string type)
        {
            if (type == null) return context.Events.OrderByDescending(x => x.Date).Take(count);
            else return context.Events.Where(x=> x.Type == type).OrderByDescending(x => x.Date).Take(count);

        }
    }
}
