using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
      
        public static void SeedCraftsmen(ModelBuilder modelBuilder)
        {
            var list = new List<Craftsman>();
            var now = new DateTime(2024, 1, 1);

            int craftsmanId = 1;

            // ⚠️ Profession IDs must exist in SeedProfessions
            var professionIds = new[]
            {
                1, 2, 3, 4, 5,
                6, 7, 8, 9, 10,
                11, 12, 13, 14, 15,
                16, 17, 18, 19, 20
            };

            // Users 2 -> 31 are Craftsmen (as defined in SeedUsers)
            for (int userId = 2; userId <= 31; userId++)
            {
                bool isVerified = (userId % 3 == 0);

                // Base price calculation (demo logic)
                var minPrice = 100 + ((userId - 2) * 10) % 400;
                var maxPrice = 300 + ((userId - 2) * 20) % 800;

                // Ensure valid price range
                if (maxPrice < minPrice)
                    maxPrice = minPrice + 100;

                list.Add(new Craftsman
                {
                    Id = craftsmanId++,
                    UserId = userId,

                    // Rotate professions for demo distribution
                    ProfessionId = professionIds[(userId - 2) % professionIds.Length],

                    Bio = $"Skilled professional #{userId}",
                    ExperienceYears = 2 + ((userId - 2) % 15),

                    MinPrice = minPrice,
                    MaxPrice = maxPrice,

                    IsVerified = isVerified,
                    VerificationDate = isVerified ? now : null,

                    CreatedAt = now,
                    UpdatedAt = now
                });
            }

            modelBuilder.Entity<Craftsman>().HasData(list);
        }
    }
}
