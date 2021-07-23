using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dealership.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    CarBrandId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarBrandName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.CarBrandId);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    CarModelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarModelName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.CarModelId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandCarBrandId = table.Column<int>(type: "INTEGER", nullable: true),
                    ModelCarModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandCarBrandId",
                        column: x => x.BrandCarBrandId,
                        principalTable: "Brands",
                        principalColumn: "CarBrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Models_ModelCarModelId",
                        column: x => x.ModelCarModelId,
                        principalTable: "Models",
                        principalColumn: "CarModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandCarBrandId",
                table: "Cars",
                column: "BrandCarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelCarModelId",
                table: "Cars",
                column: "ModelCarModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Models");
        }
    }
}
