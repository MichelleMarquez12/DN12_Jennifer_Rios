using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypesAppService _membershipTypesAppService;

        public MembershipTypesController(IMembershipTypesAppService membershipTypesAppService)
        {
            _membershipTypesAppService = membershipTypesAppService;
        }

        public async Task<IActionResult> Index()
        {
            List<MembershipTypes> membershipTypes = await _membershipTypesAppService.GetMembershipTypesAsync();
            MembershipTypesListViewModel viewModel = new MembershipTypesListViewModel();
            viewModel.NewMembershipTypesCount = 2;
            viewModel.MembershipTypess = membershipTypes;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int membershipTypesId)
        {
            MembershipTypes membershipTypes = await _membershipTypesAppService.GetMembershipTypesAsync(membershipTypesId);
            MembershipTypesListViewModel viewModel = new MembershipTypesListViewModel();
            return View(membershipTypes);
        }

        public async Task<IActionResult> Delete(int membershipTypesId)
        {
            await _membershipTypesAppService.DeleteMembershipTypesAsync(membershipTypesId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(MembershipTypes membershipTypes)
        {
            await _membershipTypesAppService.AddMembershipTypesAsync(membershipTypes);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MembershipTypes membershipTypes)
        {
            await _membershipTypesAppService.EditMembershipTypesAsync(membershipTypes);
            return RedirectToAction("Index");
        }
    }
}
