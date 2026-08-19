namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7MsgStructIdConfiguration : IEntityTypeConfiguration<HL7MsgStructId>
    {
        public void Configure(EntityTypeBuilder<HL7MsgStructId> builder)
        {
            builder.ToTable("HL7MsgStructIDs");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.MessageStructure).HasColumnName("message_structure");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
        }
    }
}
