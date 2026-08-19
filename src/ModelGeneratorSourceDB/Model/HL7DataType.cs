namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7DataType
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string DataTypeCode { get; set; }

        public int? VersionId { get; set; }
    }
}
