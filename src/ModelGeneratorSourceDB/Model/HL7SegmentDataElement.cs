namespace ModelGeneratorSourceDB.Model
{
    using System;

    public class HL7SegmentDataElement
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string SegmentCode { get; set; }

        public int? VersionId { get; set; }

        public int? SequenceNo { get; set; }

        /// <summary>
        /// Required/Optional/Backward Compatibility.
        /// </summary>
        public string Reqired { get; set; }
    }
}
