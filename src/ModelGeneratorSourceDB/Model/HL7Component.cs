namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7Component
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int? ComponentNo { get; set; }

        public int? VersionId { get; set; }

        public string Description { get; set; }

        public int? TableId { get; set; }

        public string DataTypeCode { get; set; }

        public string DataStructure { get; set; }
    }
}
