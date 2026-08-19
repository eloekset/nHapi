using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelGeneratorSourceDB.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRepetitialColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "repetitional",
                table: "HL7SegmentDataElements",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "repetitions",
                table: "HL7SegmentDataElements",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "repetitional",
                table: "HL7SegmentDataElements");

            migrationBuilder.DropColumn(
                name: "repetitions",
                table: "HL7SegmentDataElements");
        }
    }
}
