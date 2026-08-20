namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7MsgStructIdSegment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string MessageStructure { get; set; }

        public int? VersionId { get; set; }

        public string SegmentCode { get; set; }

        public int? SequenceNo { get; set; }

        public string GroupName { get; set; }

        public bool Repetitional { get; set; }

        public bool Optional { get; set; }
    }
}
