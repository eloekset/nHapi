namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7VersionConfiguration : IEntityTypeConfiguration<HL7Version>
    {
        public void Configure(EntityTypeBuilder<HL7Version> builder)
        {
            builder.ToTable("HL7Versions");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
            builder.Property(b => b.Hl7Version).HasColumnName("hl7_version");
            builder.Property(b => b.Description).HasColumnName("description");
        }
    }
}
