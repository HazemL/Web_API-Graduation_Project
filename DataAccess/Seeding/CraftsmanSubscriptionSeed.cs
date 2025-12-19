using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCraftsmanSubscriptions(ModelBuilder modelBuilder)
        {
            var list = new List<CraftsmanSubscription>();
            int id = 1;

            // تاريخ ثابت (مهم جدًا مع HasData)
            var startBase = new DateTime(2024, 1, 1);

            // Craftsmen: 1 → 20
            for (int craftsmanId = 1; craftsmanId <= 20; craftsmanId++)
            {
                var startDate = startBase.AddDays(craftsmanId * 2);
                var endDate = startDate.AddDays(30);

                list.Add(new CraftsmanSubscription
                {
                    Id = id++,
                    CraftsmanId = craftsmanId,
                    PlanId = (craftsmanId % 2 == 0) ? 2 : 3,

                    StartDate = startDate,
                    EndDate = endDate,
                    IsActive = endDate > new DateTime(2024, 2, 1),
                    Status = "Active",

                    // BaseModel
                    IsDeleted = false,
                    CreatedAt = startDate,
                    UpdatedAt = startDate
                });
            }

            modelBuilder.Entity<CraftsmanSubscription>().HasData(list);
        }
    }
}
