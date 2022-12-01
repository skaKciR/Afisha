using Afisha.Domain.Entities;
using System.Collections.Generic;

namespace Afisha.Domain.Repositories.Abstract
{
    public interface ITicketRepository
    {
        public IQueryable<Event> GetTicketsByName(string name);
        public void SaveTicketItem(IEnumerable<Cart> entity);
    }
}
