using System.ComponentModel.DataAnnotations;
namespace Afisha.Domain.Entities
{
    public class Favorite: EntityBase
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public Guid EventId { get; set; }

    }
}
