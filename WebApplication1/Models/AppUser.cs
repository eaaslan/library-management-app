﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = false;  // Users need to be verified by library worker

        public virtual ICollection<Rental> RentedBooks { get; set; } = new List<Rental>();
    }
}
