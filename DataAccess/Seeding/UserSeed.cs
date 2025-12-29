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

            // =====================================================
            // 🔐 PASSWORD HASH (123456)
            // =====================================================
            const string DefaultPasswordHash =
                "O2Esdae1BIpDX7bsgeUv+S1teVqLWpwXBw9qY8l6U7I=";

            // =====================================================
            // 🖼️ PROFILE IMAGES (Cloudinary)
            // =====================================================
            var profileImages = new List<string>
            {
                "https://res.cloudinary.com/dyzyadtiv/image/upload/v1767020179/profiles/nrjgydrm2g0rxvdzzkr0.png",
                "https://res.cloudinary.com/dyzyadtiv/image/upload/v1767021527/profiles/mdqm8rj0zilxajdcvnzx.png",
                "https://res.cloudinary.com/dyzyadtiv/image/upload/v1767021553/profiles/ej0kxrdwkegbwiiuvrc6.png",
                "https://res.cloudinary.com/dyzyadtiv/image/upload/v1767021583/profiles/jxieawtyublxo40xagpf.png",
                "https://res.cloudinary.com/dyzyadtiv/image/upload/v1767021605/profiles/qucfyefb96ikivt2zf8r.png",
                "https://res.cloudinary.com/dyzyadtiv/image/upload/v1767021645/profiles/gpqnjbtps2wzka8cdpdp.png",
                "https://res.cloudinary.com/dyzyadtiv/image/upload/v1767021677/profiles/pzqkgri6ujtotz2lctbq.png"
            };

            // =====================================================
            // 👑 ADMIN
            // =====================================================
            users.Add(new User
            {
                Id = 1,
                FullName = "Admin",
                Email = "admin@gmail.com",
                PasswordHash = DefaultPasswordHash,
                Phone = "01000000000",
                Role = "Admin",
                IsActive = true,
                ProfileImage = profileImages[0],
                GovernorateId = null,
                CityId = null,
                CreatedAt = baseDate,
                UpdatedAt = baseDate
            });

            // =====================================================
            // 🧾 NAME PARTS
            // =====================================================
            var firstNames = new[]
            {
                "أحمد","محمد","محمود","عبدالله","عمر","كريم","إيهاب","طارق",
                "علي","يوسف","خالد","إبراهيم","مصطفى","حسن","سامي","ياسر"
            };

            var middleNames = new[]
            {
                "محمد","حسن","إبراهيم","محمود","عبدالرحمن",
                "مصطفى","ياسر","سامي","فؤاد","كمال"
            };

            var lastNames = new[]
            {
                "علي","حسن","إبراهيم","محمود","سامي",
                "صلاح","مصطفى","عبدالله","فؤاد","ياسين"
            };

            // =====================================================
            // 👷 CRAFTSMEN USERS (160)
            // =====================================================
            const int craftsmenCount = 160;
            int id = 2;

            for (int i = 0; i < craftsmenCount; i++)
            {
                var fullName =
                    $"{firstNames[i % firstNames.Length]} " +
                    $"{middleNames[(i / firstNames.Length) % middleNames.Length]} " +
                    $"{lastNames[(i / (firstNames.Length * middleNames.Length)) % lastNames.Length]}";

                users.Add(new User
                {
                    Id = id,
                    FullName = fullName,
                    Email = $"craftsman{id}@example.com",
                    PasswordHash = DefaultPasswordHash,
                    Phone = $"010{id:00000000}",
                    Role = "Craftsman",
                    IsActive = true,

                    // 🖼️ Profile Image (rotated)
                    ProfileImage = profileImages[i % profileImages.Count],

                    GovernorateId = 1,
                    CityId = (id % 5) + 1,
                    CreatedAt = baseDate.AddDays(i),
                    UpdatedAt = baseDate.AddDays(i)
                });

                id++;
            }

            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
