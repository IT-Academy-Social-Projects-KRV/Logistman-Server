using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class FixedTripTimeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Trips",
                newName: "DepartureDate");

            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "Trips",
                newName: "CreationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartureDate",
                table: "Trips",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Trips",
                newName: "ExpirationDate");
        }
    }
}
