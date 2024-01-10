using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class testmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: "d1e0cd9f-c1fa-4fb2-bd90-cf3c003117ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f65e09c2-84d7-4028-b221-7742baec8e7e");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
