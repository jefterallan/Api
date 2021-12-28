using ApiSample.Data;
using ApiSample.Data.Seed;
using Microsoft.EntityFrameworkCore;

namespace ApiSample.Configuration
{
    public static class DataConfig
    {
        public static IServiceCollection AddDataConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContext, ApiSampleContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static void SeedInitialData(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();

            using var context = serviceScope.ServiceProvider.GetService<ApiSampleContext>();

            if (context == null) return;

            context.Database.Migrate();
                        
            using var transaction = context.Database.BeginTransaction();

            try
            {
                DbInitializer.Initialize(context);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            
        }
    }
}
