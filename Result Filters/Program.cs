using Result_Filters.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.Filters.Add<EnvelopeResultFilter>();
});

var app = builder.Build();

app.MapControllers();

app.Run();

