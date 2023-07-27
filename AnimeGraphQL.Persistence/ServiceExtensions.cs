using AnimeGraphQL.Application.Repository;
using AnimeGraphQL.Persistence.Context;
using AnimeGraphQL.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeGraphQL.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("AnimeContext");
            services.AddDbContext<AnimeContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<ITestTakerRepository, TestTakerRepository>();
        }
    }
}
