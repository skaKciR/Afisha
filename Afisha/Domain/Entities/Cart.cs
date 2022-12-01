using System.ComponentModel.DataAnnotations;
namespace Afisha.Domain.Entities
{
    public class Cart : EntityBase
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public Guid EventId { get; set; }

        public int Quantity { get; set; }
    }
}
