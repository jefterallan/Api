using ApiSample.Helpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataConfiguration(configuration);
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.Configure<AppSettingsMap>(configuration);
            services.AddControllers();
            services.AddHealthChecks();
            services.AddLogging();
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            services.AddMvc(c =>
                c.Conventions.Add(new ApiExplorerGroupPerVersionConvention())
            );

            services.AddApiVersioning(opt => {
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(opt =>
            {
                opt.GroupNameFormat = "'v'V";
                opt.SubstituteApiVersionInUrl = true;
            });

            return services;
        }

        public static IApplicationBuilder AddApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            else
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapSwagger("/swagger/{documentName}/swagger.json", opt =>
                {
                    opt.PreSerializeFilters.Add((swagger, httpReq) =>
                    {
                        swagger.Servers.Clear();
                    });
                });

                endpoints.MapControllers();
                endpoints.MapHealthChecks("/api/health");
            });

            return app;
        }
    }
}
