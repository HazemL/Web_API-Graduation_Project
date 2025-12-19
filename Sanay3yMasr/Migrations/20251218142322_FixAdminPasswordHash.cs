using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sanay3yMasr.Migrations
{
    /// <inheritdoc />
    public partial class FixAdminPasswordHash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RevokedTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevokedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevokedTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DurationDays = table.Column<int>(type: "int", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProfileImage = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Role = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citys_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Craftsmens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProfessionId = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ExperienceYears = table.Column<int>(type: "int", nullable: false),
                    MinPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    VerificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craftsmens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Craftsmens_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Craftsmens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CraftsmansCity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftsmansCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CraftsmansCity_Citys_CityId",
                        column: x => x.CityId,
                        principalTable: "Citys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CraftsmansCity_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CraftsmansSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    ProficiencyLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftsmansSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CraftsmansSkills_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CraftsmansSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CraftsmanSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftsmanSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CraftsmanSubscriptions_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CraftsmanSubscriptions_SubscriptionPlans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "SubscriptionPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MediaType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galleries_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReporterUserId = table.Column<int>(type: "int", nullable: false),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_Users_ReporterUserId",
                        column: x => x.ReporterUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProviderReference = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_CraftsmanSubscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "CraftsmanSubscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "القاهرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Cairo", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "الجيزة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Giza", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "الإسكندرية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Alexandria", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "السويس", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Suez", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "بورسعيد", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Port Said", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "دمياط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Damietta", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "الدقهلية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Daqahlia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "الشرقية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sharqia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "الغربية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Gharbia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "كفر الشيخ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Kafr El Sheikh", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "البحيرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beheira", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "الفيوم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fayoum", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "بني سويف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beni Suef", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "المنيا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Minya", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "أسيوط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Asyut", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "سوهاج", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sohag", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "قنا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Qena", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "الأقصر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Luxor", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "أسوان", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Aswan", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "البحر الأحمر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Red Sea", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, "الوادي الجديد", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "New Valley", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, "مطروح", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Matrouh", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, "شمال سيناء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "North Sinai", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, "جنوب سيناء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "South Sinai", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, "الإسماعيلية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Ismailia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "فني كهرباء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Electrical installation & repair", false, "Electrician", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "سباك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Plumbing & pipe repair", false, "Plumber", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "نجار", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wood works & furniture", false, "Carpenter", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "دهان", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Interior & exterior painting", false, "Painter", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "فنى تكييف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "AC repair & maintenance", false, "AC Technician", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "عامل بلاط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tiles & flooring", false, "Tile Setter", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "عامل سقوف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roofing and waterproofing", false, "Roofer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "مفتاحجي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locks & keys services", false, "Locksmith", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "ميكانيكي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vehicle repair", false, "Mechanic", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "لحام", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Metal works & welding", false, "Welder", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "بستاني", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gardening & landscaping", false, "Gardener", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "عامل نظافة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Home & office cleaning", false, "Cleaner", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "ديكور", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Interior decoration", false, "Decorator", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "مكافحة حشرات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pest control services", false, "Pest Control", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "تركيب زجاج", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Glass & windows", false, "Glass Installer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "تلميع أرضيات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Floor polishing", false, "Floor Polisher", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "تخصص سيراميك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ceramic work", false, "Ceramic Specialist", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "مهندس تكييف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HVAC systems", false, "HVAC Engineer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "فني أجهزة منزلية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Appliance repair", false, "Home Appliance Tech", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "دهان سبراي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Spray painting", false, "Painter (Spray)", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "تمديدات كهرباء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Wiring", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "تشخيص الدوائر الكهربائية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Circuit Diagnosis", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "تركيب لوحات كهرباء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Panel Installation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "تركيب إضاءة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lighting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "تركيب مخارج كهرباء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Power Outlets", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "إصلاح مواسير", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Pipe Fixing", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "تسليك صرف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Drain Unclog", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "إصلاح حنفيات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Faucet Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "لحام", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Soldering", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "تقطيع خشب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Wood Cutting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "تصنيع خزائن", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Cabinet Making", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "إصلاح أبواب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Door Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "دهانات داخلية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Interior Painting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "دهانات خارجية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Exterior Painting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "إصلاح تكييف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "AC Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "شحن فريون تكييف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "AC Gas Recharge", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "تركيب بلاط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tile Laying", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "ملء فواصل البلاط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Grouting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "إصلاح تسريب أسطح", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Roof Leak Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "تركيب شتر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Shutter Installation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, "تركيب أقفال", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lock Installation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, "إصلاح أقفال", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lock Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, "إصلاح محركات سيارات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Car Engine Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, "إصلاح فرامل", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Brake Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, "تغيير بطارية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Battery Replacement", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, "لحام حديد", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Welding Mild Steel", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, "لحام ستانلس ستيل", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Welding Stainless", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, "تقليم حدائق", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Garden Pruning", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, "جزّ العشب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lawn Mowing", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, "غسيل بالضغط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Pressure Washing", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, "تنظيف عميق", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Deep Cleaning", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, "تركيب ورق حائط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Wallpaper Installation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, "محارة ديكورية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Decorative Plaster", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, "مكافحة النمل الأبيض", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Pest Termite", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, "مكافحة القوارض", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Pest Rodent", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, "تقطيع زجاج", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Glass Cutting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, "تركيب مرايات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Mirror Fitting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, "تلميع أرضيات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Polish Floors", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, "تلميع رخام", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Marble Polishing", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, "إصلاح سيراميك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Ceramic Fixing", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, "تمديدات تكييف مركزي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "HVAC Ductwork", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, "إصلاح ثلاجات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fridge Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, "إصلاح غسالات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Washing Machine Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, "إصلاح أفران", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Oven Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, "إصلاح ميكروويف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Microwave Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, "تركيب دش", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Satellite Installation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, "تركيب مسرح منزلي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Home Theater Setup", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, "تركيب أنظمة منزل ذكي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Smart Home Install", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, "إصلاح أسوار", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fence Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, "تنظيف مزاريب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Gutter Cleaning", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, "صيانة حمامات سباحة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Pool Maintenance", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52, "تركيب ألواح شمسية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Solar Panel Install", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53, "أنظمة تخزين طاقة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Battery Storage", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54, "تركيب عزل", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Insulation Install", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55, "تركيب كاميرات مراقبة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Security Camera Install", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 56, "أنظمة تحكم دخول", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Access Control", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 57, "إصلاح حلق باب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Door Frame Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 58, "تركيب وزرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Skirting Fix", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 59, "تجديد حمامات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Bathroom Renovation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 60, "تجديد مطابخ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Kitchen Renovation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 61, "تركيب رخام مطابخ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Countertop Install", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 62, "تقطيع بلاط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tile Cutting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 63, "فحص سباكة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Plumbing Inspection", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 64, "إصلاح بيارات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Septic Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 65, "عزل وسد فواصل", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sealing & Caulking", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 66, "إصلاح خرسانة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Concrete Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 67, "ترميم أساسات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Foundation Patch", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 68, "بناء طوب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Bricklaying", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 69, "ترميم مباني", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Masonry Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 70, "إصلاح شبابيك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Window Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 71, "تركيب ستائر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Curtain Rod", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 72, "تصليح تنجيد", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Upholstery Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 73, "تنظيف كنب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sofa Cleaning", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 74, "تنظيف مراتب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Mattress Cleaning", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 75, "تنظيف مداخن", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Chimney Sweep", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 76, "إصلاح مدافئ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fireplace Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 77, "تركيب كاشف دخان", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Smoke Alarm Install", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPlans",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DurationDays", "Features", "IsActive", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "مجاني", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Free listing (limited)", true, false, "Free", 0m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "أساسي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "Standard listing + contact", true, false, "Basic", 50m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "مميز", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "Featured listing + top search", true, false, "Premium", 200m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "FullName", "IsActive", "IsDeleted", "PasswordHash", "Phone", "ProfileImage", "Role", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mohamednasr@gmail.com", "Mohamednasr", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000000", "default-user.png", "Admin", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@example.com", "أحمد علي", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000002", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@example.com", "محمد حسن", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000003", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user4@example.com", "محمود إبراهيم", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000004", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user5@example.com", "عبدالله محمود", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000005", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user6@example.com", "عمر سامي", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000006", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user7@example.com", "كريم صلاح", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000007", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user8@example.com", "سارة محمد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000008", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user9@example.com", "نور مصطفى", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000009", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user10@example.com", "هند أحمد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000010", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user11@example.com", "ليلى صلاح", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000011", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user12@example.com", "منى علي", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000012", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user13@example.com", "إيهاب سعيد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000013", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user14@example.com", "مروة سمير", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000014", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user15@example.com", "طارق حسن", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000015", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user16@example.com", "علي فؤاد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000016", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user17@example.com", "يوسف أحمد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000017", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user18@example.com", "عائشة محمود", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000018", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user19@example.com", "مريم علي", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000019", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user20@example.com", "خالد محمد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000020", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user21@example.com", "إبراهيم حسن", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000021", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user22@example.com", "علياء عمر", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000022", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user23@example.com", "نوران خالد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000023", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user24@example.com", "سعد محمود", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000024", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user25@example.com", "راغب سمير", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000025", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user26@example.com", "إيمان أيمن", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000026", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user27@example.com", "ريم أحمد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000027", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user28@example.com", "هشام فتحي", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000028", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user29@example.com", "سامي ياسر", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000029", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user30@example.com", "أمل محمود", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000030", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user31@example.com", "شهد علي", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000031", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user32@example.com", "إيناس سامي", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000032", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user33@example.com", "مصطفى جمال", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000033", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user34@example.com", "حسن يوسف", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000034", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user35@example.com", "نبيل عبدالعزيز", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000035", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user36@example.com", "شيماء إبراهيم", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000036", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user37@example.com", "دنيا حسني", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000037", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user38@example.com", "هالة سمير", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000038", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user39@example.com", "رنا خالد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000039", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user40@example.com", "نوح أحمد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000040", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user41@example.com", "آدم علي", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000041", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user42@example.com", "ملاك حسن", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000042", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user43@example.com", "زينة محمود", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000043", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user44@example.com", "تامر إيهاب", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000044", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user45@example.com", "ماهر صبري", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000045", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user46@example.com", "جمال حسين", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000046", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user47@example.com", "رامي خالد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000047", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user48@example.com", "بهاء الدين محمد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000048", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user49@example.com", "كرم أحمد", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000049", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user50@example.com", "بلال سمير", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000050", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user51@example.com", "سلوى علي", true, false, "AQAAAAIAAYagAAAAEERqbEWm5A5WFqfzMM8F+kLtO9c+LeWAc2qN89pq5lIljckEmL/1dj5y/UMzuItRHQ==", "01000000051", "default-user.png", "Customer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "GovernorateId", "IsDeleted", "Latitude", "Longitude", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "مدينة نصر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, 30.0561m, 31.3300m, "Nasr City", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "مصر الجديدة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, 30.0917m, 31.3180m, "Heliopolis", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "المعادي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, 29.9602m, 31.2569m, "Maadi", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "الزمالك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, 30.0666m, 31.2197m, "Zamalek", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "الدقي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, 30.0386m, 31.2120m, "Dokki", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "6 أكتوبر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, 29.9773m, 30.9455m, "6th of October", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "الشيخ زايد", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, 30.0215m, 30.9886m, "Sheikh Zayed", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "سيدي جابر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, 31.2156m, 29.9553m, "Sidi Gaber", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "سموحة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, 31.2100m, 29.9400m, "Smouha", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "ستانلي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, 31.2358m, 29.9662m, "Stanley", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "المنصورة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, 31.0409m, 31.3785m, "Mansoura", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "طلخا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, 31.0524m, 31.3812m, "Talkha", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "الزقازيق", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, 30.5877m, 31.5020m, "Zagazig", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "بلبيس", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, 30.4181m, 31.5622m, "Belbeis", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "الغردقة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, false, 27.2579m, 33.8116m, "Hurghada", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "سفاجا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, false, 26.7500m, 33.9333m, "Safaga", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "مرسى علم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, false, 25.0699m, 34.8900m, "Marsa Alam", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "الأقصر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, false, 25.6872m, 32.6396m, "Luxor City", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "أسوان", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, false, 24.0889m, 32.8998m, "Aswan City", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "شرم الشيخ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, false, 27.9158m, 34.3299m, "Sharm El-Sheikh", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, "طابا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, false, 29.4920m, 34.8947m, "Taba", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Craftsmens",
                columns: new[] { "Id", "Bio", "CreatedAt", "CreatedBy", "ExperienceYears", "IsDeleted", "IsVerified", "MaxPrice", "MinPrice", "ProfessionId", "UpdatedAt", "UpdatedBy", "UserId", "VerificationDate" },
                values: new object[,]
                {
                    { 1, "Skilled professional #2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 300m, 100m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, null },
                    { 2, "Skilled professional #3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, true, 320m, 110m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Skilled professional #4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 340m, 120m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, null },
                    { 4, "Skilled professional #5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 360m, 130m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, null },
                    { 5, "Skilled professional #6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, true, 380m, 140m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Skilled professional #7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, false, 400m, 150m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, null },
                    { 7, "Skilled professional #8", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, false, 420m, 160m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, null },
                    { 8, "Skilled professional #9", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, true, 440m, 170m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Skilled professional #10", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, false, 460m, 180m, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, null },
                    { 10, "Skilled professional #11", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, false, 480m, 190m, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, null },
                    { 11, "Skilled professional #12", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, true, 500m, 200m, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Skilled professional #13", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, false, 520m, 210m, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, null },
                    { 13, "Skilled professional #14", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, false, 540m, 220m, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, null },
                    { 14, "Skilled professional #15", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, true, 560m, 230m, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Skilled professional #16", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, false, false, 580m, 240m, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, null },
                    { 16, "Skilled professional #17", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 600m, 250m, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, null },
                    { 17, "Skilled professional #18", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, true, 620m, 260m, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Skilled professional #19", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 640m, 270m, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, null },
                    { 19, "Skilled professional #20", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 660m, 280m, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, null },
                    { 20, "Skilled professional #21", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, true, 680m, 290m, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Skilled professional #22", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, false, 700m, 300m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, null },
                    { 22, "Skilled professional #23", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, false, 720m, 310m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, null },
                    { 23, "Skilled professional #24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, true, 740m, 320m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Skilled professional #25", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, false, 760m, 330m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, null },
                    { 25, "Skilled professional #26", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, false, 780m, 340m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, null },
                    { 26, "Skilled professional #27", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, true, 800m, 350m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Skilled professional #28", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, false, 820m, 360m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, null },
                    { 28, "Skilled professional #29", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, false, 840m, 370m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, null },
                    { 29, "Skilled professional #30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, true, 860m, 380m, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Skilled professional #31", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, false, false, 880m, 390m, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, null }
                });

            migrationBuilder.InsertData(
                table: "CraftsmanSubscriptions",
                columns: new[] { "Id", "CraftsmanId", "CreatedAt", "CreatedBy", "EndDate", "IsActive", "IsDeleted", "PlanId", "StartDate", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 3, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 4, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 5, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 6, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 7, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 8, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 9, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 10, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 11, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 12, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 13, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 14, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 15, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 16, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 17, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 18, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 19, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 20, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "CraftsmansCity",
                columns: new[] { "Id", "CityId", "CraftsmanId", "CreatedAt", "CreatedBy", "IsDeleted", "IsPrimary", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 6, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 3, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 4, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 8, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 5, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 6, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 10, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 7, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 8, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 12, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 9, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 10, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 14, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 11, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 12, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 16, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 13, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 14, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 18, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 15, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 16, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 20, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 17, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 18, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 2, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 19, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 20, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 4, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 1, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 2, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 6, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 3, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 4, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 8, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 5, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 6, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 10, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 7, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, 8, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, 12, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, 9, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, 10, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, 14, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "CraftsmansSkills",
                columns: new[] { "Id", "CraftsmanId", "CreatedAt", "CreatedBy", "IsDeleted", "ProficiencyLevel", "SkillId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 56, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 57, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 58, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 59, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 60, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 61, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 62, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 63, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 64, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 65, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 66, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 67, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 68, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 69, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 70, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 71, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 72, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 73, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 74, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 75, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 76, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 77, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 78, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 79, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 80, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 81, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 82, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 83, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 84, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 31, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 85, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 86, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 31, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 87, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 32, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 88, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beginner", 31, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 89, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Good", 32, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 90, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Expert", 33, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "CraftsmanId", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "MediaType", "MediaUrl", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 1", false, "Image", "/uploads/gallery/c1_1.jpg", "Work sample 1", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 1", false, "Image", "/uploads/gallery/c1_2.jpg", "Work sample 2", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 1", false, "Image", "/uploads/gallery/c1_3.jpg", "Work sample 3", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 2, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 2", false, "Image", "/uploads/gallery/c2_1.jpg", "Work sample 1", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 2, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 2", false, "Image", "/uploads/gallery/c2_2.jpg", "Work sample 2", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 2, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 2", false, "Image", "/uploads/gallery/c2_3.jpg", "Work sample 3", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 3", false, "Image", "/uploads/gallery/c3_1.jpg", "Work sample 1", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 3", false, "Image", "/uploads/gallery/c3_2.jpg", "Work sample 2", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 3", false, "Image", "/uploads/gallery/c3_3.jpg", "Work sample 3", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 4", false, "Image", "/uploads/gallery/c4_1.jpg", "Work sample 1", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 4", false, "Image", "/uploads/gallery/c4_2.jpg", "Work sample 2", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 4", false, "Image", "/uploads/gallery/c4_3.jpg", "Work sample 3", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 5", false, "Image", "/uploads/gallery/c5_1.jpg", "Work sample 1", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 5", false, "Image", "/uploads/gallery/c5_2.jpg", "Work sample 2", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 5", false, "Image", "/uploads/gallery/c5_3.jpg", "Work sample 3", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 6, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 6", false, "Image", "/uploads/gallery/c6_1.jpg", "Work sample 1", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 6, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 6", false, "Image", "/uploads/gallery/c6_2.jpg", "Work sample 2", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 6, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 6", false, "Image", "/uploads/gallery/c6_3.jpg", "Work sample 3", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 7, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 7", false, "Image", "/uploads/gallery/c7_1.jpg", "Work sample 1", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 7, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 7", false, "Image", "/uploads/gallery/c7_2.jpg", "Work sample 2", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 7, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 7", false, "Image", "/uploads/gallery/c7_3.jpg", "Work sample 3", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 8, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 8", false, "Image", "/uploads/gallery/c8_1.jpg", "Work sample 1", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 8, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 8", false, "Image", "/uploads/gallery/c8_2.jpg", "Work sample 2", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 8, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 8", false, "Image", "/uploads/gallery/c8_3.jpg", "Work sample 3", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 9, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 9", false, "Image", "/uploads/gallery/c9_1.jpg", "Work sample 1", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 9, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 9", false, "Image", "/uploads/gallery/c9_2.jpg", "Work sample 2", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 9, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 9", false, "Image", "/uploads/gallery/c9_3.jpg", "Work sample 3", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 10", false, "Image", "/uploads/gallery/c10_1.jpg", "Work sample 1", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 10", false, "Image", "/uploads/gallery/c10_2.jpg", "Work sample 2", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 10", false, "Image", "/uploads/gallery/c10_3.jpg", "Work sample 3", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 11, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 11", false, "Image", "/uploads/gallery/c11_1.jpg", "Work sample 1", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 11, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 11", false, "Image", "/uploads/gallery/c11_2.jpg", "Work sample 2", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 11, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 11", false, "Image", "/uploads/gallery/c11_3.jpg", "Work sample 3", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 12, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 12", false, "Image", "/uploads/gallery/c12_1.jpg", "Work sample 1", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 12, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 12", false, "Image", "/uploads/gallery/c12_2.jpg", "Work sample 2", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 12, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 12", false, "Image", "/uploads/gallery/c12_3.jpg", "Work sample 3", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 13, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 13", false, "Image", "/uploads/gallery/c13_1.jpg", "Work sample 1", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 13, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 13", false, "Image", "/uploads/gallery/c13_2.jpg", "Work sample 2", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 13, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 13", false, "Image", "/uploads/gallery/c13_3.jpg", "Work sample 3", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 14, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 14", false, "Image", "/uploads/gallery/c14_1.jpg", "Work sample 1", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, 14, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 14", false, "Image", "/uploads/gallery/c14_2.jpg", "Work sample 2", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, 14, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 14", false, "Image", "/uploads/gallery/c14_3.jpg", "Work sample 3", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, 15, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 15", false, "Image", "/uploads/gallery/c15_1.jpg", "Work sample 1", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, 15, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 15", false, "Image", "/uploads/gallery/c15_2.jpg", "Work sample 2", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, 15, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 15", false, "Image", "/uploads/gallery/c15_3.jpg", "Work sample 3", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, 16, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 16", false, "Image", "/uploads/gallery/c16_1.jpg", "Work sample 1", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, 16, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 16", false, "Image", "/uploads/gallery/c16_2.jpg", "Work sample 2", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, 16, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 16", false, "Image", "/uploads/gallery/c16_3.jpg", "Work sample 3", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, 17, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 17", false, "Image", "/uploads/gallery/c17_1.jpg", "Work sample 1", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, 17, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 17", false, "Image", "/uploads/gallery/c17_2.jpg", "Work sample 2", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, 17, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 17", false, "Image", "/uploads/gallery/c17_3.jpg", "Work sample 3", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52, 18, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 18", false, "Image", "/uploads/gallery/c18_1.jpg", "Work sample 1", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53, 18, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 18", false, "Image", "/uploads/gallery/c18_2.jpg", "Work sample 2", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54, 18, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 18", false, "Image", "/uploads/gallery/c18_3.jpg", "Work sample 3", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55, 19, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 19", false, "Image", "/uploads/gallery/c19_1.jpg", "Work sample 1", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 56, 19, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 19", false, "Image", "/uploads/gallery/c19_2.jpg", "Work sample 2", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 57, 19, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 19", false, "Image", "/uploads/gallery/c19_3.jpg", "Work sample 3", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 58, 20, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 20", false, "Image", "/uploads/gallery/c20_1.jpg", "Work sample 1", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 59, 20, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 20", false, "Image", "/uploads/gallery/c20_2.jpg", "Work sample 2", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 60, 20, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 20", false, "Image", "/uploads/gallery/c20_3.jpg", "Work sample 3", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 61, 21, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 21", false, "Image", "/uploads/gallery/c21_1.jpg", "Work sample 1", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 62, 21, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 21", false, "Image", "/uploads/gallery/c21_2.jpg", "Work sample 2", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 63, 21, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 21", false, "Image", "/uploads/gallery/c21_3.jpg", "Work sample 3", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 64, 22, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 22", false, "Image", "/uploads/gallery/c22_1.jpg", "Work sample 1", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 65, 22, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 22", false, "Image", "/uploads/gallery/c22_2.jpg", "Work sample 2", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 66, 22, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 22", false, "Image", "/uploads/gallery/c22_3.jpg", "Work sample 3", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 67, 23, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 23", false, "Image", "/uploads/gallery/c23_1.jpg", "Work sample 1", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 68, 23, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 23", false, "Image", "/uploads/gallery/c23_2.jpg", "Work sample 2", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 69, 23, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 23", false, "Image", "/uploads/gallery/c23_3.jpg", "Work sample 3", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 70, 24, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 24", false, "Image", "/uploads/gallery/c24_1.jpg", "Work sample 1", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 71, 24, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 24", false, "Image", "/uploads/gallery/c24_2.jpg", "Work sample 2", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 72, 24, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 24", false, "Image", "/uploads/gallery/c24_3.jpg", "Work sample 3", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 73, 25, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 25", false, "Image", "/uploads/gallery/c25_1.jpg", "Work sample 1", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 74, 25, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 25", false, "Image", "/uploads/gallery/c25_2.jpg", "Work sample 2", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 75, 25, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 25", false, "Image", "/uploads/gallery/c25_3.jpg", "Work sample 3", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 76, 26, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 26", false, "Image", "/uploads/gallery/c26_1.jpg", "Work sample 1", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 77, 26, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 26", false, "Image", "/uploads/gallery/c26_2.jpg", "Work sample 2", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 78, 26, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 26", false, "Image", "/uploads/gallery/c26_3.jpg", "Work sample 3", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 79, 27, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 27", false, "Image", "/uploads/gallery/c27_1.jpg", "Work sample 1", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 80, 27, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 27", false, "Image", "/uploads/gallery/c27_2.jpg", "Work sample 2", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 81, 27, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 27", false, "Image", "/uploads/gallery/c27_3.jpg", "Work sample 3", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 82, 28, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 28", false, "Image", "/uploads/gallery/c28_1.jpg", "Work sample 1", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 83, 28, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 28", false, "Image", "/uploads/gallery/c28_2.jpg", "Work sample 2", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 84, 28, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 28", false, "Image", "/uploads/gallery/c28_3.jpg", "Work sample 3", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 85, 29, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 29", false, "Image", "/uploads/gallery/c29_1.jpg", "Work sample 1", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 86, 29, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 29", false, "Image", "/uploads/gallery/c29_2.jpg", "Work sample 2", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 87, 29, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 29", false, "Image", "/uploads/gallery/c29_3.jpg", "Work sample 3", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 88, 30, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 30", false, "Image", "/uploads/gallery/c30_1.jpg", "Work sample 1", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 89, 30, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 30", false, "Image", "/uploads/gallery/c30_2.jpg", "Work sample 2", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 90, 30, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 30", false, "Image", "/uploads/gallery/c30_3.jpg", "Work sample 3", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "CraftsmanId", "CreatedAt", "CreatedBy", "IsDeleted", "Message", "ReporterUserId", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #1", 4, "Pending", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #2", 5, "Resolved", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #3", 6, "Resolved", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #4", 7, "Pending", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #5", 8, "Resolved", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 6, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #6", 9, "Resolved", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 7, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #7", 10, "Pending", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #8", 11, "Resolved", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 9, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #9", 12, "Resolved", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 10, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #10", 13, "Pending", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 11, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #11", 14, "Resolved", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 12, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #12", 15, "Resolved", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 13, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #13", 16, "Pending", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 14, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #14", 17, "Resolved", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 15, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #15", 18, "Resolved", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 16, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #16", 19, "Pending", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 17, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #17", 20, "Resolved", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 18, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #18", 21, "Resolved", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 19, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #19", 22, "Pending", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 20, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #20", 23, "Resolved", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 21, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #21", 24, "Resolved", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 22, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #22", 25, "Pending", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 23, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #23", 26, "Resolved", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 24, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #24", 27, "Resolved", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 25, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #25", 28, "Pending", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 26, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #26", 29, "Resolved", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 27, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #27", 30, "Resolved", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 28, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #28", 31, "Pending", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 29, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #29", 32, "Resolved", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 30, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #30", 33, "Resolved", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 1, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #31", 34, "Pending", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 2, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #32", 35, "Resolved", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #33", 36, "Resolved", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 4, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #34", 37, "Pending", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 5, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #35", 38, "Resolved", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 6, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #36", 39, "Resolved", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 7, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #37", 40, "Pending", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 8, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #38", 41, "Resolved", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 9, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #39", 42, "Resolved", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 10, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Report reason #40", 43, "Pending", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CraftsmanId", "CreatedAt", "CreatedBy", "IsDeleted", "IsVerified", "Stars", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "Review 1 for craftsman 1", 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 2, "Review 2 for craftsman 2", 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 },
                    { 3, "Review 3 for craftsman 3", 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 },
                    { 4, "Review 4 for craftsman 4", 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 },
                    { 5, "Review 5 for craftsman 5", 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5 },
                    { 6, "Review 6 for craftsman 6", 6, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6 },
                    { 7, "Review 7 for craftsman 7", 7, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7 },
                    { 8, "Review 8 for craftsman 8", 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8 },
                    { 9, "Review 9 for craftsman 9", 9, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9 },
                    { 10, "Review 10 for craftsman 10", 10, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 4, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10 },
                    { 11, "Review 11 for craftsman 11", 11, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11 },
                    { 12, "Review 12 for craftsman 12", 12, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12 },
                    { 13, "Review 13 for craftsman 13", 13, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13 },
                    { 14, "Review 14 for craftsman 14", 14, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14 },
                    { 15, "Review 15 for craftsman 15", 15, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15 },
                    { 16, "Review 16 for craftsman 16", 16, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16 },
                    { 17, "Review 17 for craftsman 17", 17, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 },
                    { 18, "Review 18 for craftsman 18", 18, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 4, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18 },
                    { 19, "Review 19 for craftsman 19", 19, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19 },
                    { 20, "Review 20 for craftsman 20", 20, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20 },
                    { 21, "Review 21 for craftsman 21", 21, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21 },
                    { 22, "Review 22 for craftsman 22", 22, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22 },
                    { 23, "Review 23 for craftsman 23", 23, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23 },
                    { 24, "Review 24 for craftsman 24", 24, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 4, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24 },
                    { 25, "Review 25 for craftsman 25", 25, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25 },
                    { 26, "Review 26 for craftsman 26", 26, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26 },
                    { 27, "Review 27 for craftsman 27", 27, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27 },
                    { 28, "Review 28 for craftsman 28", 28, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28 },
                    { 29, "Review 29 for craftsman 29", 29, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29 },
                    { 30, "Review 30 for craftsman 30", 30, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30 },
                    { 31, "Review 31 for craftsman 1", 1, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 3, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31 },
                    { 32, "Review 32 for craftsman 2", 2, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32 },
                    { 33, "Review 33 for craftsman 3", 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33 },
                    { 34, "Review 34 for craftsman 4", 4, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34 },
                    { 35, "Review 35 for craftsman 5", 5, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35 },
                    { 36, "Review 36 for craftsman 6", 6, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36 },
                    { 37, "Review 37 for craftsman 7", 7, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37 },
                    { 38, "Review 38 for craftsman 8", 8, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38 },
                    { 39, "Review 39 for craftsman 9", 9, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39 },
                    { 40, "Review 40 for craftsman 10", 10, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40 },
                    { 41, "Review 41 for craftsman 11", 11, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41 },
                    { 42, "Review 42 for craftsman 12", 12, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42 },
                    { 43, "Review 43 for craftsman 13", 13, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43 },
                    { 44, "Review 44 for craftsman 14", 14, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44 },
                    { 45, "Review 45 for craftsman 15", 15, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45 },
                    { 46, "Review 46 for craftsman 16", 16, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 5, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46 },
                    { 47, "Review 47 for craftsman 17", 17, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47 },
                    { 48, "Review 48 for craftsman 18", 18, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48 },
                    { 49, "Review 49 for craftsman 19", 19, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49 },
                    { 50, "Review 50 for craftsman 20", 20, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50 },
                    { 51, "Review 51 for craftsman 21", 21, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 52, "Review 52 for craftsman 22", 22, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 3, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 },
                    { 53, "Review 53 for craftsman 23", 23, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 },
                    { 54, "Review 54 for craftsman 24", 24, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 },
                    { 55, "Review 55 for craftsman 25", 25, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5 },
                    { 56, "Review 56 for craftsman 26", 26, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6 },
                    { 57, "Review 57 for craftsman 27", 27, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7 },
                    { 58, "Review 58 for craftsman 28", 28, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 3, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8 },
                    { 59, "Review 59 for craftsman 29", 29, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9 },
                    { 60, "Review 60 for craftsman 30", 30, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10 },
                    { 61, "Review 61 for craftsman 1", 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11 },
                    { 62, "Review 62 for craftsman 2", 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12 },
                    { 63, "Review 63 for craftsman 3", 3, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13 },
                    { 64, "Review 64 for craftsman 4", 4, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14 },
                    { 65, "Review 65 for craftsman 5", 5, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15 },
                    { 66, "Review 66 for craftsman 6", 6, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16 },
                    { 67, "Review 67 for craftsman 7", 7, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 },
                    { 68, "Review 68 for craftsman 8", 8, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 5, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18 },
                    { 69, "Review 69 for craftsman 9", 9, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19 },
                    { 70, "Review 70 for craftsman 10", 10, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20 },
                    { 71, "Review 71 for craftsman 11", 11, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21 },
                    { 72, "Review 72 for craftsman 12", 12, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22 },
                    { 73, "Review 73 for craftsman 13", 13, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23 },
                    { 74, "Review 74 for craftsman 14", 14, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24 },
                    { 75, "Review 75 for craftsman 15", 15, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25 },
                    { 76, "Review 76 for craftsman 16", 16, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26 },
                    { 77, "Review 77 for craftsman 17", 17, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27 },
                    { 78, "Review 78 for craftsman 18", 18, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28 },
                    { 79, "Review 79 for craftsman 19", 19, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 5, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29 },
                    { 80, "Review 80 for craftsman 20", 20, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30 },
                    { 81, "Review 81 for craftsman 21", 21, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31 },
                    { 82, "Review 82 for craftsman 22", 22, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32 },
                    { 83, "Review 83 for craftsman 23", 23, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33 },
                    { 84, "Review 84 for craftsman 24", 24, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34 },
                    { 85, "Review 85 for craftsman 25", 25, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 5, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35 },
                    { 86, "Review 86 for craftsman 26", 26, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36 },
                    { 87, "Review 87 for craftsman 27", 27, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37 },
                    { 88, "Review 88 for craftsman 28", 28, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38 },
                    { 89, "Review 89 for craftsman 29", 29, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39 },
                    { 90, "Review 90 for craftsman 30", 30, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 4, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40 },
                    { 91, "Review 91 for craftsman 1", 1, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41 },
                    { 92, "Review 92 for craftsman 2", 2, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42 },
                    { 93, "Review 93 for craftsman 3", 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43 },
                    { 94, "Review 94 for craftsman 4", 4, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44 },
                    { 95, "Review 95 for craftsman 5", 5, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45 },
                    { 96, "Review 96 for craftsman 6", 6, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46 },
                    { 97, "Review 97 for craftsman 7", 7, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47 },
                    { 98, "Review 98 for craftsman 8", 8, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48 },
                    { 99, "Review 99 for craftsman 9", 9, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49 },
                    { 100, "Review 100 for craftsman 10", 10, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50 },
                    { 101, "Review 101 for craftsman 11", 11, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 102, "Review 102 for craftsman 12", 12, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 },
                    { 103, "Review 103 for craftsman 13", 13, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 },
                    { 104, "Review 104 for craftsman 14", 14, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 },
                    { 105, "Review 105 for craftsman 15", 15, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5 },
                    { 106, "Review 106 for craftsman 16", 16, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6 },
                    { 107, "Review 107 for craftsman 17", 17, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7 },
                    { 108, "Review 108 for craftsman 18", 18, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8 },
                    { 109, "Review 109 for craftsman 19", 19, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9 },
                    { 110, "Review 110 for craftsman 20", 20, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10 },
                    { 111, "Review 111 for craftsman 21", 21, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11 },
                    { 112, "Review 112 for craftsman 22", 22, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12 },
                    { 113, "Review 113 for craftsman 23", 23, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13 },
                    { 114, "Review 114 for craftsman 24", 24, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14 },
                    { 115, "Review 115 for craftsman 25", 25, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15 },
                    { 116, "Review 116 for craftsman 26", 26, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 5, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16 },
                    { 117, "Review 117 for craftsman 27", 27, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, 4, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 },
                    { 118, "Review 118 for craftsman 28", 28, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18 },
                    { 119, "Review 119 for craftsman 29", 29, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19 },
                    { 120, "Review 120 for craftsman 30", 30, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, 3, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedAt", "CreatedBy", "Currency", "IsDeleted", "PaymentMethod", "ProviderReference", "Status", "SubscriptionId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 200m, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00001", "Paid", 1, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 120m, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00002", "Paid", 2, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 200m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00003", "Paid", 3, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 120m, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00004", "Paid", 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 200m, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00005", "Paid", 5, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 120m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00006", "Paid", 6, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 200m, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00007", "Paid", 7, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 120m, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00008", "Paid", 8, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 200m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00009", "Paid", 9, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 120m, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00010", "Paid", 10, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 200m, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00011", "Paid", 11, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 120m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00012", "Paid", 12, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 200m, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00013", "Paid", 13, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 120m, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00014", "Paid", 14, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 200m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00015", "Paid", 15, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 120m, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00016", "Paid", 16, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 200m, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00017", "Paid", 17, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 120m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00018", "Paid", 18, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 200m, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00019", "Paid", 19, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 120m, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00020", "Paid", 20, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citys_GovernorateId",
                table: "Citys",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansCity_CityId",
                table: "CraftsmansCity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansCity_CraftsmanId_CityId",
                table: "CraftsmansCity",
                columns: new[] { "CraftsmanId", "CityId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansSkills_CraftsmanId_SkillId",
                table: "CraftsmansSkills",
                columns: new[] { "CraftsmanId", "SkillId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansSkills_SkillId",
                table: "CraftsmansSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmanSubscriptions_CraftsmanId_IsActive",
                table: "CraftsmanSubscriptions",
                columns: new[] { "CraftsmanId", "IsActive" },
                unique: true,
                filter: "[IsActive] = 1");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmanSubscriptions_PlanId",
                table: "CraftsmanSubscriptions",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Craftsmens_ProfessionId",
                table: "Craftsmens",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Craftsmens_UserId",
                table: "Craftsmens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_CraftsmanId",
                table: "Galleries",
                column: "CraftsmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SubscriptionId",
                table: "Payments",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Professions_Name",
                table: "Professions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CraftsmanId",
                table: "Reports",
                column: "CraftsmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReporterUserId",
                table: "Reports",
                column: "ReporterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CraftsmanId",
                table: "Reviews",
                column: "CraftsmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Name",
                table: "Skills",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CraftsmansCity");

            migrationBuilder.DropTable(
                name: "CraftsmansSkills");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RevokedTokens");

            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "CraftsmanSubscriptions");

            migrationBuilder.DropTable(
                name: "Governorates");

            migrationBuilder.DropTable(
                name: "Craftsmens");

            migrationBuilder.DropTable(
                name: "SubscriptionPlans");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
