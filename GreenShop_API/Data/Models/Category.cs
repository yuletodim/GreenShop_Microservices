namespace GreenShop_API.Data.Models
{
    using GreenShop_API.Data.Models.Common;
    using System;
    using System.Collections.Generic;

    public class Category : IAuditInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public ICollection<Category> Categories { get; set; } = new List<Category>();
       
    }
}
