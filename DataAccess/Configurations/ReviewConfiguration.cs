using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("Reviews");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Stars)
               .IsRequired();

        builder.Property(x => x.Comment)
               .HasMaxLength(1000)
               .IsRequired();

        // User → Reviews (SET NULL)
        builder.HasOne(x => x.Reviewer)
               .WithMany(u => u.ReviewsWritten)
               .HasForeignKey(x => x.UserId)
               .OnDelete(DeleteBehavior.SetNull);

        // Craftsman → Reviews
        builder.HasOne(x => x.Craftsman)
               .WithMany(c => c.Reviews)
               .HasForeignKey(x => x.CraftsmanId)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(x => x.CraftsmanId);
        builder.HasIndex(x => x.UserId);
    }
}
