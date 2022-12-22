using System.ComponentModel.DataAnnotations;

namespace Afisha.Domain.Entities
{
    public class TextField
    {
        public TextField() => DateAdded = DateTime.UtcNow;
        public DateTime DateAdded { get; set; }
        [Required]
        public string? CodeWord { get; set; }
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название (заголовок)")]
        public string? Title { get; set; } = "Информационная страница";

        [Display(Name = "Содержание страницы")]
        public string? Text { get; set; } = "Содержание заполняется админом";

        [Display(Name = "SEO метатег Title")]
        public string? MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public string? MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public string? MetaKeywords { get; set; }
    }
}