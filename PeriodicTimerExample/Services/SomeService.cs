namespace PeriodicTimerExample.Service
{
    public class SomeService : ISomeService
    {
        private ISomeNewService _someNewService;

        public SomeService(ISomeNewService someNewService)
        {
                _someNewService = someNewService;
        }

        public async Task DoSomeServiceWork()
        {
            await Task.Run(() =>
            {
                _someNewService.DoSomeNewServiceWork();

                Console.WriteLine($"{DateTime.Now.ToString()} SomeService");
            });
        }
    }
}
