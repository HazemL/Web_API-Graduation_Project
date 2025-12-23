using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Email)
               .IsRequired()
               .HasMaxLength(150);

        builder.HasIndex(x => x.Email)
               .IsUnique();

        builder.Property(x => x.PasswordHash)
               .IsRequired();

        builder.Property(x => x.FullName)
               .HasMaxLength(150);

        builder.Property(x => x.Phone)
               .HasMaxLength(20);

        builder.Property(x => x.ProfileImage)
               .HasMaxLength(300);

        builder.Property(x => x.Role)
               .IsRequired()
               .HasMaxLength(30);

        builder.Property(x => x.IsActive)
               .HasDefaultValue(true);
    }
}
