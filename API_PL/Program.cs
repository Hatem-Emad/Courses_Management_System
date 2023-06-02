
using APIDay02_BL.DTO;
using APIDay02_BL.Manage;
using APIDay02_DAL.Data.Context;
using APIDay02_DAL.Data.Models;
using APIDay02_DAL.Repo;
using Microsoft.EntityFrameworkCore;

namespace APIDay02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<MainContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("apidb")));
            
            builder.Services.AddScoped<IRepo<Instructor>, InstructorRepo>();
            builder.Services.AddScoped<IRepoBL<InstructorDTO>, InstructorRepoBL>();
            builder.Services.AddScoped<IRepo<Department>, DepRepo>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}