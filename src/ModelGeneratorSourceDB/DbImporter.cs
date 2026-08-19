namespace ModelGeneratorSourceDB
{
    using System.IO;
    using System.Linq;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

    using ModelGeneratorSourceDB.Data;

    internal class DbImporter
    {
        private readonly ILogger<DbImporter> _logger;
        private readonly HL7ModelContext _dbContext;

        public DbImporter(ILogger<DbImporter> logger, HL7ModelContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public void ImportCsvFiles(string directory)
        {
            // 1. Verify that CSV files exists
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

            // 2. Parse CSV files to in-mem model

            // 3. Clear DB used by Code Generator
            ClearDb();

            // 4. Write to DB

        }

        private void ParseCSVFiles()
        {

        }

        private void ClearDb()
        {
            _dbContext.Components.ExecuteDelete();
            _dbContext.DataElements.ExecuteDelete();
            _dbContext.DataStructureComponents.ExecuteDelete();
            _dbContext.DataStructures.ExecuteDelete();
            _dbContext.DataTypes.ExecuteDelete();
            _dbContext.EventMessageTypeSegments.ExecuteDelete();
            _dbContext.EventMessageTypeSegments.ExecuteDelete();
            _dbContext.MsgStructIds.ExecuteDelete();
            _dbContext.MsgStructIdSegments.ExecuteDelete();
            _dbContext.SegmentDataElements.ExecuteDelete();
            _dbContext.Segments.ExecuteDelete();
            _dbContext.Versions.ExecuteDelete();
        }
    }
}
