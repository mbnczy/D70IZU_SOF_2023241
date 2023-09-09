using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class identityrole_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "a1ef9abe-e0ad-42aa-8a7c-726afe26a6ec");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "b6693d2f-9ea7-4eed-979b-a92a6bc8e98b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "9c23c13b-514c-44ce-a219-6ef2da3472e8");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "484f7ae7-4bdc-4daf-8922-a001922280d9");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "ea0a8f14-5207-40ec-aa17-7030f2e4eacd");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "ef846688-f107-4236-99c6-ed9449854203");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "dec7f25f-dd3f-4a7d-b2ea-2b90fbf536fb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "467d17e7-263d-4952-a5bd-37c625e07d96", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "b1e6655e-6af4-4f95-b3d4-204c25898462", "USA", new DateTime(1964, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nike" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "dc9524c8-32bb-4868-9b4d-6cd8907fec42", "Germany", new DateTime(1949, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adidas" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "725aa653-cdfe-4525-8405-b48dbb96da10", "expensive", "Sneaker" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "127a7435-715e-4206-b53a-6b81dcfb5fc8", "#00FF00", "Green" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "23330b31-b46b-457f-9fd2-02334ba7de0c", "#0000FF", "Blue" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "e9b06a7c-a4bd-4baf-8414-2aa692992d75", "#FF0000", "Red" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "b1e6655e-6af4-4f95-b3d4-204c25898462");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "dc9524c8-32bb-4868-9b4d-6cd8907fec42");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "725aa653-cdfe-4525-8405-b48dbb96da10");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "127a7435-715e-4206-b53a-6b81dcfb5fc8");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "23330b31-b46b-457f-9fd2-02334ba7de0c");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "e9b06a7c-a4bd-4baf-8414-2aa692992d75");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "a1ef9abe-e0ad-42aa-8a7c-726afe26a6ec", "USA", new DateTime(1964, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nike" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "b6693d2f-9ea7-4eed-979b-a92a6bc8e98b", "Germany", new DateTime(1949, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adidas" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "9c23c13b-514c-44ce-a219-6ef2da3472e8", "expensive", "Sneaker" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "484f7ae7-4bdc-4daf-8922-a001922280d9", "#0000FF", "Blue" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "ea0a8f14-5207-40ec-aa17-7030f2e4eacd", "#00FF00", "Green" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "ef846688-f107-4236-99c6-ed9449854203", "#FF0000", "Red" });
        }
    }
}
