using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class ChangeModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Floor_RoomRelations_Floors_FloorId",
                table: "Floor_RoomRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Floor_RoomRelations_Rooms_RoomId",
                table: "Floor_RoomRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CityRelations_Cities_CityId",
                table: "Location_CityRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CityRelations_Locations_LocationId",
                table: "Location_CityRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CityRelations_Neighborhoods_NeighborhoodId",
                table: "Location_CityRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CityRelations_Provinces_ProvinceId",
                table: "Location_CityRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Advertisement_FloorRelations_Advertisements_AdvertisementId",
                table: "Property_Advertisement_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Advertisement_FloorRelations_Floors_FloorId",
                table: "Property_Advertisement_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Advertisement_FloorRelations_Properties_PropertyId",
                table: "Property_Advertisement_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Applicant_FloorRelations_Applicants_ApplicantId",
                table: "Property_Applicant_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Applicant_FloorRelations_Floors_FloorId",
                table: "Property_Applicant_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Applicant_FloorRelations_Properties_PropertyId",
                table: "Property_Applicant_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Deal_FloorRelations_Deals_DealId",
                table: "Property_Deal_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Deal_FloorRelations_Floors_FloorId",
                table: "Property_Deal_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Deal_FloorRelations_Properties_PropertyId",
                table: "Property_Deal_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_FloorRelations_Floors_FloorId",
                table: "Property_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_FloorRelations_Properties_PropertyId",
                table: "Property_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Location_FloorRelations_Floors_FloorId",
                table: "Property_Location_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Location_FloorRelations_Locations_LocationId",
                table: "Property_Location_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Location_FloorRelations_Properties_PropertyId",
                table: "Property_Location_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyImage_FloorRelations_Floors_FloorId",
                table: "Property_PropertyImage_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyImage_FloorRelations_Properties_PropertyId",
                table: "Property_PropertyImage_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyImage_FloorRelations_PropertyImages_PropertyImageId",
                table: "Property_PropertyImage_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Supplier_FloorRelations_Floors_FloorId",
                table: "Property_Supplier_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Supplier_FloorRelations_Properties_PropertyId",
                table: "Property_Supplier_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Supplier_FloorRelations_Suppliers_SupplierId",
                table: "Property_Supplier_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Tag_FloorRelations_Floors_FloorId",
                table: "Property_Tag_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Tag_FloorRelations_Properties_PropertyId",
                table: "Property_Tag_FloorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Tag_FloorRelations_Tags_TagId",
                table: "Property_Tag_FloorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyImages",
                table: "PropertyImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Tag_FloorRelations",
                table: "Property_Tag_FloorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Supplier_FloorRelations",
                table: "Property_Supplier_FloorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_PropertyImage_FloorRelations",
                table: "Property_PropertyImage_FloorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Location_FloorRelations",
                table: "Property_Location_FloorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_FloorRelations",
                table: "Property_FloorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Deal_FloorRelations",
                table: "Property_Deal_FloorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Applicant_FloorRelations",
                table: "Property_Applicant_FloorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Advertisement_FloorRelations",
                table: "Property_Advertisement_FloorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Neighborhoods",
                table: "Neighborhoods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location_CityRelations",
                table: "Location_CityRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Floors",
                table: "Floors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Floor_RoomRelations",
                table: "Floor_RoomRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deals",
                table: "Deals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applicants",
                table: "Applicants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advertisements",
                table: "Advertisements");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Supplier");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "Room");

            migrationBuilder.RenameTable(
                name: "Provinces",
                newName: "Province");

            migrationBuilder.RenameTable(
                name: "PropertyImages",
                newName: "PropertyImage");

            migrationBuilder.RenameTable(
                name: "Property_Tag_FloorRelations",
                newName: "Property_Tag_FloorRelation");

            migrationBuilder.RenameTable(
                name: "Property_Supplier_FloorRelations",
                newName: "Property_Supplier_FloorRelation");

            migrationBuilder.RenameTable(
                name: "Property_PropertyImage_FloorRelations",
                newName: "Property_PropertyImage_FloorRelation");

            migrationBuilder.RenameTable(
                name: "Property_Location_FloorRelations",
                newName: "Property_Location_FloorRelation");

            migrationBuilder.RenameTable(
                name: "Property_FloorRelations",
                newName: "Property_FloorRelation");

            migrationBuilder.RenameTable(
                name: "Property_Deal_FloorRelations",
                newName: "Property_Deal_FloorRelation");

            migrationBuilder.RenameTable(
                name: "Property_Applicant_FloorRelations",
                newName: "Property_Applicant_FloorRelation");

            migrationBuilder.RenameTable(
                name: "Property_Advertisement_FloorRelations",
                newName: "Property_Advertisement_FloorRelation");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "Property");

            migrationBuilder.RenameTable(
                name: "Neighborhoods",
                newName: "Neighborhood");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "Location_CityRelations",
                newName: "Location_CityRelation");

            migrationBuilder.RenameTable(
                name: "Floors",
                newName: "Floor");

            migrationBuilder.RenameTable(
                name: "Floor_RoomRelations",
                newName: "Floor_RoomRelation");

            migrationBuilder.RenameTable(
                name: "Deals",
                newName: "Deal");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "Applicants",
                newName: "Applicant");

            migrationBuilder.RenameTable(
                name: "Advertisements",
                newName: "Advertisement");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Tag_FloorRelations_TagId",
                table: "Property_Tag_FloorRelation",
                newName: "IX_Property_Tag_FloorRelation_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Tag_FloorRelations_PropertyId",
                table: "Property_Tag_FloorRelation",
                newName: "IX_Property_Tag_FloorRelation_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Tag_FloorRelations_FloorId",
                table: "Property_Tag_FloorRelation",
                newName: "IX_Property_Tag_FloorRelation_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Supplier_FloorRelations_SupplierId",
                table: "Property_Supplier_FloorRelation",
                newName: "IX_Property_Supplier_FloorRelation_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Supplier_FloorRelations_PropertyId",
                table: "Property_Supplier_FloorRelation",
                newName: "IX_Property_Supplier_FloorRelation_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Supplier_FloorRelations_FloorId",
                table: "Property_Supplier_FloorRelation",
                newName: "IX_Property_Supplier_FloorRelation_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_PropertyImage_FloorRelations_PropertyImageId",
                table: "Property_PropertyImage_FloorRelation",
                newName: "IX_Property_PropertyImage_FloorRelation_PropertyImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_PropertyImage_FloorRelations_PropertyId",
                table: "Property_PropertyImage_FloorRelation",
                newName: "IX_Property_PropertyImage_FloorRelation_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_PropertyImage_FloorRelations_FloorId",
                table: "Property_PropertyImage_FloorRelation",
                newName: "IX_Property_PropertyImage_FloorRelation_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Location_FloorRelations_PropertyId",
                table: "Property_Location_FloorRelation",
                newName: "IX_Property_Location_FloorRelation_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Location_FloorRelations_LocationId",
                table: "Property_Location_FloorRelation",
                newName: "IX_Property_Location_FloorRelation_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Location_FloorRelations_FloorId",
                table: "Property_Location_FloorRelation",
                newName: "IX_Property_Location_FloorRelation_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_FloorRelations_PropertyId",
                table: "Property_FloorRelation",
                newName: "IX_Property_FloorRelation_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_FloorRelations_FloorId",
                table: "Property_FloorRelation",
                newName: "IX_Property_FloorRelation_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Deal_FloorRelations_PropertyId",
                table: "Property_Deal_FloorRelation",
                newName: "IX_Property_Deal_FloorRelation_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Deal_FloorRelations_FloorId",
                table: "Property_Deal_FloorRelation",
                newName: "IX_Property_Deal_FloorRelation_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Deal_FloorRelations_DealId",
                table: "Property_Deal_FloorRelation",
                newName: "IX_Property_Deal_FloorRelation_DealId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Applicant_FloorRelations_PropertyId",
                table: "Property_Applicant_FloorRelation",
                newName: "IX_Property_Applicant_FloorRelation_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Applicant_FloorRelations_FloorId",
                table: "Property_Applicant_FloorRelation",
                newName: "IX_Property_Applicant_FloorRelation_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Applicant_FloorRelations_ApplicantId",
                table: "Property_Applicant_FloorRelation",
                newName: "IX_Property_Applicant_FloorRelation_ApplicantId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Advertisement_FloorRelations_PropertyId",
                table: "Property_Advertisement_FloorRelation",
                newName: "IX_Property_Advertisement_FloorRelation_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Advertisement_FloorRelations_FloorId",
                table: "Property_Advertisement_FloorRelation",
                newName: "IX_Property_Advertisement_FloorRelation_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Advertisement_FloorRelations_AdvertisementId",
                table: "Property_Advertisement_FloorRelation",
                newName: "IX_Property_Advertisement_FloorRelation_AdvertisementId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityRelations_ProvinceId",
                table: "Location_CityRelation",
                newName: "IX_Location_CityRelation_ProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityRelations_NeighborhoodId",
                table: "Location_CityRelation",
                newName: "IX_Location_CityRelation_NeighborhoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityRelations_LocationId",
                table: "Location_CityRelation",
                newName: "IX_Location_CityRelation_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityRelations_CityId",
                table: "Location_CityRelation",
                newName: "IX_Location_CityRelation_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Floor_RoomRelations_RoomId",
                table: "Floor_RoomRelation",
                newName: "IX_Floor_RoomRelation_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Floor_RoomRelations_FloorId",
                table: "Floor_RoomRelation",
                newName: "IX_Floor_RoomRelation_FloorId");

            migrationBuilder.AlterColumn<string>(
                name: "ImageAddress",
                table: "Agents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Province",
                table: "Province",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyImage",
                table: "PropertyImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Tag_FloorRelation",
                table: "Property_Tag_FloorRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Supplier_FloorRelation",
                table: "Property_Supplier_FloorRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_PropertyImage_FloorRelation",
                table: "Property_PropertyImage_FloorRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Location_FloorRelation",
                table: "Property_Location_FloorRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_FloorRelation",
                table: "Property_FloorRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Deal_FloorRelation",
                table: "Property_Deal_FloorRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Applicant_FloorRelation",
                table: "Property_Applicant_FloorRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Advertisement_FloorRelation",
                table: "Property_Advertisement_FloorRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property",
                table: "Property",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Neighborhood",
                table: "Neighborhood",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location_CityRelation",
                table: "Location_CityRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Floor",
                table: "Floor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Floor_RoomRelation",
                table: "Floor_RoomRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deal",
                table: "Deal",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applicant",
                table: "Applicant",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advertisement",
                table: "Advertisement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Floor_RoomRelation_Floor_FloorId",
                table: "Floor_RoomRelation",
                column: "FloorId",
                principalTable: "Floor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Floor_RoomRelation_Room_RoomId",
                table: "Floor_RoomRelation",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CityRelation_City_CityId",
                table: "Location_CityRelation",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CityRelation_Location_LocationId",
                table: "Location_CityRelation",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CityRelation_Neighborhood_NeighborhoodId",
                table: "Location_CityRelation",
                column: "NeighborhoodId",
                principalTable: "Neighborhood",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CityRelation_Province_ProvinceId",
                table: "Location_CityRelation",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Advertisement_FloorRelation_Advertisement_AdvertisementId",
                table: "Property_Advertisement_FloorRelation",
                column: "AdvertisementId",
                principalTable: "Advertisement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Advertisement_FloorRelation_Floor_FloorId",
                table: "Property_Advertisement_FloorRelation",
                column: "FloorId",
                principalTable: "Floor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Advertisement_FloorRelation_Property_PropertyId",
                table: "Property_Advertisement_FloorRelation",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Applicant_FloorRelation_Applicant_ApplicantId",
                table: "Property_Applicant_FloorRelation",
                column: "ApplicantId",
                principalTable: "Applicant",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Applicant_FloorRelation_Floor_FloorId",
                table: "Property_Applicant_FloorRelation",
                column: "FloorId",
                principalTable: "Floor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Applicant_FloorRelation_Property_PropertyId",
                table: "Property_Applicant_FloorRelation",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Deal_FloorRelation_Deal_DealId",
                table: "Property_Deal_FloorRelation",
                column: "DealId",
                principalTable: "Deal",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Deal_FloorRelation_Floor_FloorId",
                table: "Property_Deal_FloorRelation",
                column: "FloorId",
                principalTable: "Floor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Deal_FloorRelation_Property_PropertyId",
                table: "Property_Deal_FloorRelation",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_FloorRelation_Floor_FloorId",
                table: "Property_FloorRelation",
                column: "FloorId",
                principalTable: "Floor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_FloorRelation_Property_PropertyId",
                table: "Property_FloorRelation",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Location_FloorRelation_Floor_FloorId",
                table: "Property_Location_FloorRelation",
                column: "FloorId",
                principalTable: "Floor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Location_FloorRelation_Location_LocationId",
                table: "Property_Location_FloorRelation",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Location_FloorRelation_Property_PropertyId",
                table: "Property_Location_FloorRelation",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyImage_FloorRelation_Floor_FloorId",
                table: "Property_PropertyImage_FloorRelation",
                column: "FloorId",
                principalTable: "Floor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyImage_FloorRelation_PropertyImage_PropertyImageId",
                table: "Property_PropertyImage_FloorRelation",
                column: "PropertyImageId",
                principalTable: "PropertyImage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyImage_FloorRelation_Property_PropertyId",
                table: "Property_PropertyImage_FloorRelation",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Supplier_FloorRelation_Floor_FloorId",
                table: "Property_Supplier_FloorRelation",
                column: "FloorId",
                principalTable: "Floor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Supplier_FloorRelation_Property_PropertyId",
                table: "Property_Supplier_FloorRelation",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Supplier_FloorRelation_Supplier_SupplierId",
                table: "Property_Supplier_FloorRelation",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Tag_FloorRelation_Floor_FloorId",
                table: "Property_Tag_FloorRelation",
                column: "FloorId",
                principalTable: "Floor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Tag_FloorRelation_Property_PropertyId",
                table: "Property_Tag_FloorRelation",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Tag_FloorRelation_Tag_TagId",
                table: "Property_Tag_FloorRelation",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Floor_RoomRelation_Floor_FloorId",
                table: "Floor_RoomRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Floor_RoomRelation_Room_RoomId",
                table: "Floor_RoomRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CityRelation_City_CityId",
                table: "Location_CityRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CityRelation_Location_LocationId",
                table: "Location_CityRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CityRelation_Neighborhood_NeighborhoodId",
                table: "Location_CityRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CityRelation_Province_ProvinceId",
                table: "Location_CityRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Advertisement_FloorRelation_Advertisement_AdvertisementId",
                table: "Property_Advertisement_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Advertisement_FloorRelation_Floor_FloorId",
                table: "Property_Advertisement_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Advertisement_FloorRelation_Property_PropertyId",
                table: "Property_Advertisement_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Applicant_FloorRelation_Applicant_ApplicantId",
                table: "Property_Applicant_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Applicant_FloorRelation_Floor_FloorId",
                table: "Property_Applicant_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Applicant_FloorRelation_Property_PropertyId",
                table: "Property_Applicant_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Deal_FloorRelation_Deal_DealId",
                table: "Property_Deal_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Deal_FloorRelation_Floor_FloorId",
                table: "Property_Deal_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Deal_FloorRelation_Property_PropertyId",
                table: "Property_Deal_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_FloorRelation_Floor_FloorId",
                table: "Property_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_FloorRelation_Property_PropertyId",
                table: "Property_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Location_FloorRelation_Floor_FloorId",
                table: "Property_Location_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Location_FloorRelation_Location_LocationId",
                table: "Property_Location_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Location_FloorRelation_Property_PropertyId",
                table: "Property_Location_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyImage_FloorRelation_Floor_FloorId",
                table: "Property_PropertyImage_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyImage_FloorRelation_PropertyImage_PropertyImageId",
                table: "Property_PropertyImage_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyImage_FloorRelation_Property_PropertyId",
                table: "Property_PropertyImage_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Supplier_FloorRelation_Floor_FloorId",
                table: "Property_Supplier_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Supplier_FloorRelation_Property_PropertyId",
                table: "Property_Supplier_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Supplier_FloorRelation_Supplier_SupplierId",
                table: "Property_Supplier_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Tag_FloorRelation_Floor_FloorId",
                table: "Property_Tag_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Tag_FloorRelation_Property_PropertyId",
                table: "Property_Tag_FloorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Tag_FloorRelation_Tag_TagId",
                table: "Property_Tag_FloorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Province",
                table: "Province");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyImage",
                table: "PropertyImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Tag_FloorRelation",
                table: "Property_Tag_FloorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Supplier_FloorRelation",
                table: "Property_Supplier_FloorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_PropertyImage_FloorRelation",
                table: "Property_PropertyImage_FloorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Location_FloorRelation",
                table: "Property_Location_FloorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_FloorRelation",
                table: "Property_FloorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Deal_FloorRelation",
                table: "Property_Deal_FloorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Applicant_FloorRelation",
                table: "Property_Applicant_FloorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property_Advertisement_FloorRelation",
                table: "Property_Advertisement_FloorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property",
                table: "Property");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Neighborhood",
                table: "Neighborhood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location_CityRelation",
                table: "Location_CityRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Floor_RoomRelation",
                table: "Floor_RoomRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Floor",
                table: "Floor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deal",
                table: "Deal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applicant",
                table: "Applicant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advertisement",
                table: "Advertisement");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "Room",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "Province",
                newName: "Provinces");

            migrationBuilder.RenameTable(
                name: "PropertyImage",
                newName: "PropertyImages");

            migrationBuilder.RenameTable(
                name: "Property_Tag_FloorRelation",
                newName: "Property_Tag_FloorRelations");

            migrationBuilder.RenameTable(
                name: "Property_Supplier_FloorRelation",
                newName: "Property_Supplier_FloorRelations");

            migrationBuilder.RenameTable(
                name: "Property_PropertyImage_FloorRelation",
                newName: "Property_PropertyImage_FloorRelations");

            migrationBuilder.RenameTable(
                name: "Property_Location_FloorRelation",
                newName: "Property_Location_FloorRelations");

            migrationBuilder.RenameTable(
                name: "Property_FloorRelation",
                newName: "Property_FloorRelations");

            migrationBuilder.RenameTable(
                name: "Property_Deal_FloorRelation",
                newName: "Property_Deal_FloorRelations");

            migrationBuilder.RenameTable(
                name: "Property_Applicant_FloorRelation",
                newName: "Property_Applicant_FloorRelations");

            migrationBuilder.RenameTable(
                name: "Property_Advertisement_FloorRelation",
                newName: "Property_Advertisement_FloorRelations");

            migrationBuilder.RenameTable(
                name: "Property",
                newName: "Properties");

            migrationBuilder.RenameTable(
                name: "Neighborhood",
                newName: "Neighborhoods");

            migrationBuilder.RenameTable(
                name: "Location_CityRelation",
                newName: "Location_CityRelations");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "Floor_RoomRelation",
                newName: "Floor_RoomRelations");

            migrationBuilder.RenameTable(
                name: "Floor",
                newName: "Floors");

            migrationBuilder.RenameTable(
                name: "Deal",
                newName: "Deals");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "Applicant",
                newName: "Applicants");

            migrationBuilder.RenameTable(
                name: "Advertisement",
                newName: "Advertisements");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Tag_FloorRelation_TagId",
                table: "Property_Tag_FloorRelations",
                newName: "IX_Property_Tag_FloorRelations_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Tag_FloorRelation_PropertyId",
                table: "Property_Tag_FloorRelations",
                newName: "IX_Property_Tag_FloorRelations_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Tag_FloorRelation_FloorId",
                table: "Property_Tag_FloorRelations",
                newName: "IX_Property_Tag_FloorRelations_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Supplier_FloorRelation_SupplierId",
                table: "Property_Supplier_FloorRelations",
                newName: "IX_Property_Supplier_FloorRelations_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Supplier_FloorRelation_PropertyId",
                table: "Property_Supplier_FloorRelations",
                newName: "IX_Property_Supplier_FloorRelations_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Supplier_FloorRelation_FloorId",
                table: "Property_Supplier_FloorRelations",
                newName: "IX_Property_Supplier_FloorRelations_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_PropertyImage_FloorRelation_PropertyImageId",
                table: "Property_PropertyImage_FloorRelations",
                newName: "IX_Property_PropertyImage_FloorRelations_PropertyImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_PropertyImage_FloorRelation_PropertyId",
                table: "Property_PropertyImage_FloorRelations",
                newName: "IX_Property_PropertyImage_FloorRelations_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_PropertyImage_FloorRelation_FloorId",
                table: "Property_PropertyImage_FloorRelations",
                newName: "IX_Property_PropertyImage_FloorRelations_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Location_FloorRelation_PropertyId",
                table: "Property_Location_FloorRelations",
                newName: "IX_Property_Location_FloorRelations_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Location_FloorRelation_LocationId",
                table: "Property_Location_FloorRelations",
                newName: "IX_Property_Location_FloorRelations_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Location_FloorRelation_FloorId",
                table: "Property_Location_FloorRelations",
                newName: "IX_Property_Location_FloorRelations_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_FloorRelation_PropertyId",
                table: "Property_FloorRelations",
                newName: "IX_Property_FloorRelations_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_FloorRelation_FloorId",
                table: "Property_FloorRelations",
                newName: "IX_Property_FloorRelations_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Deal_FloorRelation_PropertyId",
                table: "Property_Deal_FloorRelations",
                newName: "IX_Property_Deal_FloorRelations_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Deal_FloorRelation_FloorId",
                table: "Property_Deal_FloorRelations",
                newName: "IX_Property_Deal_FloorRelations_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Deal_FloorRelation_DealId",
                table: "Property_Deal_FloorRelations",
                newName: "IX_Property_Deal_FloorRelations_DealId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Applicant_FloorRelation_PropertyId",
                table: "Property_Applicant_FloorRelations",
                newName: "IX_Property_Applicant_FloorRelations_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Applicant_FloorRelation_FloorId",
                table: "Property_Applicant_FloorRelations",
                newName: "IX_Property_Applicant_FloorRelations_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Applicant_FloorRelation_ApplicantId",
                table: "Property_Applicant_FloorRelations",
                newName: "IX_Property_Applicant_FloorRelations_ApplicantId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Advertisement_FloorRelation_PropertyId",
                table: "Property_Advertisement_FloorRelations",
                newName: "IX_Property_Advertisement_FloorRelations_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Advertisement_FloorRelation_FloorId",
                table: "Property_Advertisement_FloorRelations",
                newName: "IX_Property_Advertisement_FloorRelations_FloorId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_Advertisement_FloorRelation_AdvertisementId",
                table: "Property_Advertisement_FloorRelations",
                newName: "IX_Property_Advertisement_FloorRelations_AdvertisementId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityRelation_ProvinceId",
                table: "Location_CityRelations",
                newName: "IX_Location_CityRelations_ProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityRelation_NeighborhoodId",
                table: "Location_CityRelations",
                newName: "IX_Location_CityRelations_NeighborhoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityRelation_LocationId",
                table: "Location_CityRelations",
                newName: "IX_Location_CityRelations_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityRelation_CityId",
                table: "Location_CityRelations",
                newName: "IX_Location_CityRelations_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Floor_RoomRelation_RoomId",
                table: "Floor_RoomRelations",
                newName: "IX_Floor_RoomRelations_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Floor_RoomRelation_FloorId",
                table: "Floor_RoomRelations",
                newName: "IX_Floor_RoomRelations_FloorId");

            migrationBuilder.AlterColumn<string>(
                name: "ImageAddress",
                table: "Agents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyImages",
                table: "PropertyImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Tag_FloorRelations",
                table: "Property_Tag_FloorRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Supplier_FloorRelations",
                table: "Property_Supplier_FloorRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_PropertyImage_FloorRelations",
                table: "Property_PropertyImage_FloorRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Location_FloorRelations",
                table: "Property_Location_FloorRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_FloorRelations",
                table: "Property_FloorRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Deal_FloorRelations",
                table: "Property_Deal_FloorRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Applicant_FloorRelations",
                table: "Property_Applicant_FloorRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property_Advertisement_FloorRelations",
                table: "Property_Advertisement_FloorRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Neighborhoods",
                table: "Neighborhoods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location_CityRelations",
                table: "Location_CityRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Floor_RoomRelations",
                table: "Floor_RoomRelations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Floors",
                table: "Floors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deals",
                table: "Deals",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applicants",
                table: "Applicants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advertisements",
                table: "Advertisements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Floor_RoomRelations_Floors_FloorId",
                table: "Floor_RoomRelations",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Floor_RoomRelations_Rooms_RoomId",
                table: "Floor_RoomRelations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CityRelations_Cities_CityId",
                table: "Location_CityRelations",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CityRelations_Locations_LocationId",
                table: "Location_CityRelations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CityRelations_Neighborhoods_NeighborhoodId",
                table: "Location_CityRelations",
                column: "NeighborhoodId",
                principalTable: "Neighborhoods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CityRelations_Provinces_ProvinceId",
                table: "Location_CityRelations",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Advertisement_FloorRelations_Advertisements_AdvertisementId",
                table: "Property_Advertisement_FloorRelations",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Advertisement_FloorRelations_Floors_FloorId",
                table: "Property_Advertisement_FloorRelations",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Advertisement_FloorRelations_Properties_PropertyId",
                table: "Property_Advertisement_FloorRelations",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Applicant_FloorRelations_Applicants_ApplicantId",
                table: "Property_Applicant_FloorRelations",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Applicant_FloorRelations_Floors_FloorId",
                table: "Property_Applicant_FloorRelations",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Applicant_FloorRelations_Properties_PropertyId",
                table: "Property_Applicant_FloorRelations",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Deal_FloorRelations_Deals_DealId",
                table: "Property_Deal_FloorRelations",
                column: "DealId",
                principalTable: "Deals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Deal_FloorRelations_Floors_FloorId",
                table: "Property_Deal_FloorRelations",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Deal_FloorRelations_Properties_PropertyId",
                table: "Property_Deal_FloorRelations",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_FloorRelations_Floors_FloorId",
                table: "Property_FloorRelations",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_FloorRelations_Properties_PropertyId",
                table: "Property_FloorRelations",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Location_FloorRelations_Floors_FloorId",
                table: "Property_Location_FloorRelations",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Location_FloorRelations_Locations_LocationId",
                table: "Property_Location_FloorRelations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Location_FloorRelations_Properties_PropertyId",
                table: "Property_Location_FloorRelations",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyImage_FloorRelations_Floors_FloorId",
                table: "Property_PropertyImage_FloorRelations",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyImage_FloorRelations_Properties_PropertyId",
                table: "Property_PropertyImage_FloorRelations",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyImage_FloorRelations_PropertyImages_PropertyImageId",
                table: "Property_PropertyImage_FloorRelations",
                column: "PropertyImageId",
                principalTable: "PropertyImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Supplier_FloorRelations_Floors_FloorId",
                table: "Property_Supplier_FloorRelations",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Supplier_FloorRelations_Properties_PropertyId",
                table: "Property_Supplier_FloorRelations",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Supplier_FloorRelations_Suppliers_SupplierId",
                table: "Property_Supplier_FloorRelations",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Tag_FloorRelations_Floors_FloorId",
                table: "Property_Tag_FloorRelations",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Tag_FloorRelations_Properties_PropertyId",
                table: "Property_Tag_FloorRelations",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Tag_FloorRelations_Tags_TagId",
                table: "Property_Tag_FloorRelations",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }
    }
}
