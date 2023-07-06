namespace SampleTask
{

    public abstract class ScheduledProcessor : ScopedProcessor
    {
        protected PeriodicTimer _timer { get; set; }

        public ScheduledProcessor(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (await _timer.WaitForNextTickAsync(stoppingToken) &&
            !stoppingToken.IsCancellationRequested)
            {
                await Process();
            }
        }
    }

}
