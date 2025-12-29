using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedGalleries(ModelBuilder modelBuilder)
        {
            var list = new List<Gallery>();
            int id = 1;

            var baseDate = new DateTime(2024, 1, 10);

            // ===================== PROFILE IMAGES =====================
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

            int totalCraftsmen = 160;

            for (int craftsmanId = 1; craftsmanId <= totalCraftsmen; craftsmanId++)
            {
                var created = baseDate.AddDays(craftsmanId);

                // ===================== PROFILE IMAGE =====================
                list.Add(new Gallery
                {
                    Id = id++,
                    CraftsmanId = craftsmanId,
                    MediaUrl = profileImages[craftsmanId % profileImages.Count],
                    MediaType = "Profile", // 🔥 المهم
                    Title = "Profile Image",
                    Description = "Craftsman profile image",
                    CreatedAt = created,
                    UpdatedAt = created
                });

                // ===================== WORK IMAGES =====================
                for (int i = 1; i <= 3; i++)
                {
                    list.Add(new Gallery
                    {
                        Id = id++,
                        CraftsmanId = craftsmanId,
                        MediaUrl = $"https://res.cloudinary.com/demo/image/upload/sample.jpg",
                        MediaType = "Image",
                        Title = $"Work sample {i}",
                        Description = $"Sample work {i}",
                        CreatedAt = created,
                        UpdatedAt = created
                    });
                }
            }

            modelBuilder.Entity<Gallery>().HasData(list);
        }
    }
}
