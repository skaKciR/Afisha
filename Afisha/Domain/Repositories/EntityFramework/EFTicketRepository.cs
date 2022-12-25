using Afisha.Domain.Entities;
using Afisha.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Afisha.Domain.Repositories.EntityFramework
{
    public class EFTicketRepository : ITicketRepository
    {
        private readonly AppDbContext context;
        public EFTicketRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void SaveTicketItem(IEnumerable<Cart> entity)
        {
            string name = "";
            List<Event> events = new List<Event>();
            foreach (Cart cart in entity)
            {
                name = cart.UserName;
                events.Add(context.Events.FirstOrDefault(x => x.Id == cart.EventId));
            }      

            int number;
            if (context.Tickets.Count() == 0) number = 0;
            else number = context.Tickets.OrderByDescending(x => x.Number).First().Number;

            List<Ticket> tickets = new List<Ticket>();
            foreach (var item in events)
            {
                tickets.Add(new Ticket(item, ++number, name));
            }

            context.AddRange(tickets);
            context.SaveChanges();
        }
        public IQueryable<Ticket> GetTicketsByName(string name)
        {
            return context.Tickets.Where(x => x.UserName == name);
        }
        public Ticket GetTicketItemByNumber(int number)
        {
            return context.Tickets.FirstOrDefault(x => x.Number == number);
        }
    }
}
