using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelGeneratorSourceDB.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddGuidPrimaryKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7Versions",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7Segments",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7SegmentDataElements",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7MsgStructIDSegments",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7MsgStructIDs",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7EventMessageTypeSegments",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7DataTypes",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7DataStructures",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7DataStructureComponents",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7DataElements",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "HL7Components",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7Versions",
                table: "HL7Versions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7Segments",
                table: "HL7Segments",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7SegmentDataElements",
                table: "HL7SegmentDataElements",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7MsgStructIDSegments",
                table: "HL7MsgStructIDSegments",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7MsgStructIDs",
                table: "HL7MsgStructIDs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7EventMessageTypeSegments",
                table: "HL7EventMessageTypeSegments",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7DataTypes",
                table: "HL7DataTypes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7DataStructures",
                table: "HL7DataStructures",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7DataStructureComponents",
                table: "HL7DataStructureComponents",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7DataElements",
                table: "HL7DataElements",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HL7Components",
                table: "HL7Components",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7Versions",
                table: "HL7Versions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7Segments",
                table: "HL7Segments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7SegmentDataElements",
                table: "HL7SegmentDataElements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7MsgStructIDSegments",
                table: "HL7MsgStructIDSegments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7MsgStructIDs",
                table: "HL7MsgStructIDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7EventMessageTypeSegments",
                table: "HL7EventMessageTypeSegments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7DataTypes",
                table: "HL7DataTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7DataStructures",
                table: "HL7DataStructures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7DataStructureComponents",
                table: "HL7DataStructureComponents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7DataElements",
                table: "HL7DataElements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HL7Components",
                table: "HL7Components");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7Versions");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7Segments");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7SegmentDataElements");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7MsgStructIDSegments");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7MsgStructIDs");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7EventMessageTypeSegments");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7DataTypes");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7DataStructures");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7DataStructureComponents");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7DataElements");

            migrationBuilder.DropColumn(
                name: "id",
                table: "HL7Components");
        }
    }
}
