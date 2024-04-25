using GymManager.Core.Members;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class StaffAttendanceAppService : IStaffAttendanceAppService
    {
        private readonly IRepository<int, StaffAttendance> _repository;
        public StaffAttendanceAppService(IRepository<int, StaffAttendance> repository) 
        {
            _repository = repository;
        }

        public async Task<List<StaffAttendance>> GetLastWeekAsync()
        {
            var startDate = DateTime.Today.AddDays(-6);

            var LastWeekMembers = await _repository.GetAll()
                .Where(e => e.DateTime >= startDate)
                .OrderByDescending(e => e.DateTime)
                .Include(m => m.Member)
                .ToListAsync();

            return LastWeekMembers;
        }
        
        public async Task<List<(StaffAttendance, int)>> GetAttendancesAsync()
        {
            var startDate = DateTime.Today.AddDays(-30);

            var topMembers = await _repository.GetAll()
                .Where(e => e.DateTime >= startDate)
                .Include(e => e.Member)
                .GroupBy(e => new { e.Name, e.LastName })
                .Select(g => new
                {
                    StaffAttendance = g.FirstOrDefault(),
                    EntryCount = g.Count()
                })
                .OrderByDescending(x => x.EntryCount)
                .Take(20)
                .ToListAsync();

            return topMembers.Select(x => (x.StaffAttendance, x.EntryCount)).ToList();
        }

        //public async Task<List<StaffAttendance>> GetAttendanceAsync()
        //{
        //    return await _repository.GetAll().ToListAsync();
        //}

        //public async Task<StaffAttendance> GetAttendanceeAsync(int staffattendanceId)
        //{
        //    return await _repository.GetAsync(staffattendanceId);
        //}
    }
}
