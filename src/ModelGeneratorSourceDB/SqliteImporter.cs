namespace ModelGeneratorSourceDB
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

    using ModelGeneratorSourceDB.Data;
    using ModelGeneratorSourceDB.Model;

    internal class SqliteImporter
    {
        private static readonly IReadOnlyDictionary<string, Type> TableModelTypes = new Dictionary<string, Type>(System.StringComparer.OrdinalIgnoreCase)
        {
            [TableNames.Hl7Components] = typeof(HL7Component),
            [TableNames.Hl7DataElements] = typeof(HL7DataElement),
            [TableNames.Hl7DataStructureComponents] = typeof(HL7DataStructureComponent),
            [TableNames.Hl7DataStructures] = typeof(HL7DataStructure),
            [TableNames.Hl7DataTypes] = typeof(HL7DataType),
            [TableNames.Hl7EventMessageTypeSegments] = typeof(HL7EventMessageTypeSegment),
            [TableNames.Hl7MsgStructIDs] = typeof(HL7MsgStructId),
            [TableNames.Hl7MsgStructIDSegments] = typeof(HL7MsgStructIdSegment),
            [TableNames.Hl7SegmentDataElements] = typeof(HL7SegmentDataElement),
            [TableNames.Hl7Segments] = typeof(HL7Segment),
            [TableNames.Hl7Versions] = typeof(HL7Version),
        };

        private readonly ILogger<SqliteImporter> _logger;
        private readonly HL7ModelContext _dbContext;
        private readonly CsvParser _csvParser;

        public SqliteImporter(ILogger<SqliteImporter> logger, HL7ModelContext dbContext, CsvParser csvParser)
        {
            _logger = logger;
            _dbContext = dbContext;
            _csvParser = csvParser;
        }

        public void ImportCsvFiles(string directory, string connectionString)
        {
            var model = new Dictionary<string, object>();
            var dir = new DirectoryInfo(directory);
            if (dir.Exists)
            {
                var csvFiles = dir.GetFiles();
                foreach (var expectedFileName in TableNames.All)
                {
                    if (!csvFiles.Where(f => f.Name.Equals($"{expectedFileName}.csv", System.StringComparison.InvariantCultureIgnoreCase)).Any())
                    {
                        _logger.LogError($"{expectedFileName}.csv not found");
                        return;
                    }
                }

                model = ParseCsvFiles(csvFiles);
            }
            else
            {
                _logger.LogWarning($"CSV import folder {directory} does not exist");
                return;
            }

            ClearDb();
            AddToDb(model);
            _dbContext.SaveChanges();
        }

        private Dictionary<string, object> ParseCsvFiles(FileInfo[] csvFiles)
        {
            var model = new Dictionary<string, object>();
            foreach (var file in csvFiles)
            {
                var tableName = Path.GetFileNameWithoutExtension(file.Name);
                if (!TableModelTypes.TryGetValue(tableName, out var modelType))
                {
                    // No strongly typed model for this table (e.g. HL7MessageTypes); skip.
                    continue;
                }

                var parseMethod = typeof(CsvParser)
                    .GetMethods()
                    .Single(m => m.Name == nameof(CsvParser.ParseCsvFile) && m.IsGenericMethod)
                    .MakeGenericMethod(modelType);

                var records = parseMethod.Invoke(_csvParser, new object[] { file.FullName, ';' });
                model[tableName] = records;
            }
            return model;
        }

        private void ClearDb()
        {
            _dbContext.Components.ExecuteDelete();
            _dbContext.DataElements.ExecuteDelete();
            _dbContext.DataStructureComponents.ExecuteDelete();
            _dbContext.DataStructures.ExecuteDelete();
            _dbContext.DataTypes.ExecuteDelete();
            _dbContext.EventMessageTypeSegments.ExecuteDelete();
            _dbContext.MsgStructIds.ExecuteDelete();
            _dbContext.MsgStructIdSegments.ExecuteDelete();
            _dbContext.SegmentDataElements.ExecuteDelete();
            _dbContext.Segments.ExecuteDelete();
            _dbContext.Versions.ExecuteDelete();
        }

        private void AddToDb(Dictionary<string, object> model)
        {
            foreach (var (tableName, records) in model)
            {
                switch (tableName)
                {
                    case TableNames.Hl7Components:
                        _dbContext.Components.AddRange((IEnumerable<HL7Component>)records);
                        break;
                    case TableNames.Hl7DataElements:
                        _dbContext.DataElements.AddRange((IEnumerable<HL7DataElement>)records);
                        break;
                    case TableNames.Hl7DataStructureComponents:
                        _dbContext.DataStructureComponents.AddRange((IEnumerable<HL7DataStructureComponent>)records);
                        break;
                    case TableNames.Hl7DataStructures:
                        _dbContext.DataStructures.AddRange((IEnumerable<HL7DataStructure>)records);
                        break;
                    case TableNames.Hl7DataTypes:
                        _dbContext.DataTypes.AddRange((IEnumerable<HL7DataType>)records);
                        break;
                    case TableNames.Hl7EventMessageTypeSegments:
                        _dbContext.EventMessageTypeSegments.AddRange((IEnumerable<HL7EventMessageTypeSegment>)records);
                        break;
                    case TableNames.Hl7MsgStructIDs:
                        _dbContext.MsgStructIds.AddRange((IEnumerable<HL7MsgStructId>)records);
                        break;
                    case TableNames.Hl7MsgStructIDSegments:
                        _dbContext.MsgStructIdSegments.AddRange((IEnumerable<HL7MsgStructIdSegment>)records);
                        break;
                    case TableNames.Hl7SegmentDataElements:
                        _dbContext.SegmentDataElements.AddRange((IEnumerable<HL7SegmentDataElement>)records);
                        break;
                    case TableNames.Hl7Segments:
                        _dbContext.Segments.AddRange((IEnumerable<HL7Segment>)records);
                        break;
                    case TableNames.Hl7Versions:
                        _dbContext.Versions.AddRange((IEnumerable<HL7Version>)records);
                        break;
                    default:
                        _logger.LogWarning($"No DbSet mapping found for table '{tableName}'; skipping.");
                        break;
                }
            }
        }
    }
}
