using ApiSample.Configuration;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer()
    .AddApiConfiguration(builder.Configuration)
    .ResolveDependences()
    .AddSwaggerConfiguration();

var app = builder.Build();

app.UseSwaggerConfiguration(app.Services.GetRequiredService<IApiVersionDescriptionProvider>())
    .AddApiConfiguration(app.Environment)
    .SeedInitialData();

app.Run();
