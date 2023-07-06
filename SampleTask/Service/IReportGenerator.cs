namespace SampleTask.Service
{
    public interface IReportGenerator
    {
        void GenerateDailyReport();

        Task GenerateDailyReportAsync();
    }
}
