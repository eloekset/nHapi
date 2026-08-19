namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7SegmentDataElementConfiguration : IEntityTypeConfiguration<HL7SegmentDataElement>
    {
        public void Configure(EntityTypeBuilder<HL7SegmentDataElement> builder)
        {
            builder.ToTable("HL7SegmentDataElements");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.SegmentCode).HasColumnName("seg_code");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
            builder.Property(b => b.SequenceNo).HasColumnName("seq_no");
            builder.Property(b => b.Reqired).HasColumnName("req_opt");
        }
    }
}
