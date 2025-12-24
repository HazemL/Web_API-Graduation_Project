using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedReviews(ModelBuilder modelBuilder)
        {
            var reviews = new List<Review>();
            var baseDate = new DateTime(2024, 1, 1);
            var rnd = new Random(100);
            int id = 1;

            for (int i = 0; i < 120; i++)
            {
                int craftsmanId = (i % 30) + 1;
                int? userId = (i % 10 == 0) ? null : (i % 50) + 1;

                reviews.Add(new Review
                {
                    Id = id++,
                    CraftsmanId = craftsmanId,
                    UserId = userId,
                    Stars = rnd.Next(3, 6),
                    Comment = $"Review {i + 1} for craftsman {craftsmanId}",
                    IsVerified = rnd.NextDouble() > 0.3,
                    IsApproved = true,
                    IsDeleted = false,
                    CreatedAt = baseDate.AddDays(i),
                    UpdatedAt = baseDate.AddDays(i)
                });
            }

            modelBuilder.Entity<Review>().HasData(reviews);
        }
    }
}
