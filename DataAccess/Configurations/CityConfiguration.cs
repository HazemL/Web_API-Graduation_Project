using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(150);

        builder.Property(x => x.ArabicName)
               .IsRequired()
               .HasMaxLength(150);

        builder.Property(x => x.Latitude)
               .HasColumnType("decimal(9,6)");

        builder.Property(x => x.Longitude)
               .HasColumnType("decimal(9,6)");

        builder.HasOne(x => x.Governorate)
               .WithMany(g => g.Cities)
               .HasForeignKey(x => x.GovernorateId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
