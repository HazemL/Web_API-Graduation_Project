using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedSkills(ModelBuilder modelBuilder)
        {
            var baseDate = new DateTime(2024, 1, 1);

            var skills = new List<Skill>
            {
                new Skill { Id=1, Name="Wiring", ArabicName="تمديدات كهرباء" },
                new Skill { Id=2, Name="Circuit Diagnosis", ArabicName="تشخيص الدوائر الكهربائية" },
                new Skill { Id=3, Name="Panel Installation", ArabicName="تركيب لوحات كهرباء" },
                new Skill { Id=4, Name="Lighting", ArabicName="تركيب إضاءة" },
                new Skill { Id=5, Name="Power Outlets", ArabicName="تركيب مخارج كهرباء" },

                new Skill { Id=6, Name="Pipe Fixing", ArabicName="إصلاح مواسير" },
                new Skill { Id=7, Name="Drain Unclog", ArabicName="تسليك صرف" },
                new Skill { Id=8, Name="Faucet Repair", ArabicName="إصلاح حنفيات" },

                new Skill { Id=9, Name="Soldering", ArabicName="لحام" },

                new Skill { Id=10, Name="Wood Cutting", ArabicName="تقطيع خشب" },
                new Skill { Id=11, Name="Cabinet Making", ArabicName="تصنيع خزائن" },
                new Skill { Id=12, Name="Door Repair", ArabicName="إصلاح أبواب" },

                new Skill { Id=13, Name="Interior Painting", ArabicName="دهانات داخلية" },
                new Skill { Id=14, Name="Exterior Painting", ArabicName="دهانات خارجية" },

                new Skill { Id=15, Name="AC Repair", ArabicName="إصلاح تكييف" },
                new Skill { Id=16, Name="AC Gas Recharge", ArabicName="شحن فريون تكييف" },

                new Skill { Id=17, Name="Tile Laying", ArabicName="تركيب بلاط" },
                new Skill { Id=18, Name="Grouting", ArabicName="ملء فواصل البلاط" },

                new Skill { Id=19, Name="Roof Leak Repair", ArabicName="إصلاح تسريب أسطح" },
                new Skill { Id=20, Name="Shutter Installation", ArabicName="تركيب شتر" },

                new Skill { Id=21, Name="Lock Installation", ArabicName="تركيب أقفال" },
                new Skill { Id=22, Name="Lock Repair", ArabicName="إصلاح أقفال" },

                new Skill { Id=23, Name="Car Engine Repair", ArabicName="إصلاح محركات سيارات" },
                new Skill { Id=24, Name="Brake Repair", ArabicName="إصلاح فرامل" },
                new Skill { Id=25, Name="Battery Replacement", ArabicName="تغيير بطارية" },

                new Skill { Id=26, Name="Welding Mild Steel", ArabicName="لحام حديد" },
                new Skill { Id=27, Name="Welding Stainless", ArabicName="لحام ستانلس ستيل" },

                new Skill { Id=28, Name="Garden Pruning", ArabicName="تقليم حدائق" },
                new Skill { Id=29, Name="Lawn Mowing", ArabicName="جزّ العشب" },

                new Skill { Id=30, Name="Pressure Washing", ArabicName="غسيل بالضغط" },
                new Skill { Id=31, Name="Deep Cleaning", ArabicName="تنظيف عميق" },

                new Skill { Id=32, Name="Wallpaper Installation", ArabicName="تركيب ورق حائط" },
                new Skill { Id=33, Name="Decorative Plaster", ArabicName="محارة ديكورية" },

                new Skill { Id=34, Name="Pest Termite", ArabicName="مكافحة النمل الأبيض" },
                new Skill { Id=35, Name="Pest Rodent", ArabicName="مكافحة القوارض" },

                new Skill { Id=36, Name="Glass Cutting", ArabicName="تقطيع زجاج" },
                new Skill { Id=37, Name="Mirror Fitting", ArabicName="تركيب مرايات" },

                new Skill { Id=38, Name="Polish Floors", ArabicName="تلميع أرضيات" },
                new Skill { Id=39, Name="Marble Polishing", ArabicName="تلميع رخام" },
                new Skill { Id=40, Name="Ceramic Fixing", ArabicName="إصلاح سيراميك" },

                new Skill { Id=41, Name="HVAC Ductwork", ArabicName="تمديدات تكييف مركزي" },

                new Skill { Id=42, Name="Fridge Repair", ArabicName="إصلاح ثلاجات" },
                new Skill { Id=43, Name="Washing Machine Repair", ArabicName="إصلاح غسالات" },
                new Skill { Id=44, Name="Oven Repair", ArabicName="إصلاح أفران" },
                new Skill { Id=45, Name="Microwave Repair", ArabicName="إصلاح ميكروويف" },

                new Skill { Id=46, Name="Satellite Installation", ArabicName="تركيب دش" },
                new Skill { Id=47, Name="Home Theater Setup", ArabicName="تركيب مسرح منزلي" },
                new Skill { Id=48, Name="Smart Home Install", ArabicName="تركيب أنظمة منزل ذكي" },

                new Skill { Id=49, Name="Fence Repair", ArabicName="إصلاح أسوار" },
                new Skill { Id=50, Name="Gutter Cleaning", ArabicName="تنظيف مزاريب" },

                new Skill { Id=51, Name="Pool Maintenance", ArabicName="صيانة حمامات سباحة" },

                new Skill { Id=52, Name="Solar Panel Install", ArabicName="تركيب ألواح شمسية" },
                new Skill { Id=53, Name="Battery Storage", ArabicName="أنظمة تخزين طاقة" },
                new Skill { Id=54, Name="Insulation Install", ArabicName="تركيب عزل" },

                new Skill { Id=55, Name="Security Camera Install", ArabicName="تركيب كاميرات مراقبة" },
                new Skill { Id=56, Name="Access Control", ArabicName="أنظمة تحكم دخول" },

                new Skill { Id=57, Name="Door Frame Repair", ArabicName="إصلاح حلق باب" },
                new Skill { Id=58, Name="Skirting Fix", ArabicName="تركيب وزرة" },

                new Skill { Id=59, Name="Bathroom Renovation", ArabicName="تجديد حمامات" },
                new Skill { Id=60, Name="Kitchen Renovation", ArabicName="تجديد مطابخ" },

                new Skill { Id=61, Name="Countertop Install", ArabicName="تركيب رخام مطابخ" },
                new Skill { Id=62, Name="Tile Cutting", ArabicName="تقطيع بلاط" },

                new Skill { Id=63, Name="Plumbing Inspection", ArabicName="فحص سباكة" },
                new Skill { Id=64, Name="Septic Repair", ArabicName="إصلاح بيارات" },
                new Skill { Id=65, Name="Sealing & Caulking", ArabicName="عزل وسد فواصل" },

                new Skill { Id=66, Name="Concrete Repair", ArabicName="إصلاح خرسانة" },
                new Skill { Id=67, Name="Foundation Patch", ArabicName="ترميم أساسات" },
                new Skill { Id=68, Name="Bricklaying", ArabicName="بناء طوب" },
                new Skill { Id=69, Name="Masonry Repair", ArabicName="ترميم مباني" },

                new Skill { Id=70, Name="Window Repair", ArabicName="إصلاح شبابيك" },
                new Skill { Id=71, Name="Curtain Rod", ArabicName="تركيب ستائر" },

                new Skill { Id=72, Name="Upholstery Repair", ArabicName="تصليح تنجيد" },
                new Skill { Id=73, Name="Sofa Cleaning", ArabicName="تنظيف كنب" },
                new Skill { Id=74, Name="Mattress Cleaning", ArabicName="تنظيف مراتب" },

                new Skill { Id=75, Name="Chimney Sweep", ArabicName="تنظيف مداخن" },
                new Skill { Id=76, Name="Fireplace Repair", ArabicName="إصلاح مدافئ" },
                new Skill { Id=77, Name="Smoke Alarm Install", ArabicName="تركيب كاشف دخان" }
            };

            foreach (var skill in skills)
            {
                skill.IsDeleted = false;
                skill.CreatedAt = baseDate;
                skill.UpdatedAt = baseDate;
            }

            modelBuilder.Entity<Skill>().HasData(skills);
        }
    }
}
