namespace GreenShop_API.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();

    }
}
