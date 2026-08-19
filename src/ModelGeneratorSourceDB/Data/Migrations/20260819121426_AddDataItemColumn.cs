using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelGeneratorSourceDB.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataItemColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "data_item",
                table: "HL7SegmentDataElements",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data_item",
                table: "HL7SegmentDataElements");
        }
    }
}
