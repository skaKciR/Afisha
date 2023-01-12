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
        public void SaveTicketItem(IEnumerable<Cart> entity, string host)
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
                tickets.Add(new Ticket(item, ++number, name, GetQRByNumberTicket(number, host)));
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
        public byte[] GetQRByNumberTicket(int number, string host)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(host + "/Ticket / TicketInfo ? number =" + number.ToString());
            //ImageConverter converter = new ImageConverter();
            //return (byte[])converter.ConvertTo(qrcode, typeof(byte[]));
            MemoryStream stream = new MemoryStream();
            qrcode.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            var bytes = stream.GetBuffer();
            stream.Dispose();
            stream.Close();
            return bytes;
        }
        //Ticket/TicketInfo? number = 1
    }
}
