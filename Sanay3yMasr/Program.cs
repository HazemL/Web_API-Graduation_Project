using Microsoft.Extensions.DependencyInjection;
using BusinessLogic.Interface;
using BusinessLogic.Repository;
using BusinessLogic.Repository;
using BusinessLogic.Service;
using DataAccess.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;



namespace Sanay3yMasr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
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
            
            builder.Services.AddScoped<CityService>();
            //=======================================
            //To Run Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }
            //using Swagger
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {

                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }

   
}
