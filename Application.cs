using Microsoft.Extensions.Logging;
using System;

namespace another_backup_of_1C_database
{
    public class Application
    {
        private readonly ILogger logger;
        private readonly Settings settings;

        public Application(ILogger<Application> logger, Settings settings)
        {
            this.logger = logger;
            this.settings = settings;
        }
        internal void Run()
        {
            logger.LogInformation("Приложение запущено {dateTime}", DateTime.Now);
            
            Console.WriteLine("Привет мир");
            
            logger.LogInformation("Настройки. Имя {DB}", settings.DbName);
            logger.LogWarning("Приложение  остановлено");
        }
    }
}