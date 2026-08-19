using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelGeneratorSourceDB.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HL7Components",
                columns: table => new
                {
                    comp_no = table.Column<int>(type: "INTEGER", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    table_id = table.Column<int>(type: "INTEGER", nullable: true),
                    data_Type_code = table.Column<string>(type: "TEXT", nullable: true),
                    data_structure = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7DataElements",
                columns: table => new
                {
                    data_item = table.Column<int>(type: "INTEGER", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    length_old = table.Column<string>(type: "TEXT", nullable: true),
                    table_id = table.Column<int>(type: "INTEGER", nullable: true),
                    data_structure = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7DataStructureComponents",
                columns: table => new
                {
                    data_structure = table.Column<string>(type: "TEXT", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true),
                    seq_no = table.Column<int>(type: "INTEGER", nullable: false),
                    comp_no = table.Column<int>(type: "INTEGER", nullable: true),
                    table_id = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7DataStructures",
                columns: table => new
                {
                    data_structure = table.Column<string>(type: "TEXT", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    data_type_code = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7DataTypes",
                columns: table => new
                {
                    data_Type_code = table.Column<string>(type: "TEXT", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7EventMessageTypeSegments",
                columns: table => new
                {
                    event_code = table.Column<string>(type: "TEXT", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true),
                    message_type = table.Column<string>(type: "TEXT", nullable: true),
                    groupname = table.Column<string>(type: "TEXT", nullable: true),
                    repetitional = table.Column<bool>(type: "INTEGER", nullable: false),
                    optional = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7MsgStructIDs",
                columns: table => new
                {
                    message_structure = table.Column<string>(type: "TEXT", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7MsgStructIDSegments",
                columns: table => new
                {
                    message_structure = table.Column<string>(type: "TEXT", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true),
                    seg_code = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7SegmentDataElements",
                columns: table => new
                {
                    seg_code = table.Column<string>(type: "TEXT", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true),
                    seq_no = table.Column<int>(type: "INTEGER", nullable: true),
                    req_opt = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7Segments",
                columns: table => new
                {
                    seg_code = table.Column<string>(type: "TEXT", nullable: true),
                    version_id = table.Column<int>(type: "INTEGER", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HL7Versions",
                columns: table => new
                {
                    version_id = table.Column<int>(type: "INTEGER", nullable: true),
                    hl7_version = table.Column<string>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HL7Components");

            migrationBuilder.DropTable(
                name: "HL7DataElements");

            migrationBuilder.DropTable(
                name: "HL7DataStructureComponents");

            migrationBuilder.DropTable(
                name: "HL7DataStructures");

            migrationBuilder.DropTable(
                name: "HL7DataTypes");

            migrationBuilder.DropTable(
                name: "HL7EventMessageTypeSegments");

            migrationBuilder.DropTable(
                name: "HL7MsgStructIDs");

            migrationBuilder.DropTable(
                name: "HL7MsgStructIDSegments");

            migrationBuilder.DropTable(
                name: "HL7SegmentDataElements");

            migrationBuilder.DropTable(
                name: "HL7Segments");

            migrationBuilder.DropTable(
                name: "HL7Versions");
        }
    }
}
