using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProfessionConfiguration : IEntityTypeConfiguration<Profession>
{
    public void Configure(EntityTypeBuilder<Profession> builder)
    {
        builder.ToTable("Professions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(150);

        builder.Property(x => x.ArabicName)
               .IsRequired()
               .HasMaxLength(150);

        builder.Property(x => x.Description)
               .HasMaxLength(500);

        builder.HasIndex(x => x.Name)
               .IsUnique();

        builder.HasMany(x => x.Craftsmen)
               .WithOne(c => c.Profession)
               .HasForeignKey(c => c.ProfessionId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
