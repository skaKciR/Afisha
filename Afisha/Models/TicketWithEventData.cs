using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Afisha.Models
{
    public class TicketWithEventData
    {
        [Key]
        [Required]
        public Guid TicketId { get; set; }

        public Guid EventId { get; set; }

        [Required]
        public string UserName { get; set; }

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
