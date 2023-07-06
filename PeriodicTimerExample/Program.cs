using PeriodicTimerExample.ScheduleServices;
using PeriodicTimerExample.Service;

var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddScoped<ISomeService, SomeService>();

//AddHostedService
builder.Services.AddHostedService<RepeatingService>();
builder.Services.AddHostedService<AnotherRepeatingService>();

var app = builder.Build();

app.Run();
