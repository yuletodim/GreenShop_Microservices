namespace GreenShop_API.Data.Models
{
    using System.Collections.Generic;

    public class Provider
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Details { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
