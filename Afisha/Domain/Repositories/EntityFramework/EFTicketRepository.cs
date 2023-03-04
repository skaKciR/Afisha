using Afisha.Domain.Entities;
using Afisha.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec;
using System.Drawing;
using Microsoft.Extensions.Hosting.Internal;
using static System.Net.Mime.MediaTypeNames;

namespace Afisha.Domain.Repositories.EntityFramework
{
    public class EFTicketRepository : ITicketRepository
    {
        private readonly AppDbContext context;
        public EFTicketRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void SaveTicketItem(Guid EventID, string session, string hall, string selectedSeats, string userName)
        {

            Ticket ticket = new Ticket(session, hall, selectedSeats, userName, EventID);
            ticket.QR = GetQRByIdTicket(ticket.Id,"afishes.ru");
            context.Add(ticket);
            context.SaveChanges();
        }


        public IQueryable<Ticket> GetTicketsByName(string name)
        {
            return context.Tickets.Where(x => x.UserName == name);
        }

        public Ticket GetTicketItemById(Guid id)
        {
            return context.Tickets.FirstOrDefault(x => x.Id == id);
        }

        public byte[] GetQRByIdTicket(Guid id, string host)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(host + "/Ticket/TicketInfo?number=" + id.ToString());
            MemoryStream stream = new MemoryStream();
            qrcode.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            var bytes = stream.GetBuffer();
            stream.Dispose();
            stream.Close();
            return bytes;
        }

        public string GetSelectedSeatsById(Guid EventID)
        {
            return string.Join(',', context.Tickets.Where(x => x.EventId==EventID).Select(x => x.SelectedSeats).ToArray());
        }

    }
}
