
using Microsoft.EntityFrameworkCore;
using WebMap.Data;
using WebMap.Interface;
using WebMap.Mapper;

namespace WebMap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var a = "Server=.;uid=xyzxyz;pwd=2020;Database=SchlDetailsNew; TrustServerCertificate=True";

            builder.Services.AddControllers();
            builder.Services.AddDbContext<SchoolDbContext>(options=> options.UseSqlServer(a));
            builder.Services.AddAutoMapper(typeof(SchoolProfile));
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
