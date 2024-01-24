

using Onion.Respository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<OnionDBContext>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
    config.EnableSensitiveDataLogging();
});
builder.Services.Configure<IdentityOptions>(options => {

    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
});
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

