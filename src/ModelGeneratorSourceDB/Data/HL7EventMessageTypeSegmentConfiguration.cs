namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7EventMessageTypeSegmentConfiguration : IEntityTypeConfiguration<HL7EventMessageTypeSegment>
    {
        public void Configure(EntityTypeBuilder<HL7EventMessageTypeSegment> builder)
        {
            builder.ToTable("HL7EventMessageTypeSegments");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.EventCode).HasColumnName("event_code");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
            builder.Property(b => b.MessageType).HasColumnName("message_type");
            builder.Property(b => b.SegmentCode).HasColumnName("seg_code");
            builder.Property(b => b.SequenceNo).HasColumnName("seq_no");
            builder.Property(b => b.GroupName).HasColumnName("groupname");
            builder.Property(b => b.Repetitional).HasColumnName("repetitional");
            builder.Property(b => b.Optional).HasColumnName("optional");
        }
    }
}
