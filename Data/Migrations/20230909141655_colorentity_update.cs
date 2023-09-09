using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class colorentity_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "45e5f61b-4347-4839-9744-e1c263640268");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "9cf9105a-6b62-4cdb-8e36-2b6b080a0fc6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "3994e00d-1b36-4024-b098-dbea885774c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d0449aa4-9d3e-4ecb-be8f-979459fc7b97");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b2edc072-ed65-4a4a-9693-724167257495");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "4b0fd623-2ec9-4673-9bca-7e296368dbee", "Germany", new DateTime(1949, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adidas" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "4efd015a-3137-40e9-94ce-2e4e8366e61b", "USA", new DateTime(1964, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nike" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "c45b0113-e8b2-405b-a998-5d18e271fc93", "expensive", "Sneaker" });

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ShoeID",
                table: "Colors",
                column: "ShoeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_Shoes_ShoeID",
                table: "Colors",
                column: "ShoeID",
                principalTable: "Shoes",
                principalColumn: "ShoeID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Shoes_ShoeID",
                table: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Colors_ShoeID",
                table: "Colors");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "4b0fd623-2ec9-4673-9bca-7e296368dbee");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "4efd015a-3137-40e9-94ce-2e4e8366e61b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "c45b0113-e8b2-405b-a998-5d18e271fc93");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "872c300e-edf6-4937-8e81-25edce846455");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6b2e3885-c84f-462a-ae1b-8d9ec48e03a9");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "45e5f61b-4347-4839-9744-e1c263640268", "USA", new DateTime(1964, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nike" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "9cf9105a-6b62-4cdb-8e36-2b6b080a0fc6", "Germany", new DateTime(1949, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adidas" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "3994e00d-1b36-4024-b098-dbea885774c6", "expensive", "Sneaker" });
        }
    }
}
