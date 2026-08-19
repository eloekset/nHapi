namespace ModelGeneratorSourceDB
{
    using System.IO;
    using System.Linq;

    using Microsoft.Extensions.Logging;

    internal class SqliteImporter
    {
        private readonly ILogger<SqliteImporter> _logger;

        public SqliteImporter(ILogger<SqliteImporter> logger)
        {
            _logger = logger;
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
    }
}
