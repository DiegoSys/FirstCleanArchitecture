using Microsoft.Extensions.Configuration;
using NorthWind.EFCore.Repositories.Repositories;

namespace NorthWind.EFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration, string connectioStringname)
        {
            services.AddDbContext<NorthWindSalesContext>(options => options.UseSqlServer(configuration.GetConnectionString(connectioStringname)));
            services.AddScoped<INorthWindSalesCommandsRepository, NortWindSalesCommandsRepositoy>();
            return services;
        }
    }
}
