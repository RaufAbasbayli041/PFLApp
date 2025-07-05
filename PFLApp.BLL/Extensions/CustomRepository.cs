using Microsoft.Extensions.DependencyInjection;
using PFLApp.DAL.Repository.Implementation;
using PFLApp.DAL.Repository.Interface;

namespace PFLApp.BLL.Extensions
{
    public static class CustomRepository
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IStadionRepository, StadionRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IMatchRepository, MatchRepository>();


        }
    }
}
