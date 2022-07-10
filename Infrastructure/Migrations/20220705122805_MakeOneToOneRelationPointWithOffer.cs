using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class MakeOneToOneRelationPointWithOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Offers_OfferPointId",
                table: "Offers");

            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_OfferPointId",
                table: "Offers",
                column: "OfferPointId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Offers_OfferPointId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "Points");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_OfferPointId",
                table: "Offers",
                column: "OfferPointId");
        }
    }
}
