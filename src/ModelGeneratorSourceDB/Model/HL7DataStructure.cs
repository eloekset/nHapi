namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7DataStructure
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string DataStructure { get; set; }

        public int? VersionId { get; set; }

        public string Description { get; set; }

        public string DataTypeCode { get; set; }
    }
}
