using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Infrastructure.Migrations
{
    public partial class ChangeTripAndPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Distance",
                table: "Trips",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Points",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsStopover",
                table: "Points",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Point>(
                name: "Location",
                table: "Points",
                type: "geography",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "Points",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "IsStopover",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "Points");
        }
    }
}
