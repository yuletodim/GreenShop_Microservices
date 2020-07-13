namespace GreenShop_API.Data.Models
{
    using System.Collections.Generic;


    public class Customer
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
