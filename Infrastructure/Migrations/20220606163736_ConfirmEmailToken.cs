using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ConfirmationEmailToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmationEmailToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ConfirmationEmailTokenExpirationDate",
                table: "AspNetUsers",
                type: "datetimeoffset",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationEmailToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConfirmationEmailTokenExpirationDate",
                table: "AspNetUsers");
        }
    }
}
