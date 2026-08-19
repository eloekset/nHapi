namespace ModelGeneratorSourceDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ModelGeneratorSourceDB.Model;

    internal class HL7DataTypeConfiguration : IEntityTypeConfiguration<HL7DataType>
    {
        public void Configure(EntityTypeBuilder<HL7DataType> builder)
        {
            builder.ToTable("HL7DataTypes");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.DataTypeCode).HasColumnName("data_Type_code");
            builder.Property(b => b.VersionId).HasColumnName("version_id");
        }
    }
}
