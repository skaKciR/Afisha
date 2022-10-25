

using System.ComponentModel.DataAnnotations;
using Afisha.Domain.Entities;

namespace Afisha.Domain.Repositories.Abstract
{
    public interface IEventRepository
    {
        IQueryable<Event> GetEventItems();
        Event GetEventItemById(Guid id);
        Event GetEventItemByDate(DateTime date);
        void SaveEventItem(Event entity);
        void DeleteEventItem(Guid id);

    }
}
