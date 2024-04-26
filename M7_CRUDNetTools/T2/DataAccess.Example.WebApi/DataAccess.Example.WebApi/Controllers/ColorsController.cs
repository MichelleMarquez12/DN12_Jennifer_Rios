using DataAccess.Example.Core;
using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Example.WebApi.Controllers
{
    public class ColorsController : Controller
    {
        private readonly IColorsDataManager _manager;
        private readonly ILogger<ColorsController> _logger;

        public ColorsController(IColorsDataManager manager, ILogger<ColorsController> logger)
        {
            _manager = manager;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        //[HttpGet]
        //public IEnumerable<Color> Get()
        //{
        //    var colors = _manager.GetAll();

        //    _logger.LogInformation("Total colors retrieved: " + colors?.Count);

        //    return colors;
        //}

        //[HttpGet("{id}")]
        //public Color Get(int id)
        //{
        //    throw new Exception();
        //    return _manager.Get(id);
        //}
        public IActionResult Index()
        {
            return View();
        }
    }
}
