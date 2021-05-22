using DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DatabaseSettings>(
                configuration.GetSection(nameof(DatabaseSettings)));

            services.AddSingleton(sp => (IDatabaseSettings)sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);

            return services;
        }
    }
}
