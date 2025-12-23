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
            int id = 1;
            var now = new DateTime(2024, 1, 1);

            var professionIds = new[]
            {
                1,2,3,4,5,6,7,8,9,10,
                11,12,13,14,15,16,17,18,19,20
            };

            for (int userId = 2; userId <= 31; userId++)
            {
                bool verified = (userId % 3 == 0);

                list.Add(new Craftsman
                {
                    Id = id++,
                    UserId = userId,
                    ProfessionId = professionIds[(userId - 2) % professionIds.Length],

                    Bio = $"Skilled professional #{userId}",
                    ExperienceYears = 2 + ((userId - 2) % 15),

                    MinPrice = 100 + ((userId - 2) * 10) % 400,
                    MaxPrice = 300 + ((userId - 2) * 20) % 800,

                    IsVerified = verified,
                    VerificationDate = verified ? now : null,

                    // BaseModel
                    IsDeleted = false,
                    CreatedAt = now,
                    UpdatedAt = now
                });
            }

            modelBuilder.Entity<Craftsman>().HasData(list);
        }
    }
}
