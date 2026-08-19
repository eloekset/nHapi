using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelGeneratorSourceDB.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddVisibleColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Section",
                table: "HL7Segments",
                newName: "section");

            migrationBuilder.AddColumn<bool>(
                name: "visible",
                table: "HL7Segments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "visible",
                table: "HL7Segments");

            migrationBuilder.RenameColumn(
                name: "section",
                table: "HL7Segments",
                newName: "Section");
        }
    }
}
