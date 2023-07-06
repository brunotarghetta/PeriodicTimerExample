//using Quartz.AspNetCore;
//using Quartz;
//using System.Reflection;

//namespace SendEmailQuartz.Extensions
//{
//    public static IServiceCollection AddLocalQuartz(this IServiceCollection services, IConfiguration config)
//    {
//        services.AddQuartz(q =>
//        {
//            // base Quartz scheduler, job and trigger configuration
//        });

//        // ASP.NET Core hosting
//        services.AddQuartzServer(options =>
//        {
//            // when shutting down we want jobs to complete gracefully
//            options.WaitForJobsToComplete = true;
//        });

//        return services;
//    }
//}
