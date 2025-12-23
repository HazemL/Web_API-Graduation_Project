using Microsoft.EntityFrameworkCore;
using DataAccess.Seeding;
namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // 1) Master data
            SeedGovernorates(modelBuilder);
            SeedCities(modelBuilder);
            SeedProfessions(modelBuilder);
            SeedSkills(modelBuilder);
            SeedSubscriptionPlans(modelBuilder);

            // 2) Users & profiles
            SeedUsers(modelBuilder);
            SeedCraftsmen(modelBuilder);

            // 3) Relations
            SeedCraftsmanCities(modelBuilder);
            SeedCraftsmanSkills(modelBuilder);
            SeedCraftsmanSubscriptions(modelBuilder);

            // 4) Content
            SeedGalleries(modelBuilder);

            // 5) Transactions
            SeedPayments(modelBuilder);

            // 6) Feedback & moderation
            SeedReviews(modelBuilder);
            SeedReports(modelBuilder);
        }
    }
}
