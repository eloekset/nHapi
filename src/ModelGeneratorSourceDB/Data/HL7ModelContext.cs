namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;

    using ModelGeneratorSourceDB.Model;

    internal class HL7ModelContext : DbContext
    {
        public HL7ModelContext(DbContextOptions<HL7ModelContext> options)
            : base(options)
        {
        }

        public DbSet<HL7Component> Components { get; set; }

        public DbSet<HL7DataElement> DataElements { get; set; }

        public DbSet<HL7DataStructureComponent> DataStructureComponents { get; set; }

        public DbSet<HL7DataStructure> DataStructures { get; set; }

        public DbSet<HL7DataType> DataTypes { get; set; }

        public DbSet<HL7EventMessageTypeSegment> EventMessageTypeSegments { get; set; }

        public DbSet<HL7MsgStructId> MsgStructIds { get; set; }

        public DbSet<HL7MsgStructIdSegment> MsgStructIdSegments { get; set; }

        public DbSet<HL7Segment> Segments { get; set; }

        public DbSet<HL7SegmentDataElement> SegmentDataElements { get; set; }

        public DbSet<HL7Version> Versions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new HL7ComponentConfiguration().Configure(modelBuilder.Entity<HL7Component>());
            new HL7DataElementConfiguration().Configure(modelBuilder.Entity<HL7DataElement>());
            new HL7DataStructureComponentConfiguration().Configure(modelBuilder.Entity<HL7DataStructureComponent>());
            new HL7DataStructureConfiguration().Configure(modelBuilder.Entity<HL7DataStructure>());
            new HL7DataTypeConfiguration().Configure(modelBuilder.Entity<HL7DataType>());
            new HL7EventMessageTypeSegmentConfiguration().Configure(modelBuilder.Entity<HL7EventMessageTypeSegment>());
            new HL7MsgStructIdConfiguration().Configure(modelBuilder.Entity<HL7MsgStructId>());
            new HL7MsgStructIdSegmentConfiguration().Configure(modelBuilder.Entity<HL7MsgStructIdSegment>());
            new HL7SegmentConfiguration().Configure(modelBuilder.Entity<HL7Segment>());
            new HL7SegmentDataElementConfiguration().Configure(modelBuilder.Entity<HL7SegmentDataElement>());
            new HL7VersionConfiguration().Configure(modelBuilder.Entity<HL7Version>());
        }
    }
}
