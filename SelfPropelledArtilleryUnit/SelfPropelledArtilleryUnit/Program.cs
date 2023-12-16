using SelfPropelledArtilleryUnit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using Serilog;

namespace ProjectUsta
{

    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                Application.Run(serviceProvider.GetRequiredService<FormSelfPropelledArtilleryUnitCollection>());
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<FormSelfPropelledArtilleryUnitCollection>().AddLogging(option =>
            {
                string[] path = Directory.GetCurrentDirectory().Split('\\');
                string pathNeed = "";
                for (int i = 0; i < path.Length - 3; i++)
                {
                    pathNeed += path[i] + "\\";
                }
                var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(path: $"{pathNeed}appsettings.json", optional: false, reloadOnChange: true).Build();
                var logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();

                option.SetMinimumLevel(LogLevel.Information);
                option.AddSerilog(logger);
            });


        }
    }
}