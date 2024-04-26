using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Example.WebApi.Controllers
{
    public class VehiclesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
