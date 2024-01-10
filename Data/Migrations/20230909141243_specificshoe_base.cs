using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class specificshoe_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "1dea26b7-3a9c-48aa-8ec8-891c2e61d326");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "74cedce6-8ce2-45c7-b3e7-ba3de9a7b410");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "e3481a7f-cd77-4908-87f6-c362d6f5cdc1");

            migrationBuilder.DropColumn(
                name: "Specific_images",
                table: "Specific_shoe_details");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "Images",
                table: "Shoes");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Specific_images",
                table: "Specific_shoe_details",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Shoes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Images",
                table: "Shoes",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ceebb954-6653-4f46-9037-9861f13fceae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6ab516ba-263c-4309-9b03-e00d54d2b2e7");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "1dea26b7-3a9c-48aa-8ec8-891c2e61d326", "USA", new DateTime(1964, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nike" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "74cedce6-8ce2-45c7-b3e7-ba3de9a7b410", "Germany", new DateTime(1949, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adidas" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "e3481a7f-cd77-4908-87f6-c362d6f5cdc1", "expensive", "Sneaker" });
        }
    }
}
