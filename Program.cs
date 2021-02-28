using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;

namespace another_backup_of_1C_database
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            using ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            Application application = serviceProvider.GetService<Application>();

            application.Run();
        }

        private static void ConfigureServices(ServiceCollection serviceCollection)
        {
            serviceCollection.AddLogging(configure => configure.AddConsole()).AddTransient<Application>();
           
            serviceCollection.AddSingleton<Settings>();
        }
    }
}
