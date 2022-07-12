using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Infrastructure.Migrations
{
    public partial class ChangeTripAndPointDataFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsStopover",
                table: "Points");

            migrationBuilder.AddColumn<LineString>(
                name: "RouteGeographyData",
                table: "Trips",
                type: "geography",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RouteGeographyData",
                table: "Trips");

            migrationBuilder.AddColumn<bool>(
                name: "IsStopover",
                table: "Points",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
