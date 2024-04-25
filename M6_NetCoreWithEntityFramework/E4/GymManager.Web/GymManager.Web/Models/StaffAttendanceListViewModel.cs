using GymManager.Core.Members;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GymManager.Web.Models
{
    public class StaffAttendanceListViewModel
    {
        public int NewStaffAttendanceCount { get; set; }
        public List<StaffAttendance> Staffattendance { get; set; }
    }
}
