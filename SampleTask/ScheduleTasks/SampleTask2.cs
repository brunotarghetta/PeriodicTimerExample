using SampleTask.Service;

namespace SampleTask.ScheduleTasks
{
    public class SampleTask2 : ScheduledProcessor
    {
        public SampleTask2(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
            _timer = new(TimeSpan.FromMilliseconds(3000));
        }

        public override Task ProcessInScope(IServiceProvider scopeServiceProvider)
        {
            Console.WriteLine("SampleTask2 : " + DateTime.Now.ToString());

            IReportGenerator reportGenerator = scopeServiceProvider.GetRequiredService<IReportGenerator>();
            reportGenerator.GenerateDailyReportAsync();

            return Task.CompletedTask;
        }
    }
}
