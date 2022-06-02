using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class DeleteNeedlessColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Points_PointId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_PointId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "PointId",
                table: "Trips");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PointId",
                table: "Trips",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_PointId",
                table: "Trips",
                column: "PointId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Points_PointId",
                table: "Trips",
                column: "PointId",
                principalTable: "Points",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
