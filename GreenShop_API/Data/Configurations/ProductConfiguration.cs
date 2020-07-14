namespace GreenShop_API.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using GreenShop_API.Data.Models;

    using static DataConstants;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Reference)
                .IsRequired()
                .HasMaxLength(ReferenceMaxLength);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            builder
                .Property(p => p.Description)
                .HasMaxLength(DescriptionMaxLength);

            builder
                .Property(p => p.ImageUrl)
                .HasMaxLength(ImageUrlMaxLength);

            builder
                .HasOne(p => p.Provider)
                .WithMany(pr => pr.Products)
                .HasForeignKey(p => p.ProviderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
