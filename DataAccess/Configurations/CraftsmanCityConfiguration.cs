using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CraftsmanCityConfiguration : IEntityTypeConfiguration<CraftsmanCity>
{
    public void Configure(EntityTypeBuilder<CraftsmanCity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(x => new { x.CraftsmanId, x.CityId })
               .IsUnique();

        builder.Property(x => x.IsPrimary)
               .IsRequired();

        builder.HasOne(x => x.Craftsman)
               .WithMany(c => c.WorkedCities)
               .HasForeignKey(x => x.CraftsmanId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.City)
               .WithMany(c => c.CraftsmanCities)
               .HasForeignKey(x => x.CityId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
