using ApiSample.Data.Repositories;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services;
using ApiSample.Services.Interfaces;
using ApiSample.Services.Notify;

namespace ApiSample.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependences(this IServiceCollection services)
        {
            //services.AddTransient<IRepository,Repository>();

            services.AddScoped<IUserService,UserService>();
            services.AddScoped<INotifier,Notifier>();

            return services;
        }
    }
}
