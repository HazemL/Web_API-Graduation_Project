using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedGovernorates(ModelBuilder modelBuilder)
        {
            var baseDate = new DateTime(2024, 1, 1);

            var data = new List<Governorate>
            {
                new Governorate { Id = 1, Name = "Cairo", ArabicName = "القاهرة", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 2, Name = "Giza", ArabicName = "الجيزة", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 3, Name = "Alexandria", ArabicName = "الإسكندرية", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 4, Name = "Suez", ArabicName = "السويس", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 5, Name = "Port Said", ArabicName = "بورسعيد", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 6, Name = "Damietta", ArabicName = "دمياط", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 7, Name = "Daqahlia", ArabicName = "الدقهلية", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 8, Name = "Sharqia", ArabicName = "الشرقية", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 9, Name = "Gharbia", ArabicName = "الغربية", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 10, Name = "Kafr El Sheikh", ArabicName = "كفر الشيخ", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 11, Name = "Beheira", ArabicName = "البحيرة", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 12, Name = "Fayoum", ArabicName = "الفيوم", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 13, Name = "Beni Suef", ArabicName = "بني سويف", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 14, Name = "Minya", ArabicName = "المنيا", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 15, Name = "Asyut", ArabicName = "أسيوط", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 16, Name = "Sohag", ArabicName = "سوهاج", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 17, Name = "Qena", ArabicName = "قنا", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 18, Name = "Luxor", ArabicName = "الأقصر", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 19, Name = "Aswan", ArabicName = "أسوان", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 20, Name = "Red Sea", ArabicName = "البحر الأحمر", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 21, Name = "New Valley", ArabicName = "الوادي الجديد", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 22, Name = "Matrouh", ArabicName = "مطروح", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 23, Name = "North Sinai", ArabicName = "شمال سيناء", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 24, Name = "South Sinai", ArabicName = "جنوب سيناء", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate },
                new Governorate { Id = 25, Name = "Ismailia", ArabicName = "الإسماعيلية", IsDeleted = false, CreatedAt = baseDate, UpdatedAt = baseDate }
            };

            modelBuilder.Entity<Governorate>().HasData(data);
        }
    }
}
