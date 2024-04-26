using DataAccess.Example.Core;
using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Example.WebApi.Controllers
{
    public class MakesController : Controller
    {
        private readonly IQueriesExample _queries;

        public MakesController(IQueriesExample queries, IWebHostBuilder env)
        {
            _queries = queries;
        }

        //[HttpGet]
        //public IEnumerable<Make> Get()
        //{
        //    var result = _queries.GetMakes();
        //    return result;
        //}

        //[HttpGet(nameof(GetByPrice))]
        //public IEnumerable<Vehicles> GetByPrice() 
        //{
        //    var result = _queries.GetVehiclesByPrice(80000,150000);
        //    return result;
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
