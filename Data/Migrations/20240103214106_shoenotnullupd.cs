using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class shoenotnullupd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "6ad109ad-a301-4509-9be6-bb05c8475bb3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0c8c33b0-5aa1-4847-9a67-ff265b2a13f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d3ebe2e9-2720-42e9-b43f-0f95288db813");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "7a2c870f-7d40-464f-87ad-a337f7b9cad4", "expensive", "Sneaker" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "7a2c870f-7d40-464f-87ad-a337f7b9cad4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0c72979a-9d97-4602-a90a-7890c52c8e9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c44dc6a4-c5f4-4491-8559-877336c1464d");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "6ad109ad-a301-4509-9be6-bb05c8475bb3", "expensive", "Sneaker" });
        }
    }
}
