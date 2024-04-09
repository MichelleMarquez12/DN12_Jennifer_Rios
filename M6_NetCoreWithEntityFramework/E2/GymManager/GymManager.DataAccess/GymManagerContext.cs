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
        public DbSet<Members> Members { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<EquipamentType> EquipamentType { get; set; }
        //public DbSet<Inventory> Inventory { get; set; }
        //public DbSet<MeasureType> MeasureType { get; set; }
        public DbSet<MembershipTypes> MembershipTypes { get; set; }
        public GymManagerContext(DbContextOptions<GymManagerContext> options) : base(options) 
		{ 

		}
    }
}
