namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7Version
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int? VersionId { get; set; }

        public string Hl7Version { get; set; }

        public string Description { get; set; }
    }
}
