namespace ModelGeneratorSourceDB
{
    using System;
    using System.Configuration;

    public class SourceDB
    {
        public SourceDB()
        {
            BasePath = @"C:\GitHub\nHapi\SourceDB";
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string BasePath { get; set; }

        public string ConnectionString { get; set; }

        public void Execute()
        {
            Console.WriteLine("Using Database:{0}", ConnectionString);
            Console.WriteLine("Base Path:{0}", BasePath);

            var sqliteImporter = new SqliteImporter();
            sqliteImporter.CreateTablesIfNotExists(ConnectionString);
        }
    }
}
