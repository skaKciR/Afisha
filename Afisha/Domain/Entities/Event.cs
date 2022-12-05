using System.ComponentModel.DataAnnotations;

namespace Afisha.Domain.Entities
{
    public class Event : EntityBase
    {
        [Required(ErrorMessage = "Заполните название мероприятия")]
        [Display(Name = "Название (заголовок)")]
        public override string Title { get; set; }

        [DataType(DataType.Time)]
        public  DateTime Date { get; set; }

        [Display(Name = "Адрес")]
        public override string Address { get; set; }

        [Display(Name = "Стоимость билета")]
        public string? Cost { get; set; }

        [Display(Name = "Тип мероприятия")]
        public string? Type { get; set; }

        [Display(Name = "Возрастное ограничение")]
        public int? Age { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание услуги")]
        public override string Text { get; set; }

        [Display(Name = "Пушкинская карта")]
        public bool PCard { get; set; } = false;
        
    }
}