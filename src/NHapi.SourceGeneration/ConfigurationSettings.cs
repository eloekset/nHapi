namespace NHapi.SourceGeneration
{
    using System;
    using System.Configuration;

    public enum DatabaseProvider
    {
        OleDb,
        Sqlite,
    }

    public class ConfigurationSettings
    {
        private static string connectionString = string.Empty;
        private static DatabaseProvider? databaseProvider;

        public static bool UseFactory
        {
            get
            {
                var useFactory = false;
                var useFactoryFromConfig = ConfigurationManager.AppSettings["UseFactory"];
                if (useFactoryFromConfig != null && useFactoryFromConfig.Length > 0)
                {
                    useFactory = Convert.ToBoolean(useFactoryFromConfig);
                }

                return useFactory;
            }
        }

        public static string ConnectionString
        {
            get
            {
                var connFromConfig = ConfigurationManager.AppSettings["ConnectionString"];
                if (string.IsNullOrEmpty(connectionString) && !string.IsNullOrEmpty(connFromConfig))
                {
                    connectionString = connFromConfig;
                }

                return connectionString;
            }

            set
            {
                connectionString = value;
            }
        }

        /// <summary>
        /// Gets or sets the database provider to use for the normative database
        /// (either an MS Access database via OleDb, or a SQLite database).
        /// If not explicitly set, the provider is inferred from the "DatabaseProvider"
        /// app setting, or otherwise from the connection string / file extension.
        /// </summary>
        public static DatabaseProvider DatabaseProvider
        {
            get
            {
                if (databaseProvider.HasValue)
                {
                    return databaseProvider.Value;
                }

                var providerFromConfig = ConfigurationManager.AppSettings["DatabaseProvider"];
                if (!string.IsNullOrEmpty(providerFromConfig) &&
                    Enum.TryParse<DatabaseProvider>(providerFromConfig, true, out var parsedProvider))
                {
                    return parsedProvider;
                }

                return InferProviderFromConnectionString(ConnectionString);
            }

            set
            {
                databaseProvider = value;
            }
        }

        private static DatabaseProvider InferProviderFromConnectionString(string connString)
        {
            if (!string.IsNullOrEmpty(connString))
            {
                if (connString.IndexOf("OLEDB", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    connString.IndexOf("Jet.OLEDB", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    connString.IndexOf(".mdb", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    connString.IndexOf(".accdb", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return DatabaseProvider.OleDb;
                }

                if (connString.IndexOf(".db", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    connString.IndexOf(".sqlite", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return DatabaseProvider.Sqlite;
                }
            }

            // Default to OleDb for backward compatibility with existing MS Access based setups.
            return DatabaseProvider.OleDb;
        }
    }
}