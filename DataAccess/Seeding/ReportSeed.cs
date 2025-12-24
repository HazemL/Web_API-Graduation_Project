using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedReports(ModelBuilder modelBuilder)
        {
            var reports = new List<Report>();
            var baseDate = new DateTime(2024, 1, 1);
            int id = 1;

            for (int i = 0; i < 40; i++)
            {
                reports.Add(new Report
                {
                    Id = id++,

                    CraftsmanId = (i % 30) + 1,
                    ReporterUserId = ((i + 5) % 50) + 1,

                    Message = $"بلاغ رقم {i + 1} بسبب سوء تعامل",
                    Status = (i % 3 == 0) ? "Pending" : "Resolved",
                    IsResolved = i % 3 != 0,

                    IsDeleted = false,
                    CreatedAt = baseDate.AddDays(i),
                    UpdatedAt = baseDate.AddDays(i)
                });
            }

            modelBuilder.Entity<Report>().HasData(reports);
        }
    }
}
