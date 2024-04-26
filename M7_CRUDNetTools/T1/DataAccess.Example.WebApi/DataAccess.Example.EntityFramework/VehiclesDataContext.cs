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

        public VehiclesDataContext(DbContextOptions<VehiclesDataContext> options) : base(options)
        {

        }
    }
}
