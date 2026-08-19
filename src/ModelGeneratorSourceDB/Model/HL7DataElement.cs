namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7DataElement
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int? DataItem { get; set; }

        public int? VersionId { get; set; }

        public string Description { get; set; }

        public string LengthOld { get; set; }

        public int? TableId { get; set; }

        public string DataStructure { get; set; }
    }
}
