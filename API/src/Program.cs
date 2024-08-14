using Carter;
using D4C_API.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApiVersioning()
    .AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "Version 1",
        Title = "D4C-API V1"
    });

    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "Version 2",
        Title = "D4C-API V2"
    });

    options.SwaggerDoc("v3", new OpenApiInfo
    {
        Version = "Version 3",
        Title = "D4C-API V3"
    });
});

builder.Services.AddCarter();

builder.Services.AddTransient<ProductService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options => {
    options.SwaggerEndpoint(
            $"/swagger/v1/swagger.json", "v1");

    options.SwaggerEndpoint(
            $"/swagger/v2/swagger.json", "v2");

    options.SwaggerEndpoint(
            $"/swagger/v3/swagger.json", "v3");
});

app.UseHttpsRedirection();

app.MapCarter();

await app.RunAsync();