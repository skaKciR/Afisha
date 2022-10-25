using System.ComponentModel.DataAnnotations;

namespace Afisha.Domain.Entities
{
    public class Event : EntitiyBase.EntityBase
    {
        [Required(ErrorMessage = "Заполните название мероприятия")]
        [Display(Name = "Название (заголовок)")]
        public override string Title { get; set; }

        [DataType(DataType.Time)]
        public  DateTime Date { get; set; }

        [Display(Name = "Адрес")]
        public override string Address { get; set; }


        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание услуги")]
        public override string Text { get; set; }

    }
}