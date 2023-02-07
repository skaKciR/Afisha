using System.Diagnostics.Tracing;
using Afisha.Domain.Entities;
using Afisha.Domain.Repositories.Abstract;

namespace Afisha.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IEventRepository Events { get; set; }
        public ITicketRepository Tickets { get; set; }
        public IFavoriteRepository Favorites { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IEventRepository eventRepository, ITicketRepository tickets,IFavoriteRepository favorites)
        {
            TextFields = textFieldsRepository;
            Events = eventRepository;
            Tickets = tickets;
            Favorites = favorites;
        }
    }
}
