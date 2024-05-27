using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web.Controllers
{
    public class StaffAttendanceController : Controller
    {
        private readonly IStaffAttendanceAppService _staffAttendanceAppService;
        public StaffAttendanceController(IStaffAttendanceAppService staffAttendanceAppService) 
        {
            _staffAttendanceAppService = staffAttendanceAppService;
        }

        public IActionResult MemberIn()
        {
            return View();
        }

        public IActionResult MemberOut()
        {
            return View();
        }

        //public async Task<IActionResult> GenerateAttendance()
        //{
        //    List<StaffAttendance> Staffattendance = await _staffAttendanceAppService.GetAttendanceeAsync();
        //    StaffAttendanceListViewModel viewModel = new StaffAttendanceListViewModel();

        //    viewModel.NewStaffAttendanceCount = 2;
        //    viewModel.Staffattendance = Staffattendance;

        //    return View(viewModel);
        //}

        //public async Task< IActionResult> Print()
        //{
        //    return await _generatePdf.GetPdf("/Views/Attendance/Print.cshtml");
        //}
    }
}
