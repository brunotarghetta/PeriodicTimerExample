using Microsoft.Extensions.DependencyInjection;
using PeriodicTimerExample.Service;

namespace PeriodicTimerExample.ScheduleServices
{
    public class AnotherRepeatingService : BackgroundService
    {
        private readonly IServiceScopeFactory _factory;

        private readonly PeriodicTimer _timer = new(TimeSpan.FromMilliseconds(1000));

        public AnotherRepeatingService(IServiceScopeFactory factory)
        {
            _factory = factory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (await _timer.WaitForNextTickAsync(stoppingToken) &&
                !stoppingToken.IsCancellationRequested)
            {
                await DoWorkAsync();
            }
        }

        private async Task DoWorkAsync()
        {
            using (var scope = _factory.CreateAsyncScope())
            {
                ISomeService _someService = scope.ServiceProvider.GetRequiredService<ISomeService>();
                await _someService.DoSomeServiceWork();
                Console.WriteLine($"{DateTime.Now.ToString()} AnotherRepeatingService");
            }
        }
    }
}
