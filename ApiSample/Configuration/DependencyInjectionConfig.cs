using ApiSample.Data.Repositories;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services;
using ApiSample.Services.Interfaces;

namespace ApiSample.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependences(this IServiceCollection services)
        {
            services.AddTransient<IAddressesRepository, AddressesRepository>();
            services.AddTransient<IBrandsRepository, BrandsRepository>();
            services.AddTransient<IClientsRepository, ClientsRepository>();
            services.AddTransient<IGroupsRepository, GroupsRepository>();
            services.AddTransient<IInvoicesRepository, InvoicesRepository>();
            services.AddTransient<IOrdersRepository, OrdersRepository>();
            services.AddTransient<IPaymentClientsRepository, PaymentClientsRepository>();
            services.AddTransient<IPaymentProvidersRepository, PaymentProvidersRepository>();
            services.AddTransient<IPricesRepository, PricesRepository>();
            services.AddTransient<IProductPricesRepository, ProductPricesRepository>();
            services.AddTransient<IProductsRepository, ProductsRepository>();
            services.AddTransient<IProvidersRepository, ProvidersRepository>();
            services.AddTransient<IUsersRepository, UsersRepository>();

            services.AddScoped<IAddressesService, AddressesService>();
            services.AddScoped<IBrandsService, BrandsService>();
            services.AddScoped<IClientsService, ClientsService>();
            services.AddScoped<IGroupsService, GroupsService>();
            services.AddScoped<IInvoicesService, InvoicesService>();
            services.AddScoped<INotifier,NotifierService>();
            services.AddScoped<IOrdersService, OrdersService>();
            services.AddScoped<IPaymentClientsService, PaymentClientsService>();
            services.AddScoped<IPaymentProvidersService, PaymentProvidersService>();
            services.AddScoped<IPricesService, PricesService>();
            services.AddScoped<IProductPricesService, ProductPricesService>();
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IProvidersService, ProvidersService>();
            services.AddScoped<IUsersService,UsersService>();

            return services;
        }
    }
}
