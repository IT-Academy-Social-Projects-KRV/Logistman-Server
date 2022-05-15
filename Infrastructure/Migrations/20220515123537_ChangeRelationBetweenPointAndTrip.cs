using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ChangeRelationBetweenPointAndTrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PointTrip");

            migrationBuilder.AddColumn<int>(
                name: "PointId",
                table: "Trips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_PointId",
                table: "Trips",
                column: "PointId");

            migrationBuilder.CreateIndex(
                name: "IX_Points_TripId",
                table: "Points",
                column: "TripId");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Trips_TripId",
                table: "Points",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Points_PointId",
                table: "Trips",
                column: "PointId",
                principalTable: "Points",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_Trips_TripId",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Points_PointId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_PointId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Points_TripId",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "PointId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Points");

            migrationBuilder.CreateTable(
                name: "PointTrip",
                columns: table => new
                {
                    PointsId = table.Column<int>(type: "int", nullable: false),
                    TripsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointTrip", x => new { x.PointsId, x.TripsId });
                    table.ForeignKey(
                        name: "FK_PointTrip_Points_PointsId",
                        column: x => x.PointsId,
                        principalTable: "Points",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PointTrip_Trips_TripsId",
                        column: x => x.TripsId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PointTrip_TripsId",
                table: "PointTrip",
                column: "TripsId");
        }
    }
}
