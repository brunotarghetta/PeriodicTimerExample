namespace SendEmailQuartz.Service
{
    public class SomeService : ISomeService
    {
        public async Task DoSomeServiceWork()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"{DateTime.Now.ToString()} SomeService");
            });
        }
    }
}
