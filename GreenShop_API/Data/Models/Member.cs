namespace GreenShop_API.Data.Models
{
    public class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Address { get; set; }
        
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
