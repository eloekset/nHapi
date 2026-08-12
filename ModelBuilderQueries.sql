DECLARE @Version nvarchar(8) = '2.5'
DECLARE @Message nvarchar(7) = 'DFT_P03'
DECLARE @DataType nvarchar(2) = 'ST'
DECLARE @SegmentCode nvarchar(3) = 'ED'

-- DataTypes
select data_type_code 
from HL7DataTypes dt, HL7Versions v
where v.version_id = dt.version_id AND v.hl7_version = @Version

-- DataStructures
SELECT data_structure 
FROM HL7DataStructures ds, HL7Versions v
WHERE data_type_code IN('CF', 'CK', 'CM', 'CN', 'CQ') 
AND v.version_id = ds.version_id AND v.hl7_version = @Version

-- DataType
SELECT ds.data_structure, dsc.seq_no, ds.description, dsc.table_id, c.description, c.table_id, c.data_type_code, c.data_structure 
FROM HL7Versions v
LEFT JOIN (HL7DataStructures ds
	LEFT JOIN (HL7DataStructureComponents dsc
		LEFT JOIN HL7Components c ON dsc.comp_no = c.comp_no AND dsc.version_id = c.version_id) 
	ON ds.version_id = dsc.version_id AND ds.data_structure = dsc.data_structure) 
ON ds.version_id = v.version_id 
WHERE ds.data_structure = @DataType AND v.hl7_version = @Version
ORDER BY dsc.seq_no

-- Segment
SELECT seg_code, [section] 
FROM HL7Segments s, HL7Versions v 
WHERE s.version_id = v.version_id AND hl7_version = @Version AND s.visible = 1

-- MakeSegment
SELECT sde.seg_code, sde.seq_no, sde.repetitional, sde.repetitions, de.description, de.length_old, de.table_id, sde.req_opt, s.description, de.data_structure
FROM HL7Versions v
RIGHT JOIN (HL7Segments s
	INNER JOIN (HL7DataElements de
		INNER JOIN HL7SegmentDataElements sde ON (de.version_id = sde.version_id) AND (de.data_item = sde.data_item)) 
    ON (s.version_id = sde.version_id) AND (s.seg_code = sde.seg_code)) 
ON (v.version_id = s.version_id) 
WHERE sde.seg_code = @SegmentCode AND v.hl7_version = @Version 
ORDER BY sde.seg_code, sde.seq_no

-- GetMessageListQuery
SELECT distinct  [message_type]+'_'+[event_code] AS msg_struct, '[AAA]' as [section]
FROM HL7Versions v
RIGHT JOIN HL7EventMessageTypeSegments emts ON emts.version_id = v.version_id
WHERE v.hl7_version = @Version AND NOT (message_type='ACK') 

UNION 

SELECT DISTINCT msi.message_structure, [section] 
FROM HL7Versions v
RIGHT JOIN (HL7MsgStructIDSegments msis
INNER JOIN HL7MsgStructIDs msi ON msis.message_structure = msi.message_structure AND msis.version_id = msi.version_id) ON msis.version_id = v.version_id 
WHERE v.hl7_version = @Version AND msi.message_structure NOT LIKE 'ACK_%'

-- GetSegmentListQuery
SELECT s.seg_code, repetitional, optional, s.description, seq_no, groupname 
FROM HL7Versions v
RIGHT JOIN (HL7Segments s
	INNER JOIN HL7EventMessageTypeSegments emts ON (s.version_id = emts.version_id) AND (s.seg_code = emts.seg_code)
) ON s.version_id = v.version_id 
WHERE (((v.hl7_version)= @Version) AND (([message_type]+'_'+[event_code])= @Message ))

UNION 

SELECT s.seg_code, repetitional, optional, s.description, seq_no, groupname  
FROM HL7Versions v
RIGHT JOIN (HL7MsgStructIDSegments msis
	INNER JOIN HL7Segments s ON msis.seg_code = s.seg_code AND msis.version_id = s.version_id
) ON s.version_id = v.version_id 
WHERE v.hl7_version = @Version AND message_structure = @Message 
ORDER BY seq_no

