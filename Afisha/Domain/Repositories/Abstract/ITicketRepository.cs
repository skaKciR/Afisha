using Afisha.Domain.Entities;
using System.Collections.Generic;

namespace Afisha.Domain.Repositories.Abstract
{
    public interface ITicketRepository
    {
        public IQueryable<Ticket> GetTicketsByName(string name);
        public void SaveTicketItem(IEnumerable<Cart> entity, string host);
        Ticket GetTicketItemByNumber(int number);
        public byte[] GetQRByNumberTicket(int number, string host);
    }
}
