using Afisha.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Afisha.Domain.Repositories.Abstract
{
    public interface ITicketRepository
    {
        public IQueryable<Ticket> GetTicketsByName(string name);
        public void SaveTicketItem(Guid EventID, string session, string hall, string selectedSeats, string userName);
        Ticket GetTicketItemByNumber(int number);
        public byte[] GetQRByNumberTicket(int number, string host);
        public string GetSelectedSeatsById(Guid EventID);
    }
}
