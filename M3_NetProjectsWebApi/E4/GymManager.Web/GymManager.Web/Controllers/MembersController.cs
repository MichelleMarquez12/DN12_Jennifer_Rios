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

        public IActionResult Index()
        {
            
            List<Member> members  = _membersAppService.GetMembers();

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

        public IActionResult Edit(int memberId)
        {
            Member member = _membersAppService.GetMember(memberId);

            MemberListViewModel viewModel = new MemberListViewModel();

            return View(member);
        }


        public IActionResult Delete(int memberId)
        {
            _membersAppService.DeleteMember(memberId);
            return RedirectToAction("Index");
        }

        [HttpPost]
		public IActionResult Create(Member member)
		{
            _membersAppService.AddMember(member);
			return RedirectToAction("Index");
		}

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            _membersAppService.EditMember(member);
            return RedirectToAction("Index");
        }
    }
}
