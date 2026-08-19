namespace ModelGeneratorSourceDB.Data
{
    using System.Configuration;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    /// <summary>
    /// Enables EF Core tooling (e.g. "dotnet ef migrations add") to construct
    /// <see cref="HL7ModelContext"/> at design time, since it has no parameterless constructor.
    /// </summary>
    internal class HL7ModelContextFactory : IDesignTimeDbContextFactory<HL7ModelContext>
    {
        public HL7ModelContext CreateDbContext(string[] args)
        {
            var connectionString = ConfigurationManager.AppSettings["ConnectionString"]
                ?? "Data Source=hl7_model.db;";

            var optionsBuilder = new DbContextOptionsBuilder<HL7ModelContext>();
            optionsBuilder.UseSqlite(connectionString);

            return new HL7ModelContext(optionsBuilder.Options);
        }
    }
}
