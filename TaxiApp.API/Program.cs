using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Security.Cryptography.Xml;
using TaxiApp.Application.Services;
using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Repository;
using TaxiApp.Infraestructure.Data;
using TaxiApp.Infraestructure.Log;

var builder = WebApplication.CreateBuilder(args);

SerilogHelper serilogHelper = new SerilogHelper(builder.Configuration);
Log.Logger = serilogHelper.SerilogConfiguration().CreateLogger();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TaxiDbContext>(options =>
                                            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IRideRepository, RideRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IDriverRepository, DriverRepository>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IRideService, RideService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IDriverService, DriverService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ErrorLoggingMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
