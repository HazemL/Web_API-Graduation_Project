using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ReportConfiguration : IEntityTypeConfiguration<Report>
{
    public void Configure(EntityTypeBuilder<Report> builder)
    {
        builder.ToTable("Reports");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Message)
               .IsRequired()
               .HasMaxLength(1000);

        builder.Property(x => x.Status)
               .IsRequired()
               .HasMaxLength(30);

        builder.HasOne(x => x.Reporter)
               .WithMany(u => u.ReportsFiled)
               .HasForeignKey(x => x.ReporterUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.ReportedCraftsman)
               .WithMany()
               .HasForeignKey(x => x.CraftsmanId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.ReporterUserId);
        builder.HasIndex(x => x.CraftsmanId);
    }
}
