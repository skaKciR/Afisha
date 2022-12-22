using System.ComponentModel.DataAnnotations;
namespace Afisha.Domain.Entities
{
    public class Cart
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string? UserName { get; set; }

        [Required]
        public Guid EventId { get; set; }
    }
}
