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

        public IActionResult Index()
        {
            List<MembershipTypes> membershipTypes = _membershipTypesAppService.GetMembershipTypes();
            MembershipTypesListViewModel viewModel = new MembershipTypesListViewModel();
            viewModel.NewMembershipTypesCount = 2;
            viewModel.MembershipTypess = membershipTypes;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int membershipTypesId)
        {
            MembershipTypes membershipTypes = _membershipTypesAppService.GetMembershipTypes(membershipTypesId);
            MembershipTypesListViewModel viewModel = new MembershipTypesListViewModel();
            return View(membershipTypes);
        }

        public IActionResult Delete(int membershipTypesId)
        {
            _membershipTypesAppService.DeleteMembershipTypes(membershipTypesId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(MembershipTypes membershipTypes)
        {
            _membershipTypesAppService.AddMembershipTypes(membershipTypes);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(MembershipTypes membershipTypes)
        {
            _membershipTypesAppService.EditMembershipTypes(membershipTypes);
            return RedirectToAction("Index");
        }
    }
}
