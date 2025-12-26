using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class RevokedTokenConfiguration : IEntityTypeConfiguration<RevokedToken>
    {
        public void Configure(EntityTypeBuilder<RevokedToken> builder)
        {
            builder.Property(x => x.Token)
                   .IsRequired();
        }
    }
}
