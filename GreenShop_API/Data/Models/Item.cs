namespace GreenShop_API.Data.Models
{
    public class Item
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
