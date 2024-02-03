using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMicroservices.ReportingMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class ApllyUniqueIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UniqueIdentity",
                table: "Reporting",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueIdentity",
                table: "Reporting");
        }
    }
}
