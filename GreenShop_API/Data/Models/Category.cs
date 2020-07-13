﻿namespace GreenShop_API.Data.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
