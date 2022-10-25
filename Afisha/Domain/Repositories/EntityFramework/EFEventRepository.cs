﻿using Afisha.Domain;
using Afisha.Domain.Entities;
using Afisha.Domain.Repositories.Abstract;
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
    }
}
