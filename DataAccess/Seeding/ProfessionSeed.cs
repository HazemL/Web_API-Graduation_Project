using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedProfessions(ModelBuilder modelBuilder)
        {
            var baseDate = new DateTime(2024, 1, 1);

            var list = new List<Profession>
    {
        // =====================================================
        // ⭐ PRIORITY PROFESSIONS (shown first in UI)
        // =====================================================
        new Profession { Id = 1, Name = "Plumber",             ArabicName = "سباك",               Description = "Plumbing & pipe repair",        CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 2, Name = "Carpenter",           ArabicName = "نجار",               Description = "Wood works & furniture",        CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 3, Name = "Electrician",         ArabicName = "فني كهرباء",         Description = "Electrical installation & repair", CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 4, Name = "Painter",             ArabicName = "دهان",               Description = "Interior & exterior painting", CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 5, Name = "AC Technician",       ArabicName = "فني تكييف",          Description = "AC repair & maintenance",      CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 6, Name = "Tile Setter",         ArabicName = "عامل بلاط",           Description = "Tiles & flooring",             CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 7, Name = "Ceramic Specialist",  ArabicName = "تخصص سيراميك",        Description = "Ceramic work",                 CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 8, Name = "Home Appliance Tech", ArabicName = "فني أجهزة منزلية",   Description = "Appliance repair",             CreatedAt = baseDate, UpdatedAt = baseDate },

        // =====================================================
        // OTHER PROFESSIONS
        // =====================================================
        new Profession { Id = 9,  Name = "Mechanic",        ArabicName = "ميكانيكي",        Description = "Vehicle repair",               CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 10, Name = "Welder",          ArabicName = "لحام",             Description = "Metal works & welding",         CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 11, Name = "Gardener",        ArabicName = "بستاني",           Description = "Gardening & landscaping",       CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 12, Name = "Cleaner",         ArabicName = "عامل نظافة",        Description = "Home & office cleaning",        CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 13, Name = "Decorator",       ArabicName = "ديكور",            Description = "Interior decoration",           CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 14, Name = "Pest Control",    ArabicName = "مكافحة حشرات",     Description = "Pest control services",         CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 15, Name = "Glass Installer", ArabicName = "تركيب زجاج",        Description = "Glass & windows",               CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 16, Name = "Floor Polisher",  ArabicName = "تلميع أرضيات",     Description = "Floor polishing",               CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 17, Name = "Roofer",          ArabicName = "عامل سقوف",         Description = "Roofing and waterproofing",     CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 18, Name = "Locksmith",       ArabicName = "مفتاحجي",           Description = "Locks & keys services",          CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 19, Name = "HVAC Engineer",   ArabicName = "مهندس تكييف",       Description = "HVAC systems",                  CreatedAt = baseDate, UpdatedAt = baseDate },
        new Profession { Id = 20, Name = "Painter (Spray)", ArabicName = "دهان سبراي",        Description = "Spray painting",                CreatedAt = baseDate, UpdatedAt = baseDate }
    };

            modelBuilder.Entity<Profession>().HasData(list);
        }
    }
}
