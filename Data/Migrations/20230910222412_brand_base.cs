using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class brand_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "ab033757-3807-40dc-8780-94cc708a89a6");

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Brands",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "Brands",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "cea95106-316d-4ab1-9a8b-8a85660c3284");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "472ab1ca-b951-4797-b2d4-2beada750bc0");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "ff3be41c-72a2-42c4-aa81-cd9acfc4494a", "expensive", "Sneaker" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "ff3be41c-72a2-42c4-aa81-cd9acfc4494a");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Brands");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "afba09a5-cdad-418a-ae9e-cdf606c994a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c3a118c7-e028-4cc9-a0fe-ddfe5ba0c0a1");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "ab033757-3807-40dc-8780-94cc708a89a6", "expensive", "Sneaker" });
        }
    }
}
