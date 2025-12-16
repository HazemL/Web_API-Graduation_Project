using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payments");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Amount)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(x => x.Currency)
               .IsRequired()
               .HasMaxLength(10);

        builder.Property(x => x.PaymentMethod)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(x => x.ProviderReference)
               .HasMaxLength(150);

        builder.Property(x => x.Status)
               .IsRequired()
               .HasMaxLength(30);

        builder.HasOne(x => x.Subscription)
               .WithMany(s => s.Payments)
               .HasForeignKey(x => x.SubscriptionId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.SubscriptionId);
    }
}
