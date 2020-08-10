using Microsoft.Extensions.DependencyInjection;
using Seed.Infrastructure;

namespace Seed.Extensions
{
    /// <summary>
    /// Represents a collection of seed services
    /// </summary>
    public static class SeedServicesCollection
    {
        /// <summary>
        /// Configures the seed services
        /// </summary>
        /// <param name="serviceCollection">Current service collection</param>
        public static void ConfigureSeedServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
        }
    }
}