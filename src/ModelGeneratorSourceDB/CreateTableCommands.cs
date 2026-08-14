namespace ModelGeneratorSourceDB
{
    internal class CreateTableCommands
    {
        public const string Hl7Components =
@"CREATE TABLE IF NOT EXISTS HL7Components (
    comp_no INTEGER NULL,
    version_id INTEGER NULL,
    description TEXT NULL,
    interpretation TEXT NULL,
    table_id INTEGER NULL,
    modification TEXT NULL,
    data_type_code TEXT NULL,
    data_structure TEXT NULL,
    last_change DATETIME NULL,
    section TEXT NULL
);";
        public const string Hl7DataElements =
@"CREATE TABLE IF NOT EXISTS HL7DataElements (
    data_item INTEGER NULL,
    version_id INTEGER NULL,
    description TEXT NULL,
    interpretation TEXT NULL,
    data_structure TEXT NULL,
    length_old TEXT NULL, 
    min_length INTEGER NULL,
    max_length INTEGER NULL, 
    conf_length TEXT NULL, 
    table_id INTEGER NULL, 
    function_area TEXT NULL, 
    date DATETIME NULL,
    modification TEXT NULL, 
    section TEXT NULL, 
    anchor TEXT NULL, 
    owl_gen INTEGER NULL
);";
        public const string Hl7DataStructureComponents =
@"CREATE TABLE IF NOT EXISTS HL7DataStructureComponents (
    data_structure TEXT NULL, 
    version_id INTEGER NULL, 
    seq_no INTEGER NULL,
    comp_no INTEGER NULL, 
    table_id INTEGER NULL, 
    modification TEXT NULL, 
    length_old TEXT NULL, 
    min_length INTEGER NULL, 
    max_length INTEGER NULL, 
    conf_length TEXT NULL, 
    req_opt TEXT NULL, 
    comments TEXT NULL
);";
        public const string Hl7DataStructures =
@"CREATE TABLE IF NOT EXISTS HL7DataStructures (
    data_structure TEXT NULL, 
    version_id INTEGER NULL, 
    description TEXT NULL, 
    interpretation TEXT NULL, 
    data_type_code TEXT NULL, 
    repeating INTEGER NULL, 
    elementary INTEGER NULL, 
    date DATETIME NULL, 
    section TEXT NULL, 
    anchor TEXT NULL, 
    owl_gen INTEGER NULL, 
    mixed_content INTEGER NULL
);";
        public const string Hl7DataTypes =
@"CREATE TABLE IF NOT EXISTS HL7DataTypes (
    data_type_code TEXT NULL,
    version_id INTEGER NULL, 
    description TEXT NULL, 
    length INTEGER NULL, 
    anchor TEXT NULL,
    owl_gen INTEGER NULL
);";
        public const string Hl7EventMessageTypeSegments =
@"CREATE TABLE IF NOT EXISTS HL7EventMessageTypeSegments (
    event_code TEXT NULL,
    version_id INTEGER NULL, 
    message_type TEXT NULL, 
    seq_no INTEGER NULL, 
    seg_code TEXT NULL, 
    groupname TEXT NULL, 
    modification TEXT NULL, 
    repetitional INTEGER NULL, 
    optional INTEGER NULL, 
    status TEXT NULL
);";
        public const string Hl7MessageTypes =
@"CREATE TABLE IF NOT EXISTS HL7MessageTypes (
    message_type TEXT NULL, 
    version_id INTEGER NULL, 
    description TEXT NULL, 
    section TEXT NULL, 
    anchor TEXT NULL
);";
        public const string Hl7MsgStructIDs =
@"CREATE TABLE IF NOT EXISTS HL7MsgStructIDs (
    message_structure TEXT NULL, 
    version_id INTEGER NULL, 
    description TEXT NULL, 
    example_event TEXT NULL, 
    example_msg_type TEXT NULL, 
    action TEXT NULL, 
    section TEXT NULL, 
    anchor TEXT NULL, 
    owl_gen INTEGER NULL
);";
        public const string Hl7MsgStructIDSegments =
@"CREATE TABLE IF NOT EXISTS HL7MsgStructIDSegments (
    message_structure TEXT NULL, 
    version_id INTEGER NULL, 
    seq_no INTEGER NULL, 
    seg_code TEXT NULL, 
    groupname TEXT NULL, 
    modification TEXT NULL, 
    repetitional INTEGER NULL, 
    optional INTEGER NULL, 
    status TEXT NULL
);";
        public const string Hl7SegmentDataElements =
@"CREATE TABLE IF NOT EXISTS HL7SegmentDataElements (
    seg_code TEXT NULL, 
    version_id INTEGER NULL, 
    seq_no INTEGER NULL, 
    data_item INTEGER NULL, 
    req_opt TEXT NULL, 
    repetitional TEXT NULL, 
    repetitions INTEGER NULL, 
    section TEXT NULL, 
    anchor TEXT NULL, 
    impl_guide INTEGER NULL
);";
        public const string Hl7Segments =
@"CREATE TABLE IF NOT EXISTS HL7Segments (
    seg_code TEXT NULL, 
    version_id INTEGER NULL, 
    description TEXT NULL, 
    interpretation TEXT NULL, 
    function_area TEXT NULL, 
    generate INTEGER NULL, 
    last_field_repeatable INTEGER NULL, 
    visible INTEGER NULL, 
    section TEXT NULL, 
    anchor TEXT NULL, 
    owl_gen INTEGER NULL, 
    steward TEXT NULL, 
    segment_type INTEGER NULL
);";
        public const string Hl7Versions =
@"CREATE TABLE IF NOT EXISTS HL7Versions (
    version_id INTEGER NULL, 
    hl7_version TEXT NULL, 
    description TEXT NULL, 
    status TEXT NULL, 
    date_release DATETIME NULL, 
    HtmlPath TEXT NULL, 
    HtmlFile TEXT NULL, 
    filename_prefix TEXT NULL, 
    previous_version INTEGER NULL, 
    sort INTEGER NULL, 
    HtmlGeneration INTEGER NULL, 
    display INTEGER NULL, 
    base_standard INTEGER NULL, 
    XML_schema_path TEXT NULL, 
    compare_table INTEGER NULL, 
    realm TEXT NULL, 
    governance TEXT NULL
);";
    }
}
