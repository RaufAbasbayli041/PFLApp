using Microsoft.Extensions.DependencyInjection;
using PFLApp.BLL.Service.Implementation;
using PFLApp.BLL.Service.Interface;
using PFLApp.BLL.Service.Repository;

namespace PFLApp.BLL.Extensions
{
    public static class CustomService
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            services.AddScoped<IStadionService, StadionService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IMatchService, MatchService>();


        }

    }
}
