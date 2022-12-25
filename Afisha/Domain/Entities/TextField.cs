using System.ComponentModel.DataAnnotations;

namespace Afisha.Domain.Entities
{
    public class TextField
    {
        [Required]
        public string CodeWord { get; set; }

        public TextField() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название (заголовок)")]
        public string? Title { get; set; }

        [Display(Name = "Краткое описание")]
        public string? Subtitle { get; set; }

        [Display(Name = "Полное описание")]
        public string? Text { get; set; }

        [Display(Name = "SEO метатег Title")]
        public string? MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public string? MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public string? MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}