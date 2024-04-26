using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Example.WebApi.Controllers
{
    public class ErrosController : Controller
    {
        private readonly ILogger _logger;
        public ErrosController(ILogger<ErrosController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [Route("/error-development")]
        public IActionResult HandleErrorDevelopment([FromServices] IHostEnvironment hostEnvironment)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                return NotFound();
            }

            var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>()!;
            _logger.LogError(exceptionHandlerFeature.Error, "Unhandler Exception");

            return Problem(
                detail: exceptionHandlerFeature.Error.StackTrace, 
                title: exceptionHandlerFeature.Error.Message);
        }

        [Route("/error")]
        public IActionResult HandleError()
        {
            var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>()!;
            _logger.LogError(exceptionHandlerFeature.Error, "Unhandler Exception");

            return Problem();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
