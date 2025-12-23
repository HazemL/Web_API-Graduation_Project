using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedPayments(ModelBuilder modelBuilder)
        {
            var payments = new List<Payment>();
            var baseDate = new DateTime(2024, 1, 1);
            int id = 1;

            // Payments for subscriptions 1..20
            for (int sub = 1; sub <= 20; sub++)
            {
                payments.Add(new Payment
                {
                    Id = id++,
                    SubscriptionId = sub,
                    Amount = (sub % 2 == 0) ? 120m : 200m,
                    Currency = "EGP",
                    PaymentMethod = (sub % 2 == 0) ? "VodafoneCash" : "CreditCard",
                    ProviderReference = $"TXN{sub:00000}",
                    Status = "Paid",

                    // ✅ BaseModel
                    IsDeleted = false,
                    CreatedAt = baseDate.AddDays(sub),
                    UpdatedAt = baseDate.AddDays(sub)
                });
            }

            modelBuilder.Entity<Payment>().HasData(payments);
        }
    }
}
