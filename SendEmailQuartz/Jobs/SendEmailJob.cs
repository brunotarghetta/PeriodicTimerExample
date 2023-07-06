using Quartz;
using SendEmailQuartz.Service;

namespace SendEmailQuartz.Jobs
{
    public class SendEmailJob : IJob
    {
        private ISomeService _someService;

        public SendEmailJob(ISomeService someService)
        {
            _someService = someService;
        }
        public Task Execute(IJobExecutionContext context)
        {
            _someService.DoSomeServiceWork();

            return Task.Run(() =>
            {
                Console.WriteLine($"{DateTime.Now.ToString()} SendEmailJob");
            });
        }
    }
}
