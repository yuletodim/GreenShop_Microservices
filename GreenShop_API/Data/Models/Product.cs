namespace GreenShop_API.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Reference { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int ProviderId { get; set; }

        public Provider Provider { get; set; }

        public int Stock { get; set; }
    }
}
