using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class GalleryConfiguration : IEntityTypeConfiguration<Gallery>
{
    public void Configure(EntityTypeBuilder<Gallery> builder)
    {
        builder.ToTable("Galleries");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.MediaUrl)
               .IsRequired()
               .HasMaxLength(500);

        builder.Property(x => x.MediaType)
               .IsRequired()
               .HasMaxLength(20);

        builder.Property(x => x.Title)
               .IsRequired()
               .HasMaxLength(150);

        builder.Property(x => x.Description)
               .HasMaxLength(1000);

        builder.HasOne(x => x.Craftsman)
               .WithMany(c => c.GalleryImages)
               .HasForeignKey(x => x.CraftsmanId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.CraftsmanId);

      
    }
}
