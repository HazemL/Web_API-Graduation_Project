
using BusinessLogic.Interface;
using BusinessLogic.Interfaces;
using BusinessLogic.Mappers;
using BusinessLogic.Repository;
using BusinessLogic.Security;
using BusinessLogic.Service;
using BusinessLogic.Services;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;



namespace Sanay3yMasr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //servuecs auth
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<JwtTokenGenerator>();
            
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
            options.TokenValidationParameters = new()
            {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
            };
            });

            builder.Services.AddAuthorization();
         


            builder.Services.AddControllers();
            //// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            //builder.Services.AddOpenApi();
            //inject DB ==> register connection string
            builder.Services.AddDbContext<Context>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("CS"),
                    sql => sql.MigrationsAssembly("Sanay3yMasr")


            ));
            /*==================================================
             * To Register services and inject repository to using to solve DI
             
             ====================================================
             */




           // ????????????????????????/
            builder.Services.AddScoped(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));

            

           
          
            
            builder.Services.AddScoped<CityService>();
          
            //Auto mapper  لكل الملفات 
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //register User
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IGeneralRepository<User>, GeneralRepository<User>>();

            //register payment
            builder.Services.AddScoped<IPaymentService, PaymentService>();
            builder.Services.AddScoped<IGeneralRepository<Payment>, PaymentRepository>();

            //register craftman

            builder.Services.AddScoped<ICraftsmanService, CraftsmanService>();
            builder.Services.AddScoped<IGeneralRepository<Craftsman>, CraftsmanRepository>();

            //register city

            builder.Services.AddScoped<ICityService, CityService>();
            builder.Services.AddScoped<IGeneralRepository<City>, CityRepository>();


            //register Subscription
            builder.Services.AddScoped<ISubscriptionService, SubscriptionService>();
            builder.Services.AddScoped<IGeneralRepository<CraftsmanSubscription>, CraftsmanSubscriptionRepository>();

            //register Skill
            builder.Services.AddScoped<ISkillService, SkillService>();
            builder.Services.AddScoped<IGeneralRepository<Skill>, SkillRepository>();

            //register Gallery
            builder.Services.AddScoped<IGalleryService, GalleryService>();
            builder.Services.AddScoped<IGeneralRepository<Gallery>, GalleryRepository>();

            //register Profession
            builder.Services.AddScoped<IProfessionService, ProfessionService>();
            builder.Services.AddScoped<IGeneralRepository<Profession>, ProfessionRepository>();

            //register Governorate
            builder.Services.AddScoped<IGovernorateService, GovernorateService>();
            builder.Services.AddScoped<IGeneralRepository<Governorate>, GovernorateRepository>();


            //register CraftsmanSkill
            builder.Services.AddScoped<ICraftsmanSkillService, CraftsmanSkillService>();
            builder.Services.AddScoped<IGeneralRepository<CraftsmanSkill>, CraftsmanSkillRepository>();

            //register CraftsmanCity
            builder.Services.AddScoped<ICraftsmanCityService, CraftsmanCityService>();
            builder.Services.AddScoped<IGeneralRepository<CraftsmanCity>, CraftsmanCityRepository>();

            //register Review
            builder.Services.AddScoped<IGeneralRepository<Review>, ReviewRepository>();
            builder.Services.AddScoped<IReviewService, ReviewService>();

            //register Report
            builder.Services.AddScoped<IReportService, ReportService>();

            //register SubscriptionPlan
            builder.Services.AddScoped<ISubscriptionPlanService, SubscriptionPlanService>();
            builder.Services.AddScoped<IGeneralRepository<SubscriptionPlan>, GeneralRepository<SubscriptionPlan>>();





            //=======================================
            //To Run Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
            c.SwaggerDoc("v1", new()
            {
            Title = "Sanay3yMasr API",
            Version = "v1"
            });

            // 🔐 تعريف JWT
            c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
            Name = "Authorization",
            Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
            Scheme = "bearer",
            BearerFormat = "JWT",
            In = Microsoft.OpenApi.Models.ParameterLocation.Header,
            Description = "اكتب: Bearer + space + token"
            });

            // 🔐 تطبيقه على كل الـ Endpoints
            c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
            {
            {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
            Reference = new Microsoft.OpenApi.Models.OpenApiReference
            {
            Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
            Id = "Bearer"
            }
            },
            Array.Empty<string>()
            }
            });
            });




            var app = builder.Build();

           
            if (app.Environment.IsDevelopment())
            {

                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapGet("/", () => Results.Redirect("swagger/index.html"));
            app.MapControllers();

            app.Run();
        }
    }

   
}
