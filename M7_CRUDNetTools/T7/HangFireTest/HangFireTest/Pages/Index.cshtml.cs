using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HangFireTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var jobId = BackgroundJob.Enqueue(
                () => Helper.DBHelper.Process(4000, "Proceso en cola"));

            var job2 = BackgroundJob.ContinueJobWith(jobId,
                () => Helper.DBHelper.Process(1000, "Proceso en cola 2"));

            BackgroundJob.ContinueJobWith(job2,
                () => Helper.DBHelper.Process(1000, "Proceso en cola 3"));
        }
    }
}
