using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class color_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "Hexa_color",
                table: "Colors",
                newName: "ShoeID");

            migrationBuilder.AddColumn<string>(
                name: "ContentType1",
                table: "Colors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentType2",
                table: "Colors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentType3",
                table: "Colors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentType4",
                table: "Colors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hexa_code",
                table: "Colors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image1",
                table: "Colors",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image2",
                table: "Colors",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image3",
                table: "Colors",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image4",
                table: "Colors",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ContentType1",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "ContentType2",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "ContentType3",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "ContentType4",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Hexa_code",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Colors");

            migrationBuilder.RenameColumn(
                name: "ShoeID",
                table: "Colors",
                newName: "Hexa_color");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "dec7f25f-dd3f-4a7d-b2ea-2b90fbf536fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "467d17e7-263d-4952-a5bd-37c625e07d96");

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
    }
}
