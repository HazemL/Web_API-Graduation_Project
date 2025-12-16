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
                    ReporterUserId = ((i + 3) % 50) + 1,
                    Message = $"Report reason #{i + 1}",
                    Status = (i % 3 == 0) ? "Pending" : "Resolved",

                    IsDeleted = false,
                    CreatedAt = baseDate.AddDays(i),
                    UpdatedAt = baseDate.AddDays(i)
                });
            }

            modelBuilder.Entity<Report>().HasData(reports);
        }
    }
}
