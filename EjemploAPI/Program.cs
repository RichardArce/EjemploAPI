using System.Reflection;
using System.IO;
using MiPrimeraAPI.BLL.Persona;
using MiPrimeraAPI.DAL.Personas;
using PrimeraAPI.OpenApiExamples;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger/OpenAPI with XML comments and examples
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "EjemploAPI", Version = "v1" });

    // Include XML comments (si generas el XML desde las opciones del proyecto)
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    if (File.Exists(xmlPath))
    {
        c.IncludeXmlComments(xmlPath);
    }

    // Enable examples filter
    c.ExampleFilters();
});

// Register the example providers from the assembly that contains PersonaExample
builder.Services.AddSwaggerExamplesFromAssemblyOf<PersonaExample>();

builder.Services.AddScoped<IPersonaRepositorio, PersonaRepositorio>();
builder.Services.AddScoped<IPersonaServicio, PersonaServicio>();

var app = builder.Build();

app.UseMiddleware<PrimeraAPI.Middleware.ExceptionHandlingMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "EjemploAPI v1");
        // c.RoutePrefix = string.Empty; // Descomenta si quieres que Swagger UI esté en la raíz (/)
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
