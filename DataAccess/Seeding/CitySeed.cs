using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCities(ModelBuilder modelBuilder)
        {
            var now = new DateTime(2024, 1, 1);

            var cities = new List<City>
            {
                // =========================
                // Cairo (GovernorateId = 1)
                // =========================
                new City { Id = 1, GovernorateId = 1, Name = "Helwan", ArabicName = "حلوان", Latitude = 29.8414m, Longitude = 31.3008m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 2, GovernorateId = 1, Name = "New Cairo", ArabicName = "القاهرة الجديدة", Latitude = 30.0074m, Longitude = 31.4913m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 3, GovernorateId = 1, Name = "Shubra", ArabicName = "شبرا", Latitude = 30.0727m, Longitude = 31.2444m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 4, GovernorateId = 1, Name = "Ain Shams", ArabicName = "عين شمس", Latitude = 30.1310m, Longitude = 31.3190m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 5, GovernorateId = 1, Name = "El Marg", ArabicName = "المرج", Latitude = 30.1636m, Longitude = 31.3570m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 6, GovernorateId = 1, Name = "El Matareya", ArabicName = "المطرية", Latitude = 30.1216m, Longitude = 31.2877m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 7, GovernorateId = 1, Name = "Hadayek El Kobba", ArabicName = "حدائق القبة", Latitude = 30.0979m, Longitude = 31.2769m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 8, GovernorateId = 1, Name = "Nasr El Nil", ArabicName = "قصر النيل", Latitude = 30.0435m, Longitude = 31.2357m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 9, GovernorateId = 1, Name = "Garden City", ArabicName = "جاردن سيتي", Latitude = 30.0377m, Longitude = 31.2294m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 10, GovernorateId = 1, Name = "Sayeda Zeinab", ArabicName = "السيدة زينب", Latitude = 30.0296m, Longitude = 31.2442m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 11, GovernorateId = 1, Name = "El Khalifa", ArabicName = "الخليفة", Latitude = 30.0274m, Longitude = 31.2621m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 12, GovernorateId = 1, Name = "Mokattam", ArabicName = "المقطم", Latitude = 30.0179m, Longitude = 31.3126m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 13, GovernorateId = 1, Name = "Helmeyat El Zaitoun", ArabicName = "حلمية الزيتون", Latitude = 30.1172m, Longitude = 31.3002m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 14, GovernorateId = 1, Name = "Basateen", ArabicName = "البساتين", Latitude = 29.9766m, Longitude = 31.2625m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 15, GovernorateId = 1, Name = "Dar El Salam", ArabicName = "دار السلام", Latitude = 29.9706m, Longitude = 31.2594m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 16, GovernorateId = 1, Name = "El Salam City", ArabicName = "مدينة السلام", Latitude = 30.1780m, Longitude = 31.4035m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Giza (GovernorateId = 2)
                // =========================
                new City { Id = 17, GovernorateId = 2, Name = "Haram", ArabicName = "الهرم", Latitude = 29.9969m, Longitude = 31.1313m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 18, GovernorateId = 2, Name = "Faisal", ArabicName = "فيصل", Latitude = 30.0084m, Longitude = 31.1496m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 19, GovernorateId = 2, Name = "Imbaba", ArabicName = "إمبابة", Latitude = 30.0720m, Longitude = 31.2075m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 20, GovernorateId = 2, Name = "Agouza", ArabicName = "العجوزة", Latitude = 30.0555m, Longitude = 31.2156m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 21, GovernorateId = 2, Name = "Warraq", ArabicName = "الوراق", Latitude = 30.1017m, Longitude = 31.2012m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 22, GovernorateId = 2, Name = "Bulaq El Dakrour", ArabicName = "بولاق الدكرور", Latitude = 30.0357m, Longitude = 31.1706m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 23, GovernorateId = 2, Name = "Kerdasa", ArabicName = "كرداسة", Latitude = 30.0309m, Longitude = 31.1113m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 24, GovernorateId = 2, Name = "Abu Rawash", ArabicName = "أبو رواش", Latitude = 30.0576m, Longitude = 31.0849m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 25, GovernorateId = 2, Name = "Atfih", ArabicName = "أطفيح", Latitude = 29.4746m, Longitude = 31.2897m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 26, GovernorateId = 2, Name = "Saf", ArabicName = "الصف", Latitude = 29.5682m, Longitude = 31.2817m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 27, GovernorateId = 2, Name = "Oseem", ArabicName = "أوسيم", Latitude = 30.1236m, Longitude = 31.1331m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 28, GovernorateId = 2, Name = "Manshiyet El Bakary", ArabicName = "منشية البكاري", Latitude = 29.9974m, Longitude = 31.1574m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Alexandria (GovernorateId = 3)
                // =========================
                new City { Id = 29, GovernorateId = 3, Name = "Sidi Gaber", ArabicName = "سيدي جابر", Latitude = 31.2156m, Longitude = 29.9553m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 30, GovernorateId = 3, Name = "Smouha", ArabicName = "سموحة", Latitude = 31.2100m, Longitude = 29.9400m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 31, GovernorateId = 3, Name = "Stanley", ArabicName = "ستانلي", Latitude = 31.2358m, Longitude = 29.9662m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Suez (GovernorateId = 4)
                // =========================
                new City { Id = 32, GovernorateId = 4, Name = "Suez", ArabicName = "السويس", Latitude = 29.9668m, Longitude = 32.5498m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Port Said (GovernorateId = 5)
                // =========================
                new City { Id = 33, GovernorateId = 5, Name = "Port Said", ArabicName = "بورسعيد", Latitude = 31.2653m, Longitude = 32.3019m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 34, GovernorateId = 5, Name = "Port Fouad", ArabicName = "بورفؤاد", Latitude = 31.2444m, Longitude = 32.3176m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Ismailia (GovernorateId = 6)
                // =========================
                new City { Id = 35, GovernorateId = 6, Name = "Ismailia", ArabicName = "الإسماعيلية", Latitude = 30.5965m, Longitude = 32.2715m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 36, GovernorateId = 6, Name = "Fayed", ArabicName = "فايد", Latitude = 30.3363m, Longitude = 32.3160m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 37, GovernorateId = 6, Name = "Qantara West", ArabicName = "القنطرة غرب", Latitude = 30.8505m, Longitude = 32.3181m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 38, GovernorateId = 6, Name = "Qantara East", ArabicName = "القنطرة شرق", Latitude = 30.8726m, Longitude = 32.3417m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 39, GovernorateId = 6, Name = "Tell El Kebir", ArabicName = "التل الكبير", Latitude = 30.5449m, Longitude = 31.7853m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 40, GovernorateId = 6, Name = "Abu Suwir", ArabicName = "أبو صوير", Latitude = 30.5674m, Longitude = 32.0876m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Dakahlia (GovernorateId = 7)
                // =========================
                new City { Id = 41, GovernorateId = 7, Name = "Mansoura", ArabicName = "المنصورة", Latitude = 31.0409m, Longitude = 31.3785m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 42, GovernorateId = 7, Name = "Talkha", ArabicName = "طلخا", Latitude = 31.0539m, Longitude = 31.3802m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 43, GovernorateId = 7, Name = "Mit Ghamr", ArabicName = "ميت غمر", Latitude = 30.7144m, Longitude = 31.2599m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 44, GovernorateId = 7, Name = "Belqas", ArabicName = "بلقاس", Latitude = 31.2165m, Longitude = 31.3578m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 45, GovernorateId = 7, Name = "Dekernes", ArabicName = "دكرنس", Latitude = 31.0883m, Longitude = 31.5947m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 46, GovernorateId = 7, Name = "Aga", ArabicName = "أجا", Latitude = 30.9406m, Longitude = 31.2907m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 47, GovernorateId = 7, Name = "Manzala", ArabicName = "المنزلة", Latitude = 31.1586m, Longitude = 31.9319m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 48, GovernorateId = 7, Name = "Sherbin", ArabicName = "شربين", Latitude = 31.1969m, Longitude = 31.5248m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 49, GovernorateId = 7, Name = "Mataria", ArabicName = "المطرية", Latitude = 31.1827m, Longitude = 32.0329m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 50, GovernorateId = 7, Name = "Gamasa", ArabicName = "جمصة", Latitude = 31.4403m, Longitude = 31.5595m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 51, GovernorateId = 7, Name = "Sinbillawin", ArabicName = "السنبلاوين", Latitude = 30.8897m, Longitude = 31.4576m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 52, GovernorateId = 7, Name = "Tamay El Amdid", ArabicName = "تمي الأمديد", Latitude = 30.9617m, Longitude = 31.3626m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 53, GovernorateId = 7, Name = "Nabaroh", ArabicName = "نبروه", Latitude = 31.0876m, Longitude = 31.4649m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Sharqia (GovernorateId = 8)
                // =========================
                new City { Id = 54, GovernorateId = 8, Name = "Zagazig", ArabicName = "الزقازيق", Latitude = 30.5877m, Longitude = 31.5020m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 55, GovernorateId = 8, Name = "Belbeis", ArabicName = "بلبيس", Latitude = 30.4185m, Longitude = 31.5627m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 56, GovernorateId = 8, Name = "Minya El Qamh", ArabicName = "منيا القمح", Latitude = 30.4651m, Longitude = 31.1842m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 57, GovernorateId = 8, Name = "Abu Hammad", ArabicName = "أبو حماد", Latitude = 30.5363m, Longitude = 31.6817m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 58, GovernorateId = 8, Name = "Abu Kabir", ArabicName = "أبو كبير", Latitude = 30.7253m, Longitude = 31.6713m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 59, GovernorateId = 8, Name = "Hehia", ArabicName = "ههيا", Latitude = 30.6715m, Longitude = 31.5894m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 60, GovernorateId = 8, Name = "Faqous", ArabicName = "فاقوس", Latitude = 30.7287m, Longitude = 31.8021m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 61, GovernorateId = 8, Name = "Mashtool El Souk", ArabicName = "مشتول السوق", Latitude = 30.3614m, Longitude = 31.3776m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 62, GovernorateId = 8, Name = "El Ibrahimiya", ArabicName = "الإبراهيمية", Latitude = 30.7191m, Longitude = 31.5628m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 63, GovernorateId = 8, Name = "El Husseiniya", ArabicName = "الحسينية", Latitude = 30.8572m, Longitude = 31.9583m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 64, GovernorateId = 8, Name = "Kafr Saqr", ArabicName = "كفر صقر", Latitude = 30.7946m, Longitude = 31.8216m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 65, GovernorateId = 8, Name = "Awlad Saqr", ArabicName = "أولاد صقر", Latitude = 30.9307m, Longitude = 31.7009m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 66, GovernorateId = 8, Name = "Diyarb Negm", ArabicName = "ديرب نجم", Latitude = 30.7482m, Longitude = 31.4404m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 67, GovernorateId = 8, Name = "El Qurein", ArabicName = "القرين", Latitude = 30.6169m, Longitude = 31.7346m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 68, GovernorateId = 8, Name = "10th of Ramadan", ArabicName = "العاشر من رمضان", Latitude = 30.3066m, Longitude = 31.7418m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Gharbia (GovernorateId = 9)
                // =========================
                new City { Id = 69, GovernorateId = 9, Name = "Tanta", ArabicName = "طنطا", Latitude = 30.7865m, Longitude = 31.0004m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 70, GovernorateId = 9, Name = "El Mahalla El Kubra", ArabicName = "المحلة الكبرى", Latitude = 30.9693m, Longitude = 31.1669m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 71, GovernorateId = 9, Name = "Kafr El Zayat", ArabicName = "كفر الزيات", Latitude = 30.8289m, Longitude = 30.8146m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 72, GovernorateId = 9, Name = "Zefta", ArabicName = "زفتى", Latitude = 30.7147m, Longitude = 31.2424m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 73, GovernorateId = 9, Name = "Samanoud", ArabicName = "سمنود", Latitude = 30.9610m, Longitude = 31.2415m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 74, GovernorateId = 9, Name = "Qutour", ArabicName = "قطور", Latitude = 30.9726m, Longitude = 30.9565m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 75, GovernorateId = 9, Name = "Basyoun", ArabicName = "بسيون", Latitude = 30.9396m, Longitude = 30.8193m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 76, GovernorateId = 9, Name = "El Santa", ArabicName = "السنطة", Latitude = 30.7519m, Longitude = 31.1277m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Monufia (GovernorateId = 10)
                // =========================
                new City { Id = 77, GovernorateId = 10, Name = "Shebin El Kom", ArabicName = "شبين الكوم", Latitude = 30.5526m, Longitude = 31.0090m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 78, GovernorateId = 10, Name = "Menouf", ArabicName = "منوف", Latitude = 30.4687m, Longitude = 30.9339m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 79, GovernorateId = 10, Name = "Ashmoun", ArabicName = "أشمون", Latitude = 30.2986m, Longitude = 30.9766m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 80, GovernorateId = 10, Name = "Sadat City", ArabicName = "مدينة السادات", Latitude = 30.3666m, Longitude = 30.5331m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 81, GovernorateId = 10, Name = "Quesna", ArabicName = "قويسنا", Latitude = 30.5646m, Longitude = 31.1499m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 82, GovernorateId = 10, Name = "Bagour", ArabicName = "الباجور", Latitude = 30.4306m, Longitude = 31.0302m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 83, GovernorateId = 10, Name = "Berket El Sabaa", ArabicName = "بركة السبع", Latitude = 30.6281m, Longitude = 31.0729m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 84, GovernorateId = 10, Name = "Tala", ArabicName = "تلا", Latitude = 30.6816m, Longitude = 30.9437m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 85, GovernorateId = 10, Name = "El Shohada", ArabicName = "الشهداء", Latitude = 30.5981m, Longitude = 30.9004m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Beheira (GovernorateId = 11)
                // =========================
                new City { Id = 86, GovernorateId = 11, Name = "Damanhour", ArabicName = "دمنهور", Latitude = 31.0409m, Longitude = 30.4725m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 87, GovernorateId = 11, Name = "Kafr El Dawwar", ArabicName = "كفر الدوار", Latitude = 31.1336m, Longitude = 30.1290m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 88, GovernorateId = 11, Name = "Rashid", ArabicName = "رشيد", Latitude = 31.4026m, Longitude = 30.4171m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 89, GovernorateId = 11, Name = "Edku", ArabicName = "إدكو", Latitude = 31.3076m, Longitude = 30.2992m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 90, GovernorateId = 11, Name = "Abu Hummus", ArabicName = "أبو حمص", Latitude = 31.0936m, Longitude = 30.3028m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 91, GovernorateId = 11, Name = "Abu El Matamir", ArabicName = "أبو المطامير", Latitude = 30.9132m, Longitude = 30.1745m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 92, GovernorateId = 11, Name = "Delengat", ArabicName = "الدلنجات", Latitude = 30.8278m, Longitude = 30.5356m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 93, GovernorateId = 11, Name = "Kom Hamada", ArabicName = "كوم حمادة", Latitude = 30.7627m, Longitude = 30.6991m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 94, GovernorateId = 11, Name = "Hosh Essa", ArabicName = "حوش عيسى", Latitude = 30.9121m, Longitude = 30.2914m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 95, GovernorateId = 11, Name = "Itay El Baroud", ArabicName = "إيتاي البارود", Latitude = 30.8894m, Longitude = 30.6912m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 96, GovernorateId = 11, Name = "Shubrakhit", ArabicName = "شبراخيت", Latitude = 30.7166m, Longitude = 30.0684m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 97, GovernorateId = 11, Name = "Rahmaniya", ArabicName = "الرحمانية", Latitude = 31.0947m, Longitude = 30.6479m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 98, GovernorateId = 11, Name = "Mahmoudiya", ArabicName = "المحمودية", Latitude = 31.1822m, Longitude = 30.5294m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Kafr El Sheikh (GovernorateId = 12)
                // =========================
                new City { Id = 99, GovernorateId = 12, Name = "Kafr El Sheikh", ArabicName = "كفر الشيخ", Latitude = 31.1117m, Longitude = 30.9390m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 100, GovernorateId = 12, Name = "Desouk", ArabicName = "دسوق", Latitude = 31.1325m, Longitude = 30.6478m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 101, GovernorateId = 12, Name = "Baltim", ArabicName = "بلطيم", Latitude = 31.5586m, Longitude = 31.0886m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 102, GovernorateId = 12, Name = "Metoubas", ArabicName = "مطوبس", Latitude = 31.0375m, Longitude = 30.4664m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 103, GovernorateId = 12, Name = "Fuwwah", ArabicName = "فوه", Latitude = 31.2036m, Longitude = 30.5493m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 104, GovernorateId = 12, Name = "Sidi Salem", ArabicName = "سيدي سالم", Latitude = 31.2714m, Longitude = 30.7862m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 105, GovernorateId = 12, Name = "Qallin", ArabicName = "قلين", Latitude = 31.0456m, Longitude = 30.8169m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 106, GovernorateId = 12, Name = "Riyadh", ArabicName = "الرياض", Latitude = 31.1094m, Longitude = 30.6986m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 107, GovernorateId = 12, Name = "Hamoul", ArabicName = "الحامول", Latitude = 31.3119m, Longitude = 30.9473m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 108, GovernorateId = 12, Name = "Biyala", ArabicName = "بيلا", Latitude = 31.0412m, Longitude = 30.7054m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 109, GovernorateId = 12, Name = "Borollos", ArabicName = "برج البرلس", Latitude = 31.5833m, Longitude = 31.0678m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Damietta (GovernorateId = 13)
                // =========================
                new City { Id = 110, GovernorateId = 13, Name = "Damietta", ArabicName = "دمياط", Latitude = 31.4175m, Longitude = 31.8144m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 111, GovernorateId = 13, Name = "New Damietta", ArabicName = "دمياط الجديدة", Latitude = 31.4462m, Longitude = 31.6616m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 112, GovernorateId = 13, Name = "Faraskur", ArabicName = "فارسكور", Latitude = 31.3294m, Longitude = 31.7159m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 113, GovernorateId = 13, Name = "Kafr Saad", ArabicName = "كفر سعد", Latitude = 31.3578m, Longitude = 31.6926m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 114, GovernorateId = 13, Name = "Zarqa", ArabicName = "الزرقا", Latitude = 31.2089m, Longitude = 31.6356m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 115, GovernorateId = 13, Name = "Kafr El Battikh", ArabicName = "كفر البطيخ", Latitude = 31.3197m, Longitude = 31.6611m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Fayoum (GovernorateId = 14)
                // =========================
                new City { Id = 116, GovernorateId = 14, Name = "Fayoum", ArabicName = "الفيوم", Latitude = 29.3084m, Longitude = 30.8428m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 117, GovernorateId = 14, Name = "Sinnuris", ArabicName = "سنورس", Latitude = 29.4072m, Longitude = 30.8606m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 118, GovernorateId = 14, Name = "Itsa", ArabicName = "إطسا", Latitude = 29.2042m, Longitude = 30.7805m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 119, GovernorateId = 14, Name = "Tamiya", ArabicName = "طامية", Latitude = 29.4766m, Longitude = 30.9614m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 120, GovernorateId = 14, Name = "Yousef El Seddik", ArabicName = "يوسف الصديق", Latitude = 29.3628m, Longitude = 30.5984m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 121, GovernorateId = 14, Name = "Abshway", ArabicName = "أبشواي", Latitude = 29.3589m, Longitude = 30.6815m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Beni Suef (GovernorateId = 15)
                // =========================
                new City { Id = 122, GovernorateId = 15, Name = "Beni Suef", ArabicName = "بني سويف", Latitude = 29.0661m, Longitude = 31.0994m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 123, GovernorateId = 15, Name = "Naser", ArabicName = "ناصر", Latitude = 29.0717m, Longitude = 31.1033m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 124, GovernorateId = 15, Name = "Ehnasia", ArabicName = "إهناسيا", Latitude = 28.9056m, Longitude = 30.9466m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 125, GovernorateId = 15, Name = "Biba", ArabicName = "ببا", Latitude = 28.9230m, Longitude = 31.0116m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 126, GovernorateId = 15, Name = "Samasta", ArabicName = "سمسطا", Latitude = 28.8716m, Longitude = 31.0282m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 127, GovernorateId = 15, Name = "El Wasta", ArabicName = "الواسطى", Latitude = 29.3376m, Longitude = 31.2063m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Minya (GovernorateId = 16)
                // =========================
                new City { Id = 128, GovernorateId = 16, Name = "Minya", ArabicName = "المنيا", Latitude = 28.0871m, Longitude = 30.7618m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 129, GovernorateId = 16, Name = "Maghagha", ArabicName = "مغاغة", Latitude = 28.6475m, Longitude = 30.8420m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 130, GovernorateId = 16, Name = "Bani Mazar", ArabicName = "بني مزار", Latitude = 28.5036m, Longitude = 30.8005m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 131, GovernorateId = 16, Name = "Matay", ArabicName = "مطاي", Latitude = 28.4172m, Longitude = 30.7806m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 132, GovernorateId = 16, Name = "Samalut", ArabicName = "سمالوط", Latitude = 28.3136m, Longitude = 30.7101m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 133, GovernorateId = 16, Name = "Abu Qurqas", ArabicName = "أبو قرقاص", Latitude = 27.9319m, Longitude = 30.8361m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 134, GovernorateId = 16, Name = "Mallawi", ArabicName = "ملوي", Latitude = 27.7336m, Longitude = 30.8410m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 135, GovernorateId = 16, Name = "Deir Mawas", ArabicName = "دير مواس", Latitude = 27.6417m, Longitude = 30.8084m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 136, GovernorateId = 16, Name = "El Idwa", ArabicName = "العدوة", Latitude = 28.5021m, Longitude = 30.7503m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Assiut (GovernorateId = 17)
                // =========================
                new City { Id = 137, GovernorateId = 17, Name = "Assiut", ArabicName = "أسيوط", Latitude = 27.1800m, Longitude = 31.1837m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 138, GovernorateId = 17, Name = "Dayrout", ArabicName = "ديروط", Latitude = 27.5566m, Longitude = 30.8071m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 139, GovernorateId = 17, Name = "Qusiya", ArabicName = "القوصية", Latitude = 27.4403m, Longitude = 30.8186m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 140, GovernorateId = 17, Name = "Manfalut", ArabicName = "منفلوط", Latitude = 27.3117m, Longitude = 30.9700m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 141, GovernorateId = 17, Name = "Abu Tig", ArabicName = "أبوتيج", Latitude = 27.0449m, Longitude = 31.3183m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 142, GovernorateId = 17, Name = "Sahel Selim", ArabicName = "ساحل سليم", Latitude = 27.0419m, Longitude = 31.3886m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 143, GovernorateId = 17, Name = "El Badari", ArabicName = "البداري", Latitude = 26.9936m, Longitude = 31.4156m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 144, GovernorateId = 17, Name = "Abnub", ArabicName = "أبنوب", Latitude = 27.2681m, Longitude = 31.1514m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 145, GovernorateId = 17, Name = "Fath", ArabicName = "الفتح", Latitude = 27.1808m, Longitude = 31.1294m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 146, GovernorateId = 17, Name = "Ghanayem", ArabicName = "الغنايم", Latitude = 26.7439m, Longitude = 31.3275m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 147, GovernorateId = 17, Name = "Sadfa", ArabicName = "صدفا", Latitude = 26.9662m, Longitude = 31.3783m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Sohag (GovernorateId = 18)
                // =========================
                new City { Id = 148, GovernorateId = 18, Name = "Sohag", ArabicName = "سوهاج", Latitude = 26.5569m, Longitude = 31.6948m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 149, GovernorateId = 18, Name = "Akhmim", ArabicName = "أخميم", Latitude = 26.5622m, Longitude = 31.7446m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 150, GovernorateId = 18, Name = "Gerga", ArabicName = "جرجا", Latitude = 26.3386m, Longitude = 31.8914m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 151, GovernorateId = 18, Name = "Tahta", ArabicName = "طهطا", Latitude = 26.7693m, Longitude = 31.5020m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 152, GovernorateId = 18, Name = "Tima", ArabicName = "طما", Latitude = 26.8755m, Longitude = 31.4352m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 153, GovernorateId = 18, Name = "El Maragha", ArabicName = "المراغة", Latitude = 26.7065m, Longitude = 31.6023m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 154, GovernorateId = 18, Name = "El Monsha", ArabicName = "المنشأة", Latitude = 26.4761m, Longitude = 31.8047m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 155, GovernorateId = 18, Name = "Dar El Salam", ArabicName = "دار السلام", Latitude = 26.2569m, Longitude = 31.9543m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 156, GovernorateId = 18, Name = "El Balyana", ArabicName = "البلينا", Latitude = 26.2354m, Longitude = 31.9978m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 157, GovernorateId = 18, Name = "Juhayna", ArabicName = "جهينة", Latitude = 26.6767m, Longitude = 31.4964m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 158, GovernorateId = 18, Name = "Saqultah", ArabicName = "ساقلته", Latitude = 26.6492m, Longitude = 31.6731m, CreatedAt = now, UpdatedAt = now },

                // =========================
                // Qena (GovernorateId = 19)
                // =========================
                new City { Id = 159, GovernorateId = 19, Name = "Qena", ArabicName = "قنا", Latitude = 26.1551m, Longitude = 32.7160m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 160, GovernorateId = 19, Name = "Nag Hammadi", ArabicName = "نجع حمادي", Latitude = 26.0495m, Longitude = 32.2414m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 161, GovernorateId = 19, Name = "Qus", ArabicName = "قوص", Latitude = 25.9147m, Longitude = 32.7636m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 162, GovernorateId = 19, Name = "Deshna", ArabicName = "دشنا", Latitude = 26.1249m, Longitude = 32.4667m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 163, GovernorateId = 19, Name = "Farshout", ArabicName = "فرشوط", Latitude = 26.0543m, Longitude = 32.1606m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 164, GovernorateId = 19, Name = "Abu Tesht", ArabicName = "أبو تشت", Latitude = 26.1153m, Longitude = 32.1415m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 165, GovernorateId = 19, Name = "Naqada", ArabicName = "نقادة", Latitude = 25.9186m, Longitude = 32.7267m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 166, GovernorateId = 19, Name = "El Waqf", ArabicName = "الوقف", Latitude = 26.0509m, Longitude = 32.5212m, CreatedAt = now, UpdatedAt = now },
                // =========================
                // الأقصر (GovernorateId = 20)
                // =========================
                new City { Id = 167, GovernorateId = 20, Name = "Luxor", ArabicName = "الأقصر", Latitude = 25.6872m, Longitude = 32.6396m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 168, GovernorateId = 20, Name = "Esna", ArabicName = "إسنا", Latitude = 25.2936m, Longitude = 32.5540m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 169, GovernorateId = 20, Name = "Armant", ArabicName = "أرمنت", Latitude = 25.6170m, Longitude = 32.5346m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 170, GovernorateId = 20, Name = "El Toud", ArabicName = "الطود", Latitude = 25.5434m, Longitude = 32.7034m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 171, GovernorateId = 20, Name = "Qurna", ArabicName = "القرنة", Latitude = 25.7271m, Longitude = 32.6106m, CreatedAt = now, UpdatedAt = now },
                // =========================
                // Aswan (GovernorateId = 21)
                // =========================
                new City { Id = 172, GovernorateId = 21, Name = "Aswan", ArabicName = "أسوان", Latitude = 24.0889m, Longitude = 32.8998m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 173, GovernorateId = 21, Name = "Kom Ombo", ArabicName = "كوم أمبو", Latitude = 24.4760m, Longitude = 32.9463m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 174, GovernorateId = 21, Name = "Edfu", ArabicName = "إدفو", Latitude = 24.9785m, Longitude = 32.8770m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 175, GovernorateId = 21, Name = "Daraw", ArabicName = "دراو", Latitude = 24.4109m, Longitude = 32.9306m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 176, GovernorateId = 21, Name = "Nasr El Nuba", ArabicName = "نصر النوبة", Latitude = 23.4316m, Longitude = 32.7892m, CreatedAt = now, UpdatedAt = now },
                // =========================
                // Red Sea (GovernorateId = 22)
                // =========================
                new City { Id = 177, GovernorateId = 22, Name = "Hurghada", ArabicName = "الغردقة", Latitude = 27.2579m, Longitude = 33.8116m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 178, GovernorateId = 22, Name = "Safaga", ArabicName = "سفاجا", Latitude = 26.7500m, Longitude = 33.9333m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 179, GovernorateId = 22, Name = "Marsa Alam", ArabicName = "مرسى علم", Latitude = 25.0699m, Longitude = 34.8900m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 180, GovernorateId = 22, Name = "El Quseir", ArabicName = "القصير", Latitude = 26.1047m, Longitude = 34.2776m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 181, GovernorateId = 22, Name = "Ras Gharib", ArabicName = "رأس غارب", Latitude = 28.3589m, Longitude = 33.0781m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 182, GovernorateId = 22, Name = "Shalateen", ArabicName = "شلاتين", Latitude = 23.1367m, Longitude = 35.5857m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 183, GovernorateId = 22, Name = "Halayeb", ArabicName = "حلايب", Latitude = 22.2153m, Longitude = 36.0956m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 184, GovernorateId = 22, Name = "Abu Ramad", ArabicName = "أبو رماد", Latitude = 22.7892m, Longitude = 35.0976m, CreatedAt = now, UpdatedAt = now },
                // =========================
                // New Valley (GovernorateId = 23)
                // =========================
                new City { Id = 185, GovernorateId = 23, Name = "Kharga", ArabicName = "الخارجة", Latitude = 25.4446m, Longitude = 30.5464m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 186, GovernorateId = 23, Name = "Dakhla", ArabicName = "الداخلة", Latitude = 25.4894m, Longitude = 29.0030m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 187, GovernorateId = 23, Name = "Farafra", ArabicName = "الفرافرة", Latitude = 27.0568m, Longitude = 27.9695m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 188, GovernorateId = 23, Name = "Balat", ArabicName = "بلاط", Latitude = 25.5641m, Longitude = 28.8933m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 189, GovernorateId = 23, Name = "Paris", ArabicName = "باريس", Latitude = 24.4246m, Longitude = 30.7869m, CreatedAt = now, UpdatedAt = now },
                 // =========================
                // Matrouh (GovernorateId = 24)
                // =========================
                new City { Id = 190, GovernorateId = 24, Name = "Marsa Matrouh", ArabicName = "مرسى مطروح", Latitude = 31.3543m, Longitude = 27.2373m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 191, GovernorateId = 24, Name = "El Alamein", ArabicName = "العلمين", Latitude = 30.8300m, Longitude = 28.9550m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 192, GovernorateId = 24, Name = "El Dabaa", ArabicName = "الضبعة", Latitude = 31.0460m, Longitude = 28.4400m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 193, GovernorateId = 24, Name = "Sidi Barrani", ArabicName = "سيدي براني", Latitude = 31.6106m, Longitude = 25.9242m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 194, GovernorateId = 24, Name = "Siwa", ArabicName = "سيوة", Latitude = 29.2044m, Longitude = 25.5195m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 195, GovernorateId = 24, Name = "Sallum", ArabicName = "السلوم", Latitude = 31.5611m, Longitude = 25.1486m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 196, GovernorateId = 24, Name = "El Hamam", ArabicName = "الحمام", Latitude = 30.8464m, Longitude = 29.4381m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 197, GovernorateId = 24, Name = "El Negaila", ArabicName = "النجيلة", Latitude = 31.1458m, Longitude = 26.0956m, CreatedAt = now, UpdatedAt = now },
                 // =========================
                // North Sinai (GovernorateId = 25)
                // =========================
                new City { Id = 198, GovernorateId = 25, Name = "Arish", ArabicName = "العريش", Latitude = 31.1310m, Longitude = 33.7984m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 199, GovernorateId = 25, Name = "Sheikh Zuweid", ArabicName = "الشيخ زويد", Latitude = 31.2156m, Longitude = 34.1109m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 200, GovernorateId = 25, Name = "Rafah", ArabicName = "رفح", Latitude = 31.2870m, Longitude = 34.2440m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 201, GovernorateId = 25, Name = "Bir Al-Abd", ArabicName = "بئر العبد", Latitude = 31.0187m, Longitude = 33.0095m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 202, GovernorateId = 25, Name = "Hasana", ArabicName = "الحسنة", Latitude = 30.5833m, Longitude = 33.9000m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 203, GovernorateId = 25, Name = "Nakhl", ArabicName = "نخل", Latitude = 29.9147m, Longitude = 33.7500m, CreatedAt = now, UpdatedAt = now },
                   // =========================
                // South Sinai (GovernorateId = 26)
                // =========================
                new City { Id = 204, GovernorateId = 26, Name = "Sharm El-Sheikh", ArabicName = "شرم الشيخ", Latitude = 27.9158m, Longitude = 34.3299m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 205, GovernorateId = 26, Name = "Dahab", ArabicName = "دهب", Latitude = 28.5097m, Longitude = 34.5136m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 206, GovernorateId = 26, Name = "Nuweiba", ArabicName = "نويبع", Latitude = 29.0468m, Longitude = 34.6636m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 207, GovernorateId = 26, Name = "Taba", ArabicName = "طابا", Latitude = 29.4920m, Longitude = 34.8947m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 208, GovernorateId = 26, Name = "Saint Catherine", ArabicName = "سانت كاترين", Latitude = 28.5556m, Longitude = 33.9476m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 209, GovernorateId = 26, Name = "Ras Sidr", ArabicName = "رأس سدر", Latitude = 29.5916m, Longitude = 32.7160m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 210, GovernorateId = 26, Name = "Abu Redis", ArabicName = "أبو رديس", Latitude = 28.9106m, Longitude = 33.1967m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 211, GovernorateId = 26, Name = "Abu Zenima", ArabicName = "أبو زنيمة", Latitude = 29.0360m, Longitude = 33.0956m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 212, GovernorateId = 26, Name = "El Tor", ArabicName = "الطور", Latitude = 28.2394m, Longitude = 33.6225m, CreatedAt = now, UpdatedAt = now },
                // =========================
                // South Sinai (GovernorateId = 27)
                // =========================
                new City { Id = 213, GovernorateId = 27, Name = "Alexandria", ArabicName = "الإسكندرية", Latitude = 31.2001m, Longitude = 29.9187m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 214, GovernorateId = 27, Name = "Montaza", ArabicName = "المنتزه", Latitude = 31.2864m, Longitude = 30.0146m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 215, GovernorateId = 27, Name = "Sharq", ArabicName = "شرق", Latitude = 31.2156m, Longitude = 29.9553m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 216, GovernorateId = 27, Name = "Wasat", ArabicName = "وسط", Latitude = 31.2008m, Longitude = 29.9180m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 217, GovernorateId = 27, Name = "Gharb", ArabicName = "غرب", Latitude = 31.1826m, Longitude = 29.8854m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 218, GovernorateId = 27, Name = "Amreya", ArabicName = "العامرية", Latitude = 31.0167m, Longitude = 29.8500m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 219, GovernorateId = 27, Name = "Agami", ArabicName = "العجمي", Latitude = 31.1036m, Longitude = 29.7606m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 220, GovernorateId = 27, Name = "Borg El Arab", ArabicName = "برج العرب", Latitude = 30.9177m, Longitude = 29.5195m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 221, GovernorateId = 27, Name = "Smouha", ArabicName = "سموحة", Latitude = 31.2100m, Longitude = 29.9400m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 222, GovernorateId = 27, Name = "Sidi Gaber", ArabicName = "سيدي جابر", Latitude = 31.2156m, Longitude = 29.9553m, CreatedAt = now, UpdatedAt = now },
                new City { Id = 223, GovernorateId = 27, Name = "Stanley", ArabicName = "ستانلي", Latitude = 31.2358m, Longitude = 29.9662m, CreatedAt = now, UpdatedAt = now },

            };

            modelBuilder.Entity<City>().HasData(cities);
        }
    }
}
