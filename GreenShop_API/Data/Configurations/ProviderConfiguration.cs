namespace GreenShop_API.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using GreenShop_API.Data.Models;

    using static DataConstants;

    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            builder
                .Property(p => p.City)
                .IsRequired()
                .HasMaxLength(CityMaxLength);

            builder
                .Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(AddressMaxLength);

            builder
                .Property(p => p.Details)
                .HasMaxLength(DetailsMaxLength);
        }
    }
}
