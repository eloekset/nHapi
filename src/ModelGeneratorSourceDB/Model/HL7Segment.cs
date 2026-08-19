namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7Segment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string SegmentCode { get; set; }

        public int? VersionId { get; set; }

        public string Description { get; set; }

        public bool Visible { get; set; }

        public string Section { get; set; }
    }
}
