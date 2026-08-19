namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7DataElementConfiguration : IEntityTypeConfiguration<HL7DataElement>
    {
        public void Configure(EntityTypeBuilder<HL7DataElement> builder)
        {
            builder.ToTable("HL7DataElements");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.DataItem).HasColumnName("data_item");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
            builder.Property(b => b.Description).HasColumnName("description");
            builder.Property(b => b.LengthOld).HasColumnName("length_old");
            builder.Property(b => b.TableId).HasColumnName("table_id");
            builder.Property(b => b.DataStructure).HasColumnName("data_structure");
        }
    }
}
