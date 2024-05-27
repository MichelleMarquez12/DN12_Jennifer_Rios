//using GymManager.Accounts.Dto;
//using GymManager.ApplicationServices.Members;
//using GymManager.ApplicationServices.Navigation;
//using GymManager.Core.Members;
//using GymManager.DataAccess;
//using GymManager.DataAccess.Repositories;
//using GymManager.Web.Controllers;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.AspNetCore.Localization;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Options;
//using Serilog;
//using Serilog.Context;
//using System.Globalization;
//using System.Reflection;
//using Wkhtmltopdf.NetCore;
//using AutoMapper;

//namespace Program
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);
//            var connectionString = builder.Configuration.GetConnectionString("Default");

//            builder.Services.AddDbContext<GymManagerContext>(options =>
//            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), mySqlOptions =>
//            {
//                mySqlOptions.EnableRetryOnFailure();
//            }));

//            //builder.Services.AddDbContext<GymManagerContext>(options =>
//            //options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

//            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//            .AddEntityFrameworkStores<GymManagerContext>()
//            .AddUserStore<UserStore<IdentityUser, IdentityRole, GymManagerContext>>();

//            builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Login");
//            builder.Services.Configure<IdentityOptions>(options =>
//            {
//                options.Password.RequireNonAlphanumeric = false;
//            });


//            // Agregar los servicios requeridos

//            builder.Services.AddRazorPages().AddViewLocalization();

//            //builder.Services.AddRazorPages().AddViewLocalization().AddDataAnnotationsLocalization(options =>
//            //{
//            //    options.DataAnnotationLocalizerProvider = (type, factory) =>
//            //    {
//            //        var assemblyName = new AssemblyName(typeof(CommonResources).GetTypeInfo().Assembly.FullName);
//            //        return factory.Create(nameof(CommonResources), assemblyName.Name);
//            //    };
//            //});

//            builder.Services.Configure<RequestLocalizationOptions>(options =>
//            {
//                var supportedCultures = new[]
//                {
//                    new CultureInfo("en-US"),
//                    new CultureInfo("es-MX")
//                };

//                options.DefaultRequestCulture = new RequestCulture("es-MX");
//                options.SupportedCultures = supportedCultures;
//                options.SupportedUICultures = supportedCultures;
//            });

//            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");


//            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

//            builder.Services.AddTransient<IMembersAppService, MembersAppService>();
//            builder.Services.AddTransient<IMembershipTypesAppService, MembershipTypesAppService>();
//            builder.Services.AddTransient<IEquipamentTypeAppService, EquipamentTypeAppService>();

//            builder.Services.AddTransient<IMenuAppService, MenuAppService>();

//            builder.Services.AddTransient<IRepository<int, MemberDto>, Repository<int, MemberDto>>();
//            builder.Services.AddTransient<IRepository<int, MembershipTypesDto>, Repository<int, MembershipTypesDto>>();
//            builder.Services.AddTransient<IRepository<int, EquipamentTypeDto>, Repository<int, EquipamentTypeDto>>();

//            builder.Services.AddAutoMapper(typeof(GymManager.ApplicationServices.MapperProfile));

//            //builder.Services.AddWkhtmltopdf();

//            Log.Logger = new LoggerConfiguration()
//                .MinimumLevel.Verbose()
//                .WriteTo.File(@"C:\Users\marqu\source\repos\DN12_Jennifer_Rios\M3_NetProjectsWebApi\E4\GymManager.Web\GymManager.Web\Logs\SerilogFile.txt")
//                .CreateLogger();

//            // Resto de la configuración del servidor y la aplicación

//            var app = builder.Build();

//            // Configure the HTTP request pipeline.
//            if(!app.Environment.IsDevelopment())
//            {
//                app.UseExceptionHandler("/Error/Error"); 
//                app.UseHsts();

//            }

//            app.UseHttpsRedirection();
//            app.UseStaticFiles();
//            app.UseRouting();

//            using (var scope = app.Services.CreateScope())
//            {
//                var services = scope.ServiceProvider;

//                var localizationOptions = services.GetService<IOptions<RequestLocalizationOptions>>().Value;

//                app.UseRequestLocalization(localizationOptions);
//            }

//            app.UseAuthentication();
//            app.UseAuthorization();


//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
//            });


//            app.MapRazorPages();
//            app.UseStaticFiles();

//            app.Run();
//        }
//    }
//}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using GymManager.DataAccess;
using GymManager.DataAccess.Repositories;
using GymManager.Accounts.Dto;
using GymManager.ApplicationServices;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Serilog;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Navigation;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var environment = builder.Environment.EnvironmentName = "Development";

            builder.Configuration
                .SetBasePath(builder.Environment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            var connectionString = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<GymManagerContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), mySqlOptions =>
                {
                    mySqlOptions.EnableRetryOnFailure();
                }));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<GymManagerContext>()
                .AddUserStore<UserStore<IdentityUser, IdentityRole, GymManagerContext>>();

            builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Login");
            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
            });

            // Agregar los servicios requeridos
            builder.Services.AddRazorPages().AddViewLocalization();

            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("es-MX")
                };

                options.DefaultRequestCulture = new RequestCulture("en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            // Register services and repositories
            builder.Services.AddScoped<IMembersAppService, MembersAppService>();
            builder.Services.AddScoped<IMembershipTypesAppService, MembershipTypesAppService>();
            builder.Services.AddScoped<IEquipamentTypeAppService, EquipamentTypeAppService>();
            builder.Services.AddScoped<IMenuAppService, MenuAppService>();

            builder.Services.AddScoped<IRepository<int, MemberDto>, Repository<int, MemberDto>>();
            builder.Services.AddScoped<IRepository<int, MembershipTypesDto>, Repository<int, MembershipTypesDto>>();
            builder.Services.AddScoped<IRepository<int, EquipamentTypeDto>, Repository<int, EquipamentTypeDto>>();

            builder.Services.AddAutoMapper(typeof(GymManager.ApplicationServices.MapperProfile));

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.MySQL(connectionString, tableName: "logging")
                .CreateLogger();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                Log.Information("Running in non-development environment: {Environment}", app.Environment.EnvironmentName);
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            else
            {
                Log.Information("Running in development environment");
            }

            app.Use(async (context, next) =>
            {
                try
                {
                    await next.Invoke();
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Unhandled exception");
                    throw;
                }
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var localizationOptions = services.GetService<IOptions<RequestLocalizationOptions>>().Value;
                app.UseRequestLocalization(localizationOptions);
            }

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "error",
                    pattern: "/Error",
                    defaults: new { controller = "Error", action = "Error" });
            });

            app.MapRazorPages();
            app.UseStaticFiles();

            app.Run();
        }
    }
}