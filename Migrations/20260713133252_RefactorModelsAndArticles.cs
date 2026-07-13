using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class RefactorModelsAndArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Expandable",
                table: "Properties",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacadeType",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeographicalLocation",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Renovated",
                table: "Properties",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Retreat",
                table: "Properties",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "region",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrightnessLevel",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cabbie",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoolingSystem",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Elevator",
                table: "Floors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FloorCovering",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeatingSystem",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "KitchenArea",
                table: "Floors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LivingRoomArea",
                table: "Floors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Numberofkitchens",
                table: "Floors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherFacilities",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Staircase",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WCArea",
                table: "Floors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WCCount",
                table: "Floors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wardrobe",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yard",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "YardArea",
                table: "Floors",
                type: "float",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLoginDate = table.Column<int>(type: "int", nullable: true),
                    IsMaster = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImageAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SummaryFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SummaryEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SummaryAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    RoomArea = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: true),
                    Width = table.Column<double>(type: "float", nullable: true),
                    WindowCount = table.Column<int>(type: "int", nullable: true),
                    Wardrobe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floor_RoomRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor_RoomRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floor_RoomRelations_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Floor_RoomRelations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Floor_RoomRelations_FloorId",
                table: "Floor_RoomRelations",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Floor_RoomRelations_RoomId",
                table: "Floor_RoomRelations",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Floor_RoomRelations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropColumn(
                name: "Expandable",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "FacadeType",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "GeographicalLocation",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Renovated",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Retreat",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "region",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BrightnessLevel",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Cabbie",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "CoolingSystem",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Elevator",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "FloorCovering",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "HeatingSystem",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "KitchenArea",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "LivingRoomArea",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Numberofkitchens",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "OtherFacilities",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Staircase",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "WCArea",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "WCCount",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Wardrobe",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Yard",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "YardArea",
                table: "Floors");
        }
    }
}
