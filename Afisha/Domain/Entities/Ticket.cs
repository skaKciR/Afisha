using System.ComponentModel.DataAnnotations;
namespace Afisha.Domain.Entities
{
    public class Ticket
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public int Number { get; set; }

        public Ticket()
        {

        }

        public Ticket(Event _event, int number, string username)
        {
            DateAdded = DateTime.UtcNow;
            UserName = username;
            Number = number;
            Address = _event.Address;
            Age = _event.Age;
            Title = _event.Title;
            Subtitle = _event.Subtitle;
            Text = _event.Text;
            TitleImagePath = _event.TitleImagePath;
            MetaTitle = _event.MetaTitle;
            MetaDescription = _event.MetaDescription;
            MetaKeywords = _event.MetaKeywords;
            Date = _event.Date;
            PCard = _event.PCard;
            Type = _event.Type;
            Cost = _event.Cost;
        }

        [Required]
        public Guid Id { get; set; }

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

        [Display(Name = "SEO метатег Title")]
        public string? MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public string? MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public string? MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        [DataType(DataType.Time)]
        public DateTime Date { get; set; }

        [Display(Name = "Стоимость билета")]
        public string? Cost { get; set; }

        [Display(Name = "Тип мероприятия")]
        public string? Type { get; set; }

        [Display(Name = "Возрастное ограничение")]
        public int? Age { get; set; }

        [Display(Name = "Пушкинская карта")]
        public bool PCard { get; set; } = false;
    }
}
