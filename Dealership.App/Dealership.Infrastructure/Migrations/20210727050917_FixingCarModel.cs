using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dealership.Infrastructure.Migrations
{
    public partial class FixingCarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Cars",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Cars");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Cars",
                type: "BLOB",
                nullable: true);
        }
    }
}
