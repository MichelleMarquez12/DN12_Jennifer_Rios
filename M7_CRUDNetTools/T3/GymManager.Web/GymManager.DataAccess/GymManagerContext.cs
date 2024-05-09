using GymManager.Core.Members;
using GymManager.Web.Accounts.Dto;
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
        //public DbSet<Member> Members { get; set; }
        public DbSet<MemberDto> Members { get; set; }
        public DbSet<MembershipTypes> MembershipTypes { get; set; }
		public DbSet<EquipamentType> EquipamentType { get; set; }
        public GymManagerContext(DbContextOptions<GymManagerContext> options) : base(options) 
		{ 

		}
	}
}
