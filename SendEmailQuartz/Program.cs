using Quartz;
using Quartz.AspNetCore;
using SendEmailQuartz.Jobs;
using SendEmailQuartz.Service;

var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddScoped<ISomeService, SomeService>();

builder.Services.AddQuartz(q =>
{
    // Just use the name of your job that you created in the Jobs folder.
    var jobKey = new JobKey("SendEmailJob");
    q.AddJob<SendEmailJob>(opts => opts.WithIdentity(jobKey));
    q.UseMicrosoftDependencyInjectionJobFactory();
    q.AddTrigger(opts => opts
        .ForJob(jobKey)
        .WithIdentity("SendEmailJob-trigger")
        .WithSimpleSchedule(s=> s.WithInterval(TimeSpan.FromSeconds(1)).WithRepeatCount(19))
    );
});
builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
