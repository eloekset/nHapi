namespace ModelGeneratorSourceDB
{
    using System;

    using Microsoft.Extensions.DependencyInjection;

    using ModelGeneratorSourceDB.Data;

    internal class Program
    {
        public static void Main(string[] args)
        {
            var sp = ConfigureServices(args);
            var command = sp.GetService<SourceDB>();
            command.Execute(sp);
        }

        private static ServiceProvider ConfigureServices(string[] args)
        {
            var command = Args.Configuration.Configure<SourceDB>().CreateAndBind(args);
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddSingleton(command);
            services.AddSqlite<HL7ModelContext>(command.ConnectionString);
            services.AddSingleton<SqliteImporter>();
            services.AddSingleton<CsvParser>();

            return services.BuildServiceProvider();
        }
    }
}
