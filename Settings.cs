using Microsoft.Extensions.Configuration;

namespace another_backup_of_1C_database
{
    public class Settings
    {
        private readonly IConfiguration configuration;

        public Settings(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string DbName => configuration.GetValue<string>("dbName");
    }
}