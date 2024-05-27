using GymManager.Accounts.Dto;
using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypesAppService _membershipTypesAppService;

        public MembershipTypesController(IMembershipTypesAppService membershipTypesAppService)
        {
            _membershipTypesAppService = membershipTypesAppService;
        }

        public async Task<IActionResult> Index()
        {
            List<MembershipTypesDto> membershipTypes = await _membershipTypesAppService.GetMembershipTypesAsync();
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
            MembershipTypesDto membershipTypes = await _membershipTypesAppService.GetMembershipTypesAsync(membershipTypesId);
            MembershipTypesListViewModel viewModel = new MembershipTypesListViewModel();
            return View(membershipTypes);
        }

        public async Task<IActionResult> Delete(int membershipTypesId)
        {
            await _membershipTypesAppService.DeleteMembershipTypesAsync(membershipTypesId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(MembershipTypesDto membershipTypes)
        {
            await _membershipTypesAppService.AddMembershipTypesAsync(membershipTypes);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MembershipTypesDto membershipTypes)
        {
            await _membershipTypesAppService.EditMembershipTypesAsync(membershipTypes);
            return RedirectToAction("Index");
        }
    }
}
