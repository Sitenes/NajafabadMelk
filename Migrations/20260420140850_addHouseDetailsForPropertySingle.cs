using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class addHouseDetailsForPropertySingle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AmenitiesAr",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AmenitiesEn",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AmenitiesFa",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "BuildingArea",
                table: "Houses",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LandArea",
                table: "Houses",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NearbyFacilities",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyCode",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitNumber",
                table: "Houses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearRenovated",
                table: "Houses",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "AmenitiesAr",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "AmenitiesEn",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "AmenitiesFa",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "BuildingArea",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "LandArea",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "NearbyFacilities",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "PropertyCode",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "UnitNumber",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "YearRenovated",
                table: "Houses");
        }
    }
}
