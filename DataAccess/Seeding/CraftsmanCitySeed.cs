using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCraftsmanCities(ModelBuilder modelBuilder)
        {
            var list = new List<CraftsmanCity>();
            int id = 1;
            var now = new DateTime(2024, 1, 1);

            // نفترض:
            // Craftsmen: 1 → 30
            // Cities: 1 → 20
            var cityIds = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int craftsmanId = 1; craftsmanId <= 30; craftsmanId++)
            {
                // مدينة أساسية
                int primaryCity = cityIds[(craftsmanId - 1) % cityIds.Length];

                list.Add(new CraftsmanCity
                {
                    Id = id++,
                    CraftsmanId = craftsmanId,
                    CityId = primaryCity,
                    IsPrimary = true,

                    // BaseModel
                    IsDeleted = false,
                    CreatedAt = now,
                    UpdatedAt = now
                });

                // مدينة إضافية (ثابتة – بدون Random)
                if (craftsmanId % 2 == 0)
                {
                    int secondaryCity = cityIds[(craftsmanId + 3) % cityIds.Length];

                    // تأكد إنها مش نفس الأساسية
                    if (secondaryCity != primaryCity)
                    {
                        list.Add(new CraftsmanCity
                        {
                            Id = id++,
                            CraftsmanId = craftsmanId,
                            CityId = secondaryCity,
                            IsPrimary = false,

                            // BaseModel
                            IsDeleted = false,
                            CreatedAt = now,
                            UpdatedAt = now
                        });
                    }
                }
            }

            modelBuilder.Entity<CraftsmanCity>().HasData(list);
        }
    }
}
