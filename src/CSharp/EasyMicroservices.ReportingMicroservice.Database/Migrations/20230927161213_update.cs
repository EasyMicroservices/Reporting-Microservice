using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMicroservices.ReportingMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiationDateTime",
                table: "Reporting");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentity",
                table: "Reporting",
                type: "nvarchar(450)",
                nullable: true,
                collation: "SQL_Latin1_General_CP1_CS_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDateTime",
                table: "Reporting",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Reporting",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Reporting",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ParentId",
                table: "Reporting",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_CreationDateTime",
                table: "Reporting",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_DeletedDateTime",
                table: "Reporting",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_IsDeleted",
                table: "Reporting",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ModificationDateTime",
                table: "Reporting",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_UniqueIdentity",
                table: "Reporting",
                column: "UniqueIdentity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reporting_CreationDateTime",
                table: "Reporting");

            migrationBuilder.DropIndex(
                name: "IX_Reporting_DeletedDateTime",
                table: "Reporting");

            migrationBuilder.DropIndex(
                name: "IX_Reporting_IsDeleted",
                table: "Reporting");

            migrationBuilder.DropIndex(
                name: "IX_Reporting_ModificationDateTime",
                table: "Reporting");

            migrationBuilder.DropIndex(
                name: "IX_Reporting_UniqueIdentity",
                table: "Reporting");

            migrationBuilder.DropColumn(
                name: "DeletedDateTime",
                table: "Reporting");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Reporting");

            migrationBuilder.DropColumn(
                name: "ModificationDateTime",
                table: "Reporting");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Reporting");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentity",
                table: "Reporting",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldCollation: "SQL_Latin1_General_CP1_CS_AS");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiationDateTime",
                table: "Reporting",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
