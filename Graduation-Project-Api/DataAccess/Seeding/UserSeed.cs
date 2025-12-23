using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedUsers(ModelBuilder modelBuilder)
        {
            var baseDate = new DateTime(2024, 1, 1);

            var users = new List<User>();

            // ===================== ADMIN (ثابت) =====================
            users.Add(new User
            {
                Id = 1,
                FullName = "Mohamednasr",
                Email = "Mohamednasr@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==",
                // Admin@123
                Phone = "01000000000",
                Role = "Admin",
                IsActive = true,
                ProfileImage = "default-user.png",

                IsDeleted = false,
                CreatedAt = baseDate,
                UpdatedAt = baseDate
            });

            // ===================== باقي المستخدمين =====================
            var names = new[]
            {
                "أحمد علي","محمد حسن","محمود إبراهيم","عبدالله محمود","عمر سامي",
                "كريم صلاح","سارة محمد","نور مصطفى","هند أحمد","ليلى صلاح",
                "منى علي","إيهاب سعيد","مروة سمير","طارق حسن","علي فؤاد",
                "يوسف أحمد","عائشة محمود","مريم علي","خالد محمد","إبراهيم حسن",
                "علياء عمر","نوران خالد","سعد محمود","راغب سمير","إيمان أيمن",
                "ريم أحمد","هشام فتحي","سامي ياسر","أمل محمود","شهد علي",
                "إيناس سامي","مصطفى جمال","حسن يوسف","نبيل عبدالعزيز","شيماء إبراهيم",
                "دنيا حسني","هالة سمير","رنا خالد","نوح أحمد","آدم علي",
                "ملاك حسن","زينة محمود","تامر إيهاب","ماهر صبري","جمال حسين",
                "رامي خالد","بهاء الدين محمد","كرم أحمد","بلال سمير","سلوى علي"
            };

            int id = 2;

            foreach (var fullName in names)
            {
                var role =
                    id <= 6 ? "Craftsman" : "Customer";

                users.Add(new User
                {
                    Id = id,
                    FullName = fullName,
                    Email = $"user{id}@example.com",
                    PasswordHash = "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==",
                    Phone = $"010{id:00000000}",
                    Role = role,
                    IsActive = true,
                    ProfileImage = "default-user.png",

                    IsDeleted = false,
                    CreatedAt = baseDate,
                    UpdatedAt = baseDate
                });

                id++;
            }

            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
