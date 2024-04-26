using DataAccess.Example.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Security.Cryptography.X509Certificates;

namespace DataAccess.Example.WebApi
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Information()
                 .Enrich.FromLogContext()
                 .WriteTo.Console()
                 .CreateLogger();

            Log.Information("STARTING UP!");

            try
            {
                CreateHostBuilder(args).Build().Run();
                Log.Information("Stopped cleanly");
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed.");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseKestrel(opt =>
                    {
                        opt.AddServerHeader = false;
                        opt.Limits.MaxRequestBufferSize =16 * 1024;
                        IWebHostEnvironment service = (IWebHostEnvironment)opt.ApplicationServices.GetService(typeof(IWebHostEnvironment));

                        if (service.EnvironmentName == Environments.Production || 
                        service.EnvironmentName == Environments.Staging)
                        {
                            opt.ConfigureHttpsDefaults(
                                listenOptions =>
                                {
                                    //listenOptions.ServerCertificate = new System.Security.Cryptography.X509Certificates("cert.pfx", "ftx131211");
                                    var cert = new X509Certificate2("cert.pfx", "ftx131211");
                                    listenOptions.ServerCertificate = cert;
                                });
                        }
                    });
                });
    }
}
