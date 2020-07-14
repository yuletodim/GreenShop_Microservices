namespace GreenShop_API.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using GreenShop_API.Data.Models;

    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.Quantity)
                .IsRequired();

            builder
               .HasOne(c => c.Product)
               .WithMany(p => p.Items)
               .HasForeignKey(i => i.ProductId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(i => i.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(i => i.OrderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
