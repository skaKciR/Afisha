using Afisha.Domain.Entities;
using Afisha.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Afisha.Domain.Repositories.EntityFramework
{
    public class EFTicketRepository:ITicketRepository
    {
        private readonly AppDbContext context;
        public EFTicketRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void SaveTicketItem(IEnumerable<Cart> entity)
        {
            List<Ticket> list = new List<Ticket>();
            foreach (var item in entity)
            {
                list.Add(new Ticket { EventId = item.EventId, UserName = item.UserName });
            }
            context.AddRange(list);
            context.SaveChanges();
        }
        public IQueryable<Event> GetTicketsByName(string name)
        {
            if (context == null) return null;

            return from c in context.Tickets.Where(x => x.UserName == name)
                   join e in context.Events on c.EventId equals e.Id
                   select context.Events.FirstOrDefault(x => x.Id == e.Id);
        }
    }
}
