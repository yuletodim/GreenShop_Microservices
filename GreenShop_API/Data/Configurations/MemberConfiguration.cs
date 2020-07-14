namespace GreenShop_API.Data.Configurations
{
    using GreenShop_API.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static DataConstants;

    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(m => m.Id);

            builder
                .Property(m => m.FullName)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            builder
                .Property(m => m.PhoneNumber)
                .IsRequired()
                .HasMaxLength(PhoneNumberMaxLength);

            builder
               .HasOne(m => m.User)
               .WithOne(u => u.Member)
               .HasForeignKey<Member>(u => u.UserId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
