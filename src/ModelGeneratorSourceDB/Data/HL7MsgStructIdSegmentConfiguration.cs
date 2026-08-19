namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7MsgStructIdSegmentConfiguration : IEntityTypeConfiguration<HL7MsgStructIdSegment>
    {
        public void Configure(EntityTypeBuilder<HL7MsgStructIdSegment> builder)
        {
            builder.ToTable("HL7MsgStructIDSegments");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.MessageStructure).HasColumnName("message_structure");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
            builder.Property(b => b.SegmentCode).HasColumnName("seg_code");
        }
    }
}
