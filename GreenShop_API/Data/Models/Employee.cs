namespace GreenShop_API.Data.Models
{
    using System.Collections.Generic;
    public class Employee
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public Member Member { get; set; }

        public PositionType Position { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
