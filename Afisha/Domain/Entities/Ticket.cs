using System.ComponentModel.DataAnnotations;
namespace Afisha.Domain.Entities
{
    public class Ticket
    {
		[Key]
		[Required]
		public Guid Id { get; set; }

		[Required]
        public string UserName { get; set; }

        public Ticket()
        {

        }

        public Ticket(string session, string hall, string selectedSeats, string userName,Guid eventId)
        {
            Session= session;
            Hall = hall;
            SelectedSeats= selectedSeats;
            UserName = userName;
            EventId = eventId;
        }

        public Guid EventId { get; set; }

        [Required(ErrorMessage = "Заполните название мероприятия")]

        public byte[]? QR { get; set; }

		[Display(Name = "Сеанс")]
		public string Session { get; set; }

		[Display(Name = "Зал")]
		public string Hall { get; set; }

		[Display(Name = "Выбранные места")]
		public string SelectedSeats { get; set; }

    }
}
