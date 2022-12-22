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
            string name = "";
            List<Event> l = new();

            foreach (var item in entity)
            {
                name = item.UserName;
                var temp = context.Events.FirstOrDefault(x => x.Id == item.EventId);
                l.Add(temp);
            }

            int number;
            if (context.Tickets.Count() == 0)
            {
                number = 0;
            }
            else number = context.Tickets.OrderByDescending(x => x.Number).First().Number;

            List<Ticket> list = new List<Ticket>();
            foreach (var item in l)
            {
                list.Add(new Ticket(item, ++number, name));
            }
            context.AddRange(list);
            context.SaveChanges();
        }
        public IQueryable<Ticket> GetTicketsByName(string name)
        {
            if (context == null) return null;

            return context.Tickets.Where(x => x.UserName == name);

            //return from c in context.Tickets.Where(x => x.UserName == name)
            //       join e in context.Events on c.EventId equals e.Id
            //       select context.Events.FirstOrDefault(x => x.Id == e.Id);
        }
        public Ticket GetTicketItemByNumber(int number)
        {
            return context.Tickets.FirstOrDefault(x => x.Number == number);
        }
    }
}
