using Afisha.Domain.Entities;
using Afisha.Models;
using System;
using System.Collections.Generic;

namespace Afisha.Domain.Repositories.Abstract
{
    public interface ITicketRepository
    {
        public IQueryable<Ticket> GetTicketsByName(string name);
        public void SaveTicketItem(Guid EventID, string session, string hall, string selectedSeats, string userName);
        Ticket GetTicketItemById(Guid Id);
        public byte[] GetQRByIdTicket(Guid Id, string host);
        public string GetSelectedSeatsById(Guid EventID);
        public TicketWithEventData GetTicketWithEventData(Guid id);
    }
}
