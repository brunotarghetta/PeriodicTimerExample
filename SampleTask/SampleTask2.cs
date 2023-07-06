using SampleTask.Service;

namespace SampleTask
{
    public class SampleTask2 : ScheduledProcessor
    {
        public SampleTask2(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {

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
