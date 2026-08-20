using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelGeneratorSourceDB.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeveralColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "groupname",
                table: "HL7MsgStructIDSegments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "optional",
                table: "HL7MsgStructIDSegments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "repetitional",
                table: "HL7MsgStructIDSegments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "seq_no",
                table: "HL7MsgStructIDSegments",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "seq_no",
                table: "HL7EventMessageTypeSegments",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "groupname",
                table: "HL7MsgStructIDSegments");

            migrationBuilder.DropColumn(
                name: "optional",
                table: "HL7MsgStructIDSegments");

            migrationBuilder.DropColumn(
                name: "repetitional",
                table: "HL7MsgStructIDSegments");

            migrationBuilder.DropColumn(
                name: "seq_no",
                table: "HL7MsgStructIDSegments");

            migrationBuilder.DropColumn(
                name: "seq_no",
                table: "HL7EventMessageTypeSegments");
        }
    }
}
