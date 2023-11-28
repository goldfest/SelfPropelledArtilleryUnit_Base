using SelfPropelledArtilleryUnit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

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
            services.AddSingleton<FormSelfPropelledArtilleryUnitCollection>()
            .AddLogging(option =>
            {
                option.SetMinimumLevel(LogLevel.Information);
                option.AddNLog("nlog.config");
            });


        }
    }
}