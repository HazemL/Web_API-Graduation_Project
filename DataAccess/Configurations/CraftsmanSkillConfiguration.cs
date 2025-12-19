using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CraftsmanSkillConfiguration
    : IEntityTypeConfiguration<CraftsmanSkill>
{
    public void Configure(EntityTypeBuilder<CraftsmanSkill> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(x => new { x.CraftsmanId, x.SkillId })
               .IsUnique();

        builder.Property(x => x.ProficiencyLevel)
               .HasMaxLength(50);

        builder.HasOne(x => x.Craftsman)
               .WithMany(c => c.Skills)
               .HasForeignKey(x => x.CraftsmanId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Skill)
               .WithMany(s => s.CraftsmanSkills)
               .HasForeignKey(x => x.SkillId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
