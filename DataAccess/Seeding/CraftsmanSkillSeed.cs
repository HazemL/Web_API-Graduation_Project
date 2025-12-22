using DataAccess.Enums;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCraftsmanSkills(ModelBuilder modelBuilder)
        {
            var list = new List<CraftsmanSkill>();
            int id = 1;
            var now = new DateTime(2024, 1, 1);

            // نفترض:
            // Craftsmen: 1 → 30
            // Skills: 1 → 40
            int craftsmanCount = 30;
            int skillCount = 40;

            for (int craftsmanId = 1; craftsmanId <= craftsmanCount; craftsmanId++)
            {
                // كل Craftsman عنده 3 Skills
                for (int offset = 0; offset < 3; offset++)
                {
                    int skillId = ((craftsmanId + offset) % skillCount) + 1;

                    ProficiencyLevel level;

                    if (offset == 0)
                        level = ProficiencyLevel.Beginner;
                    else if (offset == 1)
                        level = ProficiencyLevel.Intermediate;
                    else
                        level = ProficiencyLevel.Expert;

                    list.Add(new CraftsmanSkill
                    {
                        Id = id++,
                        CraftsmanId = craftsmanId,
                        SkillId = skillId,
                        ProficiencyLevel = level,

                        // BaseModel
                        IsDeleted = false,
                        CreatedAt = now,
                        UpdatedAt = now
                    });
                }
            }

            modelBuilder.Entity<CraftsmanSkill>().HasData(list);
        }
    }
}
