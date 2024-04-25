using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Navigation;
using GymManager.Core.Members;
using GymManager.DataAccess;
using GymManager.DataAccess.Repositories;
using GymManager.Web.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Context;
using System.Globalization;
using System.Reflection;
using Wkhtmltopdf.NetCore;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<GymManagerContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), mySqlOptions =>
            {
                mySqlOptions.EnableRetryOnFailure();
            }));

            //builder.Services.AddDbContext<GymManagerContext>(options =>
            //options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<GymManagerContext>()
            .AddUserStore<UserStore<IdentityUser, IdentityRole, GymManagerContext>>();

            builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Login");
            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
            });
            // Agregar los servicios requeridos
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            builder.Services.AddTransient<IMembersAppService, MembersAppService>();
            builder.Services.AddTransient<IMembershipTypesAppService, MembershipTypesAppService>();
            builder.Services.AddTransient<IEquipamentTypeAppService, EquipamentTypeAppService>();
            builder.Services.AddTransient<IStaffAttendanceAppService, StaffAttendanceAppService>();

            builder.Services.AddTransient<IMenuAppService, MenuAppService>();

            builder.Services.AddTransient<IRepository<int, Member>, Repository<int, Member>>();
            builder.Services.AddTransient<IRepository<int, MembershipTypes>, Repository<int, MembershipTypes>>();
            builder.Services.AddTransient<IRepository<int, EquipamentType>, Repository<int, EquipamentType>>();
            builder.Services.AddTransient<IRepository<int, StaffAttendance>, Repository<int, StaffAttendance>>();
            builder.Services.AddWkhtmltopdf();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File(@"C:\Users\marqu\source\repos\DN12_Jennifer_Rios\M3_NetProjectsWebApi\E4\GymManager.Web\GymManager.Web\Logs\SerilogFile.txt")
                .CreateLogger();

            // Resto de la configuración del servidor y la aplicación

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });


            app.MapRazorPages();
            app.UseStaticFiles();

            app.Run();
        }
    }
}