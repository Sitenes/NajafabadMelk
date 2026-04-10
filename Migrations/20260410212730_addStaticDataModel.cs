using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class addStaticDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "staticDataGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staticDataGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "staticDatas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StringContentFa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StringContentEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StringContentAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staticDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_staticDatas_staticDataGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "staticDataGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_staticDatas_GroupId",
                table: "staticDatas",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "staticDatas");

            migrationBuilder.DropTable(
                name: "staticDataGroups");
        }
    }
}
