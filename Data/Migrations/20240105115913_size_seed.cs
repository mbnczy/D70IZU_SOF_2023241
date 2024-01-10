using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class size_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "ad8cbdc3-116a-4277-8206-f54e127fb0c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "95ee9f89-1dfb-4227-9a4e-5b64eeb7fb1e");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "c0186dd1-737d-48d0-b56d-42498be034af", "expensive", "Sneaker" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Details", "Value" },
                values: new object[] { "1", "", "UK - 6" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Details", "Value" },
                values: new object[] { "2", "", "UK - 6.5" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Details", "Value" },
                values: new object[] { "3", "", "UK - 7" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Details", "Value" },
                values: new object[] { "4", "", "UK - 7.5" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Details", "Value" },
                values: new object[] { "5", "", "UK - 8" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Details", "Value" },
                values: new object[] { "6", "", "UK - 8.5" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Details", "Value" },
                values: new object[] { "7", "", "UK - 9" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Details", "Value" },
                values: new object[] { "8", "", "UK - 9.5" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Details", "Value" },
                values: new object[] { "9", "", "UK - 10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "c0186dd1-737d-48d0-b56d-42498be034af");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: "9");

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
    }
}
