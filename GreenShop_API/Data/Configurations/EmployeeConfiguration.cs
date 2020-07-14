namespace GreenShop_API.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using GreenShop_API.Data.Models;

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .Property(e => e.Position)
                .IsRequired();

            builder
                .HasOne(e => e.Member)
                .WithOne(m => m.Employee)
                .HasForeignKey<Employee>(e => e.MemberId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
