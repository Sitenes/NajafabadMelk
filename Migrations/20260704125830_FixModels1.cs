using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class FixModels1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Electricity",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FloorNo",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gas",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "Infrastructure",
                table: "Floors",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Water",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Agents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IsMaster",
                table: "Agents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastLoginDate",
                table: "Agents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Agents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Post",
                table: "Agents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Agents",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Electricity",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "FloorNo",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Gas",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Infrastructure",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Water",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "IsMaster",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "LastLoginDate",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "Post",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Agents");
        }
    }
}
