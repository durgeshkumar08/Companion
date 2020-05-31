using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;
using System;
using System.IO;

namespace Companion.Config
{
    public class SerilogSetup
    {
        private static char backslash = Path.DirectorySeparatorChar;
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        public static ILogger GetLogger()
        {
            return new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .Enrich.FromLogContext()
                .WriteTo.File(Directory.GetCurrentDirectory() + $"{backslash}Path{backslash}CompanionService_.log", rollingInterval: RollingInterval.Day,
                        outputTemplate: "{SessionId} {CorelationId} {LoggedInUser} {Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .CreateLogger();
        }
    }
}
