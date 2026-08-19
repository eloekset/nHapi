namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7SegmentConfiguration : IEntityTypeConfiguration<HL7Segment>
    {
        public void Configure(EntityTypeBuilder<HL7Segment> builder)
        {
            builder.ToTable("HL7Segments");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.SegmentCode).HasColumnName("seg_code");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
            builder.Property(b => b.Description).HasColumnName("description");
        }
    }
}
