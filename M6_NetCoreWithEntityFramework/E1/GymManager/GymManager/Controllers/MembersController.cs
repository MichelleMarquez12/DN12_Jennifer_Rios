using GymManager.ApplicationServices.Procedures;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController : Controller
    {
        private readonly IProceduresAppService _proceduresAppService;

        public MembersController(IProceduresAppService proceduresAppService)
        {
            _proceduresAppService = proceduresAppService;
        }

        [HttpPost(nameof(Sales))]
        public async Task<IActionResult> Sales([FromBody] SalesModel model)
        {
            try
            {
                int message = await _proceduresAppService.SalesAsync(
                    model.Date,
                    model.Cantidad,
                    model.Members_idMembers,
                    model.Products_idProducts
                    );

                return Ok(message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al registrar la venta. {ex.Message}" );
            }
        }

        [HttpGet("products/{ProductType}")]
        public async Task<IActionResult> GetProducts(string ProductType)
        {
            try
            {
                List<Products> products = await _proceduresAppService.GetProductsAsync(ProductType);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener los productos. {ex.Message}");
            }
        }

        [HttpGet("members/last-week")]
        public async Task<IActionResult> GetMembers()
        {
            try
            {
                List<Members> members = await _proceduresAppService.GetMembersAsync();
                return Ok(members);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener los miembros registrados en la semana. {ex.Message}");
            }
        }

        public IActionResult Index()
        {
            return Ok();
        }
    }
}
