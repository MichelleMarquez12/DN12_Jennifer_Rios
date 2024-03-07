using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<VehicleDataContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


            builder.Services.AddTransient<IQueriesExample, QueriesExample>();

            builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling =
            Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            // Agregar los servicios requeridos
            builder.Services.AddRazorPages();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();



            app.Run();
        }
    }
}
