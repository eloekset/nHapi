namespace ModelGeneratorSourceDB
{
    using System;
    using System.Collections.Generic;

    using ModelGeneratorSourceDB.Model;

    /// <summary>
    /// Static, explicit mapping between CSV header names and model property names
    /// for each HL7 entity. This replaces relying on convention/attribute-based
    /// matching, since CSV headers do not map 1:1 to model property names.
    /// </summary>
    internal static class CsvColumnMappings
    {
        public static readonly IReadOnlyDictionary<Type, IReadOnlyDictionary<string, string>> ByType =
            new Dictionary<Type, IReadOnlyDictionary<string, string>>
            {
                [typeof(HL7Component)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["comp_no"] = nameof(HL7Component.ComponentNo),
                    ["version_id"] = nameof(HL7Component.VersionId),
                    ["description"] = nameof(HL7Component.Description),
                    ["table_id"] = nameof(HL7Component.TableId),
                    ["data_type_code"] = nameof(HL7Component.DataTypeCode),
                    ["data_structure"] = nameof(HL7Component.DataStructure),
                },
                [typeof(HL7DataElement)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["data_item"] = nameof(HL7DataElement.DataItem),
                    ["version_id"] = nameof(HL7DataElement.VersionId),
                    ["description"] = nameof(HL7DataElement.Description),
                    ["length_old"] = nameof(HL7DataElement.LengthOld),
                    ["table_id"] = nameof(HL7DataElement.TableId),
                    ["data_structure"] = nameof(HL7DataElement.DataStructure),
                },
                [typeof(HL7DataStructureComponent)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["data_structure"] = nameof(HL7DataStructureComponent.DataStructure),
                    ["version_id"] = nameof(HL7DataStructureComponent.VersionId),
                    ["seq_no"] = nameof(HL7DataStructureComponent.SequenceNo),
                    ["comp_no"] = nameof(HL7DataStructureComponent.ComponentNo),
                    ["table_id"] = nameof(HL7DataStructureComponent.TableId),
                },
                [typeof(HL7DataStructure)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["data_structure"] = nameof(HL7DataStructure.DataStructure),
                    ["version_id"] = nameof(HL7DataStructure.VersionId),
                    ["description"] = nameof(HL7DataStructure.Description),
                    ["data_type_code"] = nameof(HL7DataStructure.DataTypeCode),
                },
                [typeof(HL7DataType)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["data_type_code"] = nameof(HL7DataType.DataTypeCode),
                    ["version_id"] = nameof(HL7DataType.VersionId),
                },
                [typeof(HL7EventMessageTypeSegment)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["event_code"] = nameof(HL7EventMessageTypeSegment.EventCode),
                    ["version_id"] = nameof(HL7EventMessageTypeSegment.VersionId),
                    ["message_type"] = nameof(HL7EventMessageTypeSegment.MessageType),
                    ["seg_code"] = nameof(HL7EventMessageTypeSegment.SegmentCode),
                    ["seq_no"] = nameof(HL7EventMessageTypeSegment.SequenceNo),
                    ["groupname"] = nameof(HL7EventMessageTypeSegment.GroupName),
                    ["repetitional"] = nameof(HL7EventMessageTypeSegment.Repetitional),
                    ["optional"] = nameof(HL7EventMessageTypeSegment.Optional),
                },
                [typeof(HL7MsgStructId)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["message_structure"] = nameof(HL7MsgStructId.MessageStructure),
                    ["version_id"] = nameof(HL7MsgStructId.VersionId),
                    ["section"] = nameof(HL7MsgStructId.Section),
                },
                [typeof(HL7MsgStructIdSegment)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["message_structure"] = nameof(HL7MsgStructIdSegment.MessageStructure),
                    ["version_id"] = nameof(HL7MsgStructIdSegment.VersionId),
                    ["seg_code"] = nameof(HL7MsgStructIdSegment.SegmentCode),
                    ["seq_no"] = nameof(HL7MsgStructIdSegment.SequenceNo),
                    ["groupname"] = nameof(HL7MsgStructIdSegment.GroupName),
                    ["repetitional"] = nameof(HL7MsgStructIdSegment.Repetitional),
                    ["optional"] = nameof(HL7MsgStructIdSegment.Optional),
                },
                [typeof(HL7Segment)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["seg_code"] = nameof(HL7Segment.SegmentCode),
                    ["version_id"] = nameof(HL7Segment.VersionId),
                    ["description"] = nameof(HL7Segment.Description),
                    ["section"] = nameof(HL7Segment.Section),
                    ["visible"] = nameof(HL7Segment.Visible),
                },
                [typeof(HL7SegmentDataElement)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["seg_code"] = nameof(HL7SegmentDataElement.SegmentCode),
                    ["version_id"] = nameof(HL7SegmentDataElement.VersionId),
                    ["seq_no"] = nameof(HL7SegmentDataElement.SequenceNo),
                    ["data_item"] = nameof(HL7SegmentDataElement.DataItem),
                    ["req_opt"] = nameof(HL7SegmentDataElement.Reqired),
                    ["repetitional"] = nameof(HL7SegmentDataElement.Repetitional),
                    ["repetitions"] = nameof(HL7SegmentDataElement.Repetitions),
                },
                [typeof(HL7Version)] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    ["version_id"] = nameof(HL7Version.VersionId),
                    ["hl7_version"] = nameof(HL7Version.Hl7Version),
                    ["description"] = nameof(HL7Version.Description),
                },
            };
    }
}
