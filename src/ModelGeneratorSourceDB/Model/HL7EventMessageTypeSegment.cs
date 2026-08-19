namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7EventMessageTypeSegment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string EventCode { get; set; }

        public int? VersionId { get; set; }

        public string MessageType { get; set; }

        public string GroupName { get; set; }

        public bool Repetitional { get; set; }

        public bool Optional { get; set; }
    }
}
