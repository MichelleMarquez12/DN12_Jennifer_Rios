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

namespace GymManager.Test
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

            services.AddTransient<IMenuAppService, MenuAppService>();

            services.AddTransient<IRepository<int, Member>, Repository<int, Member>>();
            services.AddTransient<IRepository<int, MembershipTypes>, Repository<int, MembershipTypes>>();
            services.AddTransient<IRepository<int, EquipamentType>, Repository<int, EquipamentType>>();

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
