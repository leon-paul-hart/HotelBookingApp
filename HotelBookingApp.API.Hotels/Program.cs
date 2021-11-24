using HotelBookingApp.API.Hotels.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using System.Reflection;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RoomContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RoomContext")));

builder.Services.AddDbContext<HotelContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("HotelContext")));

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1.0",
        Title = "Hotel and Room management API",
        Description = "An ASP.NET 6 Web API for managing Hotels and their Rooms",
    });

    string? xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();