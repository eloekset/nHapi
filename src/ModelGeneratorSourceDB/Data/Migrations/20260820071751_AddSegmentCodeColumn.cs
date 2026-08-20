using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelGeneratorSourceDB.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSegmentCodeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "seg_code",
                table: "HL7EventMessageTypeSegments",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "seg_code",
                table: "HL7EventMessageTypeSegments");
        }
    }
}
