namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7DataStructureComponentConfiguration : IEntityTypeConfiguration<HL7DataStructureComponent>
    {
        public void Configure(EntityTypeBuilder<HL7DataStructureComponent> builder)
        {
            builder.ToTable("HL7DataStructureComponents");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.DataStructure).HasColumnName("data_structure");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
            builder.Property(b => b.SequenceNo).HasColumnName("seq_no");
            builder.Property(b => b.ComponentNo).HasColumnName("comp_no");
            builder.Property(b => b.TableId).HasColumnName("table_id");
        }
    }
}
