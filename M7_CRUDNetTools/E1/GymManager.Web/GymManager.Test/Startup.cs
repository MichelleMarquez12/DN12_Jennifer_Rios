using GymManager.Accounts.Dto;
using GymManager.ApplicationServices;
using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Navigation;
using GymManager.Core.Members;
using GymManager.DataAccess;
using GymManager.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.UnitTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();


            services.AddDbContext<GymManagerContext>(options => options.UseInMemoryDatabase("DataTest"));

            services.AddTransient<IMembersAppService, MembersAppService>();
            services.AddTransient<IMembershipTypesAppService, MembershipTypesAppService>();
            services.AddTransient<IEquipamentTypeAppService, EquipamentTypeAppService>();
            services.AddTransient<IStaffAttendanceAppService, StaffAttendanceAppService>();
            
            services.AddTransient<IMenuAppService, MenuAppService>();
            services.AddAutoMapper(typeof(MapperProfile));

            services.AddTransient<IRepository<int, MemberDto>, Repository<int, MemberDto>>();
            services.AddTransient<IRepository<int, MembershipTypes>, Repository<int, MembershipTypes>>();
            services.AddTransient<IRepository<int, EquipamentType>, Repository<int, EquipamentType>>();
            services.AddTransient<IRepository<int, StaffAttendance>, Repository<int, StaffAttendance>>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
