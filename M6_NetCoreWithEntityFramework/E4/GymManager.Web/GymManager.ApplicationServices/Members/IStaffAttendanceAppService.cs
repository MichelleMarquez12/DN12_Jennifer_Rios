using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public interface IStaffAttendanceAppService
    {
        //Task<List<StaffAttendance>> GetAttendanceAsync();

        Task<List<StaffAttendance>> GetLastWeekAsync();

        Task<List<(StaffAttendance, int)>> GetAttendancesAsync();
        //Task<StaffAttendance> GetAttendanceeAsync(int staffattendanceId);
    }
}
