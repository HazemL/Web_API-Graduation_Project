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

            // ===================== ADMIN (FIXED) =====================
            // Email    : admin@gmail.com
            // Password : 123456
            users.Add(new User
            {
                Id = 1,
                FullName = "Admin",
                Email = "admin@gmail.com",

                // Password: 123456
                PasswordHash =
                    "O2Esdae1BIpDX7bsgeUv+S1teVqLWpwXBw9qY8l6U7I=",

                Phone = "01000000000",
                Role = "Admin",
                IsActive = true,
                ProfileImage = "default-user.png",

                // Admin is not location-bound
                GovernorateId = null,
                CityId = null,

                CreatedAt = baseDate,
                UpdatedAt = baseDate
            });

            // ===================== OTHER USERS (DEMO) =====================
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
                // NOTE:
                // First users are Craftsmen for demo purposes
                // Other users are Customers
                var role = id <= 31 ? "Craftsman" : "Customer";

                users.Add(new User
                {
                    Id = id,
                    FullName = fullName,
                    Email = $"user{id}@example.com",

                    // Password: 123456
                    PasswordHash =
                        "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=",

                    Phone = $"010{id:00000000}",
                    Role = role,
                    IsActive = true,
                    ProfileImage = "default-user.png",

                    // Location (must exist in SeedCities)
                    GovernorateId = 1,
                    CityId = (id % 5) + 1,

                    CreatedAt = baseDate,
                    UpdatedAt = baseDate
                });

                id++;
            }

            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
