namespace GreenShop_API.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Member 
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
