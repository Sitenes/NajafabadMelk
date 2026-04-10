using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class addOffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
