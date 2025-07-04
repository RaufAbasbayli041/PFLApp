using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using PFLApp.BLL.Extensions;
using PFLApp.BLL.Profiles;
using PFLApp.BLL.Validation;
using PFLApp.DAL.DataBase;

namespace PFLApp.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<PFLDBContext>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
          
           // builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();    

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
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
