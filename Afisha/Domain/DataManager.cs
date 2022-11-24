using System.Diagnostics.Tracing;
using Afisha.Domain.Repositories.Abstract;

namespace Afisha.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IEventRepository Events { get; set; }
        public ICartRepository Carts { get; set; }
        public ITicketRepository Tickets { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IEventRepository eventRepository, ICartRepository carts, ITicketRepository tickets)
        {
            TextFields = textFieldsRepository;
            Events = eventRepository;
            Carts = carts;
            Tickets = tickets;  
        }
    }
}
