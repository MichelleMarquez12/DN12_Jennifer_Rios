using DataAccess.Example.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace DataAccess.Example.WebApi
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

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(); 

            services.AddDbContext<VehiclesDataContext>(options => options.UseInMemoryDatabase("DataTest"));

            services.AddTransient<IVehiclesDataManager, VehiclesDataManager>();
            services.AddTransient<IQueriesExample, QueriesExample>();
            services.AddTransient<IColorsDataManager, ColorsDataManager>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/error");
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseSerilogRequestLogging();

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
