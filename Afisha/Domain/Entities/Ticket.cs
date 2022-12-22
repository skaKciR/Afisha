using System.ComponentModel.DataAnnotations;
namespace Afisha.Domain.Entities
{
    public class Ticket
    {
        public Ticket()
        {

        }
        public Ticket(Event _event, int number, string userName) 
        {
            DateAdded = DateTime.UtcNow;
            Cost = _event.Cost;
            Title = _event.Title;
            Subtitle = _event.Subtitle;
            PCard = _event.PCard;
            Age = _event.Age;
            Address = _event.Address;
            Date = _event.Date;
            Type = _event.Type;
            TitleImagePath = _event.TitleImagePath;
            Text = _event.Text;
            Number = number;
            UserName = userName;
        }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public int Number { get; set; }

        //[DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }
        public string? Title { get; set; }

        [Required]
        public Guid Id { get; set; }

        [DataType(DataType.Time)]
        public DateTime Date { get; set; }

        [Display(Name = "Адрес")]
        public string? Address { get; set; }

        [Display(Name = "Титульная картинка")]
        public string? TitleImagePath { get; set; }

        [Display(Name = "Стоимость билета")]
        public string? Cost { get; set; }

        [Display(Name = "Тип мероприятия")]
        public string? Type { get; set; }

        [Display(Name = "Возрастное ограничение")]
        public int? Age { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public string? Subtitle { get; set; }

        [Display(Name = "Полное описание услуги")]
        public string? Text { get; set; }

        [Display(Name = "Пушкинская карта")]
        public bool PCard { get; set; } = false;
    }
}
