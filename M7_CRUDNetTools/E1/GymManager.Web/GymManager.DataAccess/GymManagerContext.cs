using GymManager.Accounts.Dto;
using GymManager.Core.Members;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
	public class GymManagerContext : IdentityDbContext
	{
        public DbSet<MemberDto> Members { get; set; }
        public DbSet<MembershipTypesDto> MembershipTypes { get; set; }
		public DbSet<EquipamentTypeDto> EquipamentType { get; set; }
        public DbSet<StaffAttendance> Staffattendances { get; set; }
        public GymManagerContext(DbContextOptions<GymManagerContext> options) : base(options) 
		{ 

		}
	}
}
