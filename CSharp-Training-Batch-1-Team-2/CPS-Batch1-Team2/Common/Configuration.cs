namespace CPS_Batch1_Team2.Common
{
    /// <summary>
    /// Class to read configuration from appsettings.json
    /// </summary>
    public class Configuration
    {
        #region Properties

        /// <summary>
        /// Represents the database connection string used for connecting to the database.
        /// </summary>
        private string _connectionString = string.Empty;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to read the connection string from appsettings.json
        /// </summary>
        public Configuration()
        {
            var _config = new ConfigurationBuilder().AddJsonFile("./appsettings.json", optional: true, reloadOnChange: true).Build();

            _connectionString = _config.GetSection("ConnectionStrings")[$"Dev_DBConnectionString"];
        }
        #endregion

        #region Methods

        /// <summary>
        /// Retrieves the database connection string from the configuration.
        /// </summary>
        /// <returns>The database connection string.</returns>
        public string GetDbConnectionString()
        {
            string connectionString = _connectionString;
            NLog.GlobalDiagnosticsContext.Set("connectionString", connectionString);
            return connectionString;
        }
        #endregion
    }
}
