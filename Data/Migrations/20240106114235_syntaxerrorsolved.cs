using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class syntaxerrorsolved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "09f5a822-b494-4877-9628-19ac9618fda4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d89a5488-ca21-4d2d-944f-40fcd9d51005");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7056cc4d-96f3-4462-afe7-c1bf2a8dbf01");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ab125a18-9366-4ddf-8e7f-72c25fca1317");
        }
    }
}
