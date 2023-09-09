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

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "14ead727-0001-42f6-9e61-f504e8901b7d", "#0000FF", "Blue" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "6b9a8a79-2f43-4504-b1ea-eca86e1fd701", "#FF0000", "Red" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "c22e9bac-02f4-4d6b-8569-8e4dd40b5adc", "#00FF00", "Green" });
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

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "14ead727-0001-42f6-9e61-f504e8901b7d");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "6b9a8a79-2f43-4504-b1ea-eca86e1fd701");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "c22e9bac-02f4-4d6b-8569-8e4dd40b5adc");
        }
    }
}
