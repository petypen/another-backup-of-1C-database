using Microsoft.Extensions.Logging;
using System;

namespace another_backup_of_1C_database
{
    public class MyApplication
    {
        private readonly ILogger logger;
        public MyApplication(ILogger<MyApplication> logger)
        {
            this.logger = logger;
        }
        internal void Run()
        {
            logger.LogInformation("Приложение запущено {dateTime}", DateTime.Now);
            Console.WriteLine("Привет мир");
            logger.LogWarning("Приложение  остановлено");
        }
    }
}