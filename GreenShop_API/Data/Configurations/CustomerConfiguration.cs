namespace GreenShop_API.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using GreenShop_API.Data.Models;

    using static DataConstants;

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.City)
                .IsRequired()
                .HasMaxLength(CityMaxLength);

            builder
                .Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(AddressMaxLength);

            builder
               .HasOne(c => c.Member)
               .WithOne(m => m.Customer)
               .HasForeignKey<Customer>(c => c.MemberId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
