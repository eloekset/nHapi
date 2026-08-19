namespace ModelGeneratorSourceDB
{
    using System;
    using System.Configuration;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    using ModelGeneratorSourceDB.Data;

    public class SourceDB
    {
        public SourceDB()
        {
            BasePath = @"C:\GitHub\nHapi\SourceDB";
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string BasePath { get; set; }

        public string ConnectionString { get; set; }

        public void Execute(IServiceProvider sp)
        {
            Console.WriteLine("Using Database:{0}", ConnectionString);
            Console.WriteLine("Base Path:{0}", BasePath);

            Console.WriteLine("Apply migrations...");
            var dbContext = sp.GetService<HL7ModelContext>();
            dbContext.Database.Migrate();

            Console.WriteLine("Import from CSV files");
            var sqliteImporter = sp.GetService<SqliteImporter>();
            sqliteImporter.ImportCsvFiles(BasePath, ConnectionString);
        }
    }
}
