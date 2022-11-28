﻿using System.ComponentModel.DataAnnotations;
namespace Afisha.Domain.Entities
{
    public class Ticket:EntityBase
    {
        [Required]
        public Guid EventId { get; set; }
        [Required]
        public Guid UserId { get; set; }
    }
}