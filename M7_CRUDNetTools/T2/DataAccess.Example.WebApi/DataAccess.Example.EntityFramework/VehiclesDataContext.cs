using DataAccess.Example.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public class VehiclesDataContext : IdentityDbContext
    {
        DbSet<Vehicles> Vehicles { get; set; }

        public VehiclesDataContext(DbContextOptions<VehiclesDataContext> options) : base(options)
        {

        }
    }
}
