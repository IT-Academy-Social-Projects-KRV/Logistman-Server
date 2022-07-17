using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddConfirmGoodsTransferFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "GoodTransferConfirmedByCreator",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodTransferConfirmedByDriver",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAnsweredByCreator",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAnsweredByDriver",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoodTransferConfirmedByCreator",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "GoodTransferConfirmedByDriver",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "IsAnsweredByCreator",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "IsAnsweredByDriver",
                table: "Offers");
        }
    }
}
