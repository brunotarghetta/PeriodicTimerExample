
namespace SampleTask.ScheduleTasks
{
    public class SampleTask1 : ScheduledProcessor
    {
        //private readonly PeriodicTimer _timer = new(TimeSpan.FromMilliseconds(1000));
        public SampleTask1(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
            _timer = new(TimeSpan.FromMilliseconds(1000));
        }
        public override async Task ProcessInScope(IServiceProvider scopeServiceProvider)
        {
            Console.WriteLine("SampleTask1 : " + DateTime.Now.ToString());

            await Task.Run(() =>
            {
                return Task.CompletedTask;
            });
        }
    }
}
