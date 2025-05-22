using Microsoft.EntityFrameworkCore;
using Projeto.Adapters.PostgreSQL.Database.Context;

namespace Projeto.Ports.Startup.Settings
{
    public static class DatabaseConnections
    {
        public static IServiceCollection AddLocalDbConnection(this IServiceCollection services, IConfiguration configuration)
        {
            string? localConnectionString = configuration.GetConnectionString("Local");
            
            services.AddDbContext<ProjetoContext>(
                options =>
                    options.UseNpgsql(localConnectionString)
            );

            return services;
        }
    }
}