using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class NewModelsV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Deals_DealId",
                table: "Advertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Houses_HouseId",
                table: "Advertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Statuses_DealTypeId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Houses_HouseId",
                table: "Floors");

            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Statuses_ToiletTypeId",
                table: "Floors");

            migrationBuilder.DropForeignKey(
                name: "FK_staticDatas_staticDataGroups_GroupId",
                table: "staticDatas");

            migrationBuilder.DropTable(
                name: "AdvertisementKeyword");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "FloorMaterial");

            migrationBuilder.DropTable(
                name: "HouseImage");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "keywords");

            migrationBuilder.DropTable(
                name: "materials");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_staticDatas",
                table: "staticDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_staticDataGroups",
                table: "staticDataGroups");

            migrationBuilder.DropIndex(
                name: "IX_Floors_HouseId",
                table: "Floors");

            migrationBuilder.DropIndex(
                name: "IX_Floors_ToiletTypeId",
                table: "Floors");

            migrationBuilder.DropIndex(
                name: "IX_Deals_DealTypeId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_DealId",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_HouseId",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "BalconyArea",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "ConstructionDirection",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "CoolingStatus",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "HasBalcony",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "HasStorage",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "HeatingStatus",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "HotWaterStatus",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "RoomCount",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "ToiletTypeId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "DealTypeId",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "DownPayment",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "FinalDownPayment",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "FinalMonthlyPayment",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "FinalTotalPrice",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "HaveOffer",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "IsExchangeable",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "MonthlyPayment",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "DealId",
                table: "Advertisements");

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
                name: "HouseId",
                table: "Advertisements");

            migrationBuilder.RenameTable(
                name: "staticDatas",
                newName: "StaticDatas");

            migrationBuilder.RenameTable(
                name: "staticDataGroups",
                newName: "StaticDataGroups");

            migrationBuilder.RenameIndex(
                name: "IX_staticDatas_GroupId",
                table: "StaticDatas",
                newName: "IX_StaticDatas_GroupId");

            migrationBuilder.RenameColumn(
                name: "Water",
                table: "Floors",
                newName: "WaterType");

            migrationBuilder.RenameColumn(
                name: "StorageArea",
                table: "Floors",
                newName: "CommercialArea");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Floors",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Gas",
                table: "Floors",
                newName: "PrivateDescription");

            migrationBuilder.RenameColumn(
                name: "Electricity",
                table: "Floors",
                newName: "LandlineType");

            migrationBuilder.AlterColumn<double>(
                name: "Infrastructure",
                table: "Floors",
                type: "float",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Floors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Floors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElectricityType",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GasType",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParkingCount",
                table: "Floors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomsCount",
                table: "Floors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Deals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Deals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DealType",
                table: "Deals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DepositPrice",
                table: "Deals",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Deals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MortgagePrice",
                table: "Deals",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PreSalePrice",
                table: "Deals",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RentPrice",
                table: "Deals",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SalePrice",
                table: "Deals",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Deals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TitleFa",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TitleEn",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TitleAr",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ContentAr",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentEn",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentFa",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Advertisements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Advertisements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValidityPeriod",
                table: "Advertisements",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaticDatas",
                table: "StaticDatas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaticDataGroups",
                table: "StaticDataGroups",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    PropertyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AggregationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionYear = table.Column<int>(type: "int", nullable: true),
                    Area = table.Column<double>(type: "float", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: true),
                    Width = table.Column<double>(type: "float", nullable: true),
                    PassageWidth = table.Column<double>(type: "float", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeadlock = table.Column<bool>(type: "bit", nullable: true),
                    InputSeparate = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Property_Advertisement_FloorRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    AdvertisementId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Advertisement_FloorRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Advertisement_FloorRelations_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Advertisement_FloorRelations_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Advertisement_FloorRelations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Property_Applicant_FloorRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    ApplicantId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Applicant_FloorRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Applicant_FloorRelations_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Applicant_FloorRelations_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Applicant_FloorRelations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Property_Deal_FloorRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    DealId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Deal_FloorRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Deal_FloorRelations_Deals_DealId",
                        column: x => x.DealId,
                        principalTable: "Deals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Deal_FloorRelations_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Deal_FloorRelations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Property_FloorRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_FloorRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_FloorRelations_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_FloorRelations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Property_Location_FloorRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Location_FloorRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Location_FloorRelations_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Location_FloorRelations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Location_FloorRelations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Property_PropertyImage_FloorRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    PropertyImageId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_PropertyImage_FloorRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_PropertyImage_FloorRelations_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_PropertyImage_FloorRelations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_PropertyImage_FloorRelations_PropertyImages_PropertyImageId",
                        column: x => x.PropertyImageId,
                        principalTable: "PropertyImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Location_CityRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    NeighborhoodId = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location_CityRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_CityRelations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Location_CityRelations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Location_CityRelations_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Location_CityRelations_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Property_Supplier_FloorRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Supplier_FloorRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Supplier_FloorRelations_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Supplier_FloorRelations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Supplier_FloorRelations_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Property_Tag_FloorRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    TagId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Tag_FloorRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Tag_FloorRelations_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Tag_FloorRelations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_Tag_FloorRelations_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Location_CityRelations_CityId",
                table: "Location_CityRelations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CityRelations_LocationId",
                table: "Location_CityRelations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CityRelations_NeighborhoodId",
                table: "Location_CityRelations",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CityRelations_ProvinceId",
                table: "Location_CityRelations",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Advertisement_FloorRelations_AdvertisementId",
                table: "Property_Advertisement_FloorRelations",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Advertisement_FloorRelations_FloorId",
                table: "Property_Advertisement_FloorRelations",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Advertisement_FloorRelations_PropertyId",
                table: "Property_Advertisement_FloorRelations",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Applicant_FloorRelations_ApplicantId",
                table: "Property_Applicant_FloorRelations",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Applicant_FloorRelations_FloorId",
                table: "Property_Applicant_FloorRelations",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Applicant_FloorRelations_PropertyId",
                table: "Property_Applicant_FloorRelations",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Deal_FloorRelations_DealId",
                table: "Property_Deal_FloorRelations",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Deal_FloorRelations_FloorId",
                table: "Property_Deal_FloorRelations",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Deal_FloorRelations_PropertyId",
                table: "Property_Deal_FloorRelations",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_FloorRelations_FloorId",
                table: "Property_FloorRelations",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_FloorRelations_PropertyId",
                table: "Property_FloorRelations",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Location_FloorRelations_FloorId",
                table: "Property_Location_FloorRelations",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Location_FloorRelations_LocationId",
                table: "Property_Location_FloorRelations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Location_FloorRelations_PropertyId",
                table: "Property_Location_FloorRelations",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyImage_FloorRelations_FloorId",
                table: "Property_PropertyImage_FloorRelations",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyImage_FloorRelations_PropertyId",
                table: "Property_PropertyImage_FloorRelations",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyImage_FloorRelations_PropertyImageId",
                table: "Property_PropertyImage_FloorRelations",
                column: "PropertyImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Supplier_FloorRelations_FloorId",
                table: "Property_Supplier_FloorRelations",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Supplier_FloorRelations_PropertyId",
                table: "Property_Supplier_FloorRelations",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Supplier_FloorRelations_SupplierId",
                table: "Property_Supplier_FloorRelations",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Tag_FloorRelations_FloorId",
                table: "Property_Tag_FloorRelations",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Tag_FloorRelations_PropertyId",
                table: "Property_Tag_FloorRelations",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Tag_FloorRelations_TagId",
                table: "Property_Tag_FloorRelations",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_StaticDatas_StaticDataGroups_GroupId",
                table: "StaticDatas",
                column: "GroupId",
                principalTable: "StaticDataGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaticDatas_StaticDataGroups_GroupId",
                table: "StaticDatas");

            migrationBuilder.DropTable(
                name: "Location_CityRelations");

            migrationBuilder.DropTable(
                name: "Property_Advertisement_FloorRelations");

            migrationBuilder.DropTable(
                name: "Property_Applicant_FloorRelations");

            migrationBuilder.DropTable(
                name: "Property_Deal_FloorRelations");

            migrationBuilder.DropTable(
                name: "Property_FloorRelations");

            migrationBuilder.DropTable(
                name: "Property_Location_FloorRelations");

            migrationBuilder.DropTable(
                name: "Property_PropertyImage_FloorRelations");

            migrationBuilder.DropTable(
                name: "Property_Supplier_FloorRelations");

            migrationBuilder.DropTable(
                name: "Property_Tag_FloorRelations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "PropertyImages");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaticDatas",
                table: "StaticDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaticDataGroups",
                table: "StaticDataGroups");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "ElectricityType",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "GasType",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "ParkingCount",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "RoomsCount",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "DealType",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "DepositPrice",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "MortgagePrice",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "PreSalePrice",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "RentPrice",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "ContentAr",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "ContentEn",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "ContentFa",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "ValidityPeriod",
                table: "Advertisements");

            migrationBuilder.RenameTable(
                name: "StaticDatas",
                newName: "staticDatas");

            migrationBuilder.RenameTable(
                name: "StaticDataGroups",
                newName: "staticDataGroups");

            migrationBuilder.RenameIndex(
                name: "IX_StaticDatas_GroupId",
                table: "staticDatas",
                newName: "IX_staticDatas_GroupId");

            migrationBuilder.RenameColumn(
                name: "WaterType",
                table: "Floors",
                newName: "Water");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Floors",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "PrivateDescription",
                table: "Floors",
                newName: "Gas");

            migrationBuilder.RenameColumn(
                name: "LandlineType",
                table: "Floors",
                newName: "Electricity");

            migrationBuilder.RenameColumn(
                name: "CommercialArea",
                table: "Floors",
                newName: "StorageArea");

            migrationBuilder.AlterColumn<short>(
                name: "Infrastructure",
                table: "Floors",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "Floors",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BalconyArea",
                table: "Floors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Floors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConstructionDirection",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CoolingStatus",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasBalcony",
                table: "Floors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasStorage",
                table: "Floors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HeatingStatus",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HotWaterStatus",
                table: "Floors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Floors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomCount",
                table: "Floors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToiletTypeId",
                table: "Floors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DealTypeId",
                table: "Deals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "DownPayment",
                table: "Deals",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FinalDownPayment",
                table: "Deals",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FinalMonthlyPayment",
                table: "Deals",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FinalTotalPrice",
                table: "Deals",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "HaveOffer",
                table: "Deals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExchangeable",
                table: "Deals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyPayment",
                table: "Deals",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Deals",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "TitleFa",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TitleEn",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TitleAr",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealId",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_staticDatas",
                table: "staticDatas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staticDataGroups",
                table: "staticDataGroups",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpertAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsMaster = table.Column<int>(type: "int", nullable: true),
                    LastLoginDate = table.Column<int>(type: "int", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SummaryAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SummaryEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SummaryFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmenitiesAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmenitiesEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmenitiesFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingArea = table.Column<double>(type: "float", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorCount = table.Column<int>(type: "int", nullable: true),
                    HasElevator = table.Column<bool>(type: "bit", nullable: false),
                    HasParking = table.Column<bool>(type: "bit", nullable: false),
                    HasPool = table.Column<bool>(type: "bit", nullable: false),
                    LandArea = table.Column<double>(type: "float", nullable: true),
                    NearbyFacilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkingCount = table.Column<int>(type: "int", nullable: true),
                    PoolArea = table.Column<double>(type: "float", nullable: true),
                    PropertyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TreeCount = table.Column<int>(type: "int", nullable: true),
                    UnitNumber = table.Column<int>(type: "int", nullable: true),
                    YearRenovated = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "keywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentFa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keywords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseImage_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertisementKeyword",
                columns: table => new
                {
                    AdvertisementsId = table.Column<int>(type: "int", nullable: false),
                    KeywordsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementKeyword", x => new { x.AdvertisementsId, x.KeywordsId });
                    table.ForeignKey(
                        name: "FK_AdvertisementKeyword_Advertisements_AdvertisementsId",
                        column: x => x.AdvertisementsId,
                        principalTable: "Advertisements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertisementKeyword_keywords_KeywordsId",
                        column: x => x.KeywordsId,
                        principalTable: "keywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FloorMaterial",
                columns: table => new
                {
                    FloorMaterialsId = table.Column<int>(type: "int", nullable: false),
                    FloorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorMaterial", x => new { x.FloorMaterialsId, x.FloorsId });
                    table.ForeignKey(
                        name: "FK_FloorMaterial_Floors_FloorsId",
                        column: x => x.FloorsId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FloorMaterial_materials_FloorMaterialsId",
                        column: x => x.FloorMaterialsId,
                        principalTable: "materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Floors_HouseId",
                table: "Floors",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_ToiletTypeId",
                table: "Floors",
                column: "ToiletTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_DealTypeId",
                table: "Deals",
                column: "DealTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_DealId",
                table: "Advertisements",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_HouseId",
                table: "Advertisements",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementKeyword_KeywordsId",
                table: "AdvertisementKeyword",
                column: "KeywordsId");

            migrationBuilder.CreateIndex(
                name: "IX_FloorMaterial_FloorsId",
                table: "FloorMaterial",
                column: "FloorsId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseImage_HouseId",
                table: "HouseImage",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Deals_DealId",
                table: "Advertisements",
                column: "DealId",
                principalTable: "Deals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Houses_HouseId",
                table: "Advertisements",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Statuses_DealTypeId",
                table: "Deals",
                column: "DealTypeId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Houses_HouseId",
                table: "Floors",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Statuses_ToiletTypeId",
                table: "Floors",
                column: "ToiletTypeId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_staticDatas_staticDataGroups_GroupId",
                table: "staticDatas",
                column: "GroupId",
                principalTable: "staticDataGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
