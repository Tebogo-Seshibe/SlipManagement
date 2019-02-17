namespace SlipManagementTests
{
    public class Configuration
    {
        public string SqlConnectionString { get; private set; }
        
        /*
        public Configuration(IConfiguration config)
        {
            var sqlSection = config.GetSection("Sql");
            SqlConnectionString = sqlSection.GetValue<string>("ConnectionString");
        }
        */
    }
}
