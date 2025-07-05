
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using PFLApp.BLL.Extensions;
using PFLApp.BLL.Profiles;
using PFLApp.BLL.Validation;
using PFLApp.DAL.DataBase;



namespace PFLApp.API
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
            builder.Services.AddDbContext<PFLDBContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddRepositories();
            builder.Services.AddServices();

            builder.Services.AddAutoMapper(typeof(MapProfile).Assembly);
            builder.Services.AddValidatorsFromAssemblyContaining<TeamDtoValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<StadionDtoValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<PlayerDtoValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<MatchDtoValidator>();


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
