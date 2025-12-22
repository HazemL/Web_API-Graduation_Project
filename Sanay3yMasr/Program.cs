
using BusinessLogic.Interface;
using BusinessLogic.Mappers;
using BusinessLogic.Repository;
using BusinessLogic.Security;
using BusinessLogic.Service;
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
            builder.Services.AddScoped(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));

            builder.Services.AddScoped<ICityRepository, CityRepository>();

            builder.Services.AddScoped<CraftsmanService>();
            builder.Services.AddScoped<ProfessionsService>();
            builder.Services.AddScoped<SkillsService>();
            builder.Services.AddScoped<CityService>();
            //Auto mapper 
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddAutoMapper(typeof(CityProfile));
            builder.Services.AddAutoMapper(typeof(CraftsmanProfile));
            builder.Services.AddAutoMapper(typeof(SkillProfile));
            builder.Services.AddAutoMapper(typeof(ProfessionProfile));

            //register payment
          
            builder.Services.AddScoped<IPaymentService, PaymentService>();
            //register Subscription
            builder.Services.AddScoped<ISubscriptionService, SubscriptionService>();
           
            //register CraftsmanSkill
            builder.Services.AddScoped<ICraftsmanSkillService, CraftsmanSkillService>();

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

            //// Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.MapOpenApi();
            //}
            //using Swagger
            // Configure the HTTP request pipeline.
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
