namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7MsgStructId
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string MessageStructure { get; set; }

        public int? VersionId { get; set; }

        public string Section { get; set; }
    }
}
