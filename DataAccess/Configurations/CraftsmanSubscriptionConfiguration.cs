using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CraftsmanSubscriptionConfiguration
    : IEntityTypeConfiguration<CraftsmanSubscription>
{
    public void Configure(EntityTypeBuilder<CraftsmanSubscription> builder)
    {
        builder.ToTable("CraftsmanSubscriptions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.StartDate)
               .IsRequired();

        builder.Property(x => x.EndDate)
               .IsRequired();

        builder.Property(x => x.Status)
               .IsRequired()
               .HasMaxLength(30);

        // 🔑 كل Craftsman يكون عنده Subscription واحدة Active
        builder.HasIndex(x => new { x.CraftsmanId, x.IsActive })
               .IsUnique()
               .HasFilter("[IsActive] = 1");

        builder.HasOne(x => x.Craftsman)
               .WithMany(c => c.Subscriptions)
               .HasForeignKey(x => x.CraftsmanId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Plan)
               .WithMany()
               .HasForeignKey(x => x.PlanId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.Payments)
               .WithOne(p => p.Subscription)
               .HasForeignKey(p => p.SubscriptionId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
