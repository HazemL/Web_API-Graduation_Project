using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CraftsmanConfiguration : IEntityTypeConfiguration<Craftsman>
{
    public void Configure(EntityTypeBuilder<Craftsman> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Bio)
               .HasMaxLength(1000);

        builder.Property(x => x.ExperienceYears)
               .IsRequired();

        builder.Property(x => x.MinPrice)
               .HasColumnType("decimal(18,2)");

        builder.Property(x => x.MaxPrice)
               .HasColumnType("decimal(18,2)");

        builder.Property(x => x.VerificationDate)
               .IsRequired(false);

        builder.HasOne(x => x.User)
               .WithMany(u => u.CraftsmenProfiles)
               .HasForeignKey(x => x.UserId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Profession)
               .WithMany(p => p.Craftsmen)
               .HasForeignKey(x => x.ProfessionId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
