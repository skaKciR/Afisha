﻿using System.ComponentModel.DataAnnotations;
namespace Afisha.Domain.Entities
{
    public class Ticket
    {
		[Key]
		[Required]
		public Guid Id { get; set; }




		[Required]
        public string UserName { get; set; }

        [Required]
        public int Number { get; set; }

        public Ticket()
        {

        }

        public Ticket(Event _event, string session, string hall, string selectedSeats, string userName, byte[] QR, int number,Guid eventId)
        {
            Session= session;
            Hall = hall;
            SelectedSeats= selectedSeats;
            UserName = userName;
            Number = number;
            Address = _event.Address;
            Age = _event.Age;
            Title = _event.Title;
            Subtitle = _event.Subtitle;
            Text = _event.Text;
            TitleImagePath = _event.TitleImagePath;
            Date = _event.Date;
            PCard = _event.PCard;
            Type = _event.Type;
            Cost = _event.Cost;
            Image = _event.Image;
            this.QR = QR;
            EventId = eventId;
        }


        public Guid EventId { get; set; }
        [Required(ErrorMessage = "Заполните название мероприятия")]
        [Display(Name = "Название (заголовок)")]
        public string? Title { get; set; }

        [Display(Name = "Адрес")]
        public string? Address { get; set; }

        [Display(Name = "Краткое описание")]
        public string? Subtitle { get; set; }

        [Display(Name = "Полное описание")]
        public string? Text { get; set; }

        [Display(Name = "Титульная картинка")]
        public string? TitleImagePath { get; set; }

        public byte[]? Image { get; set; }

        public byte[]? QR { get; set; }

        [DataType(DataType.Time)]
        public DateTime Date { get; set; }

        [Display(Name = "Стоимость билета")]
        public string? Cost { get; set; }

        [Display(Name = "Тип мероприятия")]
        public string? Type { get; set; }

        [Display(Name = "Возрастное ограничение")]
        public int? Age { get; set; }

		[Display(Name = "Сеанс")]
		public string Session { get; set; }

		[Display(Name = "Зал")]
		public string Hall { get; set; }

		[Display(Name = "Выбранные места")]
		public string SelectedSeats { get; set; }

		[Display(Name = "Пушкинская карта")]
        public bool PCard { get; set; } = false;
    }
}
