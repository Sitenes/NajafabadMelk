using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class add3LangToModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "materials",
                newName: "ContentFa");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "keywords",
                newName: "ContentFa");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Advertisements",
                newName: "TitleFa");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Advertisements",
                newName: "TitleEn");

            migrationBuilder.AddColumn<string>(
                name: "ContentAr",
                table: "materials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentEn",
                table: "materials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentAr",
                table: "keywords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentEn",
                table: "keywords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionFa",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleAr",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentAr",
                table: "materials");

            migrationBuilder.DropColumn(
                name: "ContentEn",
                table: "materials");

            migrationBuilder.DropColumn(
                name: "ContentAr",
                table: "keywords");

            migrationBuilder.DropColumn(
                name: "ContentEn",
                table: "keywords");

            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "DescriptionFa",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "TitleAr",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "ContentFa",
                table: "materials",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "ContentFa",
                table: "keywords",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "TitleFa",
                table: "Advertisements",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "Advertisements",
                newName: "Description");
        }
    }
}
