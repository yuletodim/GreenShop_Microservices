namespace GreenShop_API.Data.Models
{
    using GreenShop_API.Data.Models.Common;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser, IAuditInfo
    {
        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Member Member { get; set; }
    }
}
