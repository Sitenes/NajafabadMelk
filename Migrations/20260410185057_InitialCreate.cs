using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConstructionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasParking = table.Column<bool>(type: "bit", nullable: false),
                    ParkingCount = table.Column<int>(type: "int", nullable: true),
                    Deed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasPool = table.Column<bool>(type: "bit", nullable: false),
                    PoolArea = table.Column<double>(type: "float", nullable: true),
                    TreeCount = table.Column<int>(type: "int", nullable: true),
                    HasElevator = table.Column<bool>(type: "bit", nullable: false),
                    FloorCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseId = table.Column<int>(type: "int", nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisements_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<double>(type: "float", nullable: false),
                    RoomCount = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    HasBalcony = table.Column<bool>(type: "bit", nullable: false),
                    BalconyArea = table.Column<double>(type: "float", nullable: true),
                    HasStorage = table.Column<bool>(type: "bit", nullable: false),
                    StorageArea = table.Column<double>(type: "float", nullable: true),
                    ConstructionDirection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoolingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeatingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotWaterStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloorMaterials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WallMaterials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToiletTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floors_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DownPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MonthlyPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsExchangeable = table.Column<bool>(type: "bit", nullable: false),
                    AdvertisementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deals_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_HouseId",
                table: "Advertisements",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_AdvertisementId",
                table: "Deals",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_HouseId",
                table: "Floors",
                column: "HouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deals");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
