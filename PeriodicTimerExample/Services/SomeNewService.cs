namespace PeriodicTimerExample.Service
{
    public class SomeNewService : ISomeNewService
    {
        public async Task DoSomeNewServiceWork()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"{DateTime.Now.ToString()} SomeNewService");
            });
        }
    }
}
