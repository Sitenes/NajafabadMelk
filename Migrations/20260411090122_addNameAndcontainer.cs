using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class addNameAndcontainer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "staticDataGroups",
                newName: "Page");

            migrationBuilder.AddColumn<string>(
                name: "Container",
                table: "staticDataGroups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Container",
                table: "staticDataGroups");

            migrationBuilder.RenameColumn(
                name: "Page",
                table: "staticDataGroups",
                newName: "Name");
        }
    }
}
