using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ConfirmEmailToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmEmailToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ConfirmEmailTokenExpirationDate",
                table: "AspNetUsers",
                type: "datetimeoffset",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmEmailToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConfirmEmailTokenExpirationDate",
                table: "AspNetUsers");
        }
    }
}
