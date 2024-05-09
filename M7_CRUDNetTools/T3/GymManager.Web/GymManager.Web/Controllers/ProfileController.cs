using GymManager.ApplicationServices.Members;
using GymManager.Web.Accounts.Dto;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileAppService _profileAppService;

        public ProfileController(IProfileAppService profileAppService)
        {
            _profileAppService = profileAppService;
        }

        //[HttpGet]
        //public async Task<IEnumerable<ProfileDto> Get()
        //{
        //    List<ProfileDto> profilees = await _profileAppService.GetProfilesAsync();
        //    return profilees;
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
