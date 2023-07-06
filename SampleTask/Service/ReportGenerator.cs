namespace SampleTask.Service
{
    public class ReportGenerator : IReportGenerator
    {
        public ReportGenerator()
        {

        }

        public void GenerateDailyReport()
        {
            Console.WriteLine($"{DateTime.Now.ToString()} GenerateDailyReport");
        }

        public async Task GenerateDailyReportAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"{DateTime.Now.ToString()} GenerateDailyReportAsync");
            });
        }
    }
}
