
using Resource_Filters.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.Filters.Add<TenantValidationFilter>();
});

var app = builder.Build();

app.MapControllers();

app.Run();

