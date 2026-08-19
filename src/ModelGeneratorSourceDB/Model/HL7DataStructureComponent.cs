namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7DataStructureComponent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string DataStructure { get; set; }

        public int? VersionId { get; set; }

        public int SequenceNo { get; set; }

        public int? ComponentNo { get; set; }

        public int? TableId { get; set; }
    }
}
