using System.Reflection;
using PrimeraAPI.OpenApiExamples;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger/OpenAPI with XML comments and examples
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddScoped<IPersonaRepositorio, PersonaRepositorio>();
builder.Services.AddScoped<IPersonaServicio, PersonaServicio>();



var app = builder.Build();

app.UseMiddleware<PrimeraAPI.Middleware.ExceptionHandlingMiddleware>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
