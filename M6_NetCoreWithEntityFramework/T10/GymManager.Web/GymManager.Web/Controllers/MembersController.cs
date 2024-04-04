using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class MembersController : Controller
    {
        private readonly IMembersAppService _membersAppService;

        public MembersController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;

        }

        public async Task<IActionResult> Index()
        {
            
            List<Member> members  = await _membersAppService.GetMembersAsync();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            Log.Information("User executed Member's Index");

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int memberId)
        {
            Member member = await _membersAppService.GetMemberAsync(memberId);

            MemberListViewModel viewModel = new MemberListViewModel();

            return View(member);
        }


        public async Task<IActionResult> Delete(int memberId)
        {
            await _membersAppService.DeleteMemberAsync(memberId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Member member)
		{
            await _membersAppService.AddMemberAsync(member);
			return RedirectToAction("Index");
		}

        [HttpPost]
        public async Task<IActionResult> Edit(Member member)
        {
            await _membersAppService.EditMemberAsync(member);
            return RedirectToAction("Index");
        }
    }
}
