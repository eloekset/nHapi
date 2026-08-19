namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7ComponentConfiguration : IEntityTypeConfiguration<HL7Component>
    {
        public void Configure(EntityTypeBuilder<HL7Component> builder)
        {
            builder.ToTable("HL7Components");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.ComponentNo).HasColumnName("comp_no");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
            builder.Property(b => b.Description).HasColumnName("description");
            builder.Property(b => b.TableId).HasColumnName("table_id");
            builder.Property(b => b.DataTypeCode).HasColumnName("data_Type_code");
            builder.Property(b => b.DataStructure).HasColumnName("data_structure");
        }
    }
}
