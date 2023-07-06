using SampleTask.ScheduleTasks;
using SampleTask.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IReportGenerator, ReportGenerator>();

//AddHostedService
builder.Services.AddHostedService<SampleTask1>();
builder.Services.AddHostedService<SampleTask2>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


