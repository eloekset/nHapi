namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7DataStructureConfiguration : IEntityTypeConfiguration<HL7DataStructure>
    {
        public void Configure(EntityTypeBuilder<HL7DataStructure> builder)
        {
            builder.ToTable("HL7DataStructures");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.DataStructure).HasColumnName("data_structure");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
            builder.Property(b => b.Description).HasColumnName("description");
            builder.Property(b => b.DataTypeCode).HasColumnName("data_type_code");
        }
    }
}
