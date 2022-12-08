

using System.ComponentModel.DataAnnotations;
using Afisha.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Afisha.Domain.Repositories.Abstract
{
    public interface IEventRepository
    {
        IQueryable<Event> GetEventItems();
        Event GetEventItemById(Guid id);
        Event GetEventItemByDate(DateTime date);
        void SaveEventItem(Event entity);
        void DeleteEventItem(Guid id);
        IQueryable<Event> GetEventsByString(string searchString);
        IQueryable<Event> GetElements(int count, string type);
        List<Event> GetEventsByType(string type);
    }
}
