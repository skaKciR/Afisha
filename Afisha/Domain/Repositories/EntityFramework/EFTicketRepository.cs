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
           

            int number;
            if (context.Tickets.Count() == 0) number = 0;
            else number = context.Tickets.OrderByDescending(x => x.Number).First().Number;
            Ticket ticket = new Ticket(context.Events.FirstOrDefault(x => x.Id==EventID), session, hall, selectedSeats, userName, GetQRByNumberTicket(number, "afishes.ru"),number, EventID);

            context.Add(ticket);
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
        public byte[] GetQRByNumberTicket(int number, string host)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(host + "/Ticket/TicketInfo?number=" + number.ToString());
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
