using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class color_brand_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "30324a6f-8450-4335-8fd0-cae01b0089fe", "Germany", new DateTime(1949, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adidas" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "bfd35cf0-0bab-4c0b-b59e-275f62f84916", "USA", new DateTime(1964, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nike" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "30324a6f-8450-4335-8fd0-cae01b0089fe");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "bfd35cf0-0bab-4c0b-b59e-275f62f84916");

        }
    }
}
