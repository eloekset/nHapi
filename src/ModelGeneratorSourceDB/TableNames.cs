namespace ModelGeneratorSourceDB
{
    using System.Collections.Generic;

    internal class TableNames
    {
        public const string Hl7Components = "HL7Components";
        public const string Hl7DataElements = "HL7DataElements";
        public const string Hl7DataStructureComponents = "HL7DataStructureComponents";
        public const string Hl7DataStructures = "HL7DataStructures";
        public const string Hl7DataTypes = "HL7DataTypes";
        public const string Hl7EventMessageTypeSegments = "HL7EventMessageTypeSegments";
        public const string Hl7MessageTypes = "HL7MessageTypes";
        public const string Hl7MsgStructIDs = "HL7MsgStructIDs";
        public const string Hl7MsgStructIDSegments = "HL7MsgStructIDSegments";
        public const string Hl7SegmentDataElements = "HL7SegmentDataElements";
        public const string Hl7Segments = "HL7Segments";
        public const string Hl7Versions = "HL7Versions";

        public static IEnumerable<string> All { get; } = new string[]
        {
            Hl7Components,
            Hl7DataElements,
            Hl7DataStructureComponents,
            Hl7DataStructures,
            Hl7DataTypes,
            Hl7EventMessageTypeSegments,
            Hl7MessageTypes,
            Hl7MsgStructIDs,
            Hl7MsgStructIDSegments,
            Hl7SegmentDataElements,
            Hl7Segments,
            Hl7Versions,
        };
    }
}
