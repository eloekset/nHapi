namespace ModelGeneratorSourceDB
{
    using System.IO;
    using System.Linq;

    using Microsoft.Data.Sqlite;
    using Microsoft.Extensions.Logging;

    internal class SqliteImporter
    {
        private readonly ILogger<SqliteImporter> _logger;

        public SqliteImporter(ILogger<SqliteImporter> logger)
        {
            _logger = logger;
        }

        public void CreateTablesIfNotExists(string connectionString)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                ExecuteNonQuery(CreateTableCommands.Hl7Components, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7DataElements, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7DataStructureComponents, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7DataStructures, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7DataTypes, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7EventMessageTypeSegments, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7MessageTypes, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7MsgStructIDs, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7MsgStructIDSegments, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7SegmentDataElements, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7Segments, connection);
                ExecuteNonQuery(CreateTableCommands.Hl7Versions, connection);
            }
        }

        public void ImportCsvFiles(string directory, string connectionString)
        {
            var dir = new DirectoryInfo(directory);
            if (dir.Exists)
            {
                var csvFiles = dir.GetFiles();
                foreach (var expectedFileName in TableNames.All)
                {
                    if (!csvFiles.Where(f => f.Name.Equals(expectedFileName, System.StringComparison.InvariantCultureIgnoreCase)).Any())
                    {
                        _logger.LogError($"{expectedFileName}.csv not found");
                        return;
                    }

                }
            }
            else
            {
                _logger.LogWarning($"CSV import folder {directory} does not exist");
            }
        }

        private void ExecuteNonQuery(string commandText, SqliteConnection connection)
        {
            using (var cmd = new SqliteCommand(commandText, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
