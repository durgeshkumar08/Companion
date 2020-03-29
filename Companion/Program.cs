using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Companion.Config;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Companion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = SerilogSetup.GetLogger();
            try
            {
                Log.Information("Starting web server.");
                CreateHostBuilder(args).Build().Run();
                Log.Information("Web server successfully started.");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseKestrel();
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory())
                    .UseIISIntegration()
                    .UseConfiguration(SerilogSetup.Configuration)
                    .UseSerilog()
                    .UseStartup<Startup>();
                });
    }
}
