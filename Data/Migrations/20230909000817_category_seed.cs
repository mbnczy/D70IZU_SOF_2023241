using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class category_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "3089f9e2-13e4-43ce-a710-c57ef867233b", "USA", new DateTime(1964, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nike" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "58300707-6a1e-4696-9c85-67894040357a", "Germany", new DateTime(1949, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adidas" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "c7bedfeb-e007-48bb-b5be-6933daa0d9c6", "expensive", "Sneaker" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "4ad788a1-545b-453b-abd7-b002bbcdf6d6", "#0000FF", "Blue" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "58298488-638f-43e6-98fc-cd009bd66780", "#FF0000", "Red" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "623aa2f2-a4b1-4ce5-a1f2-5e4ebf79b428", "#00FF00", "Green" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "3089f9e2-13e4-43ce-a710-c57ef867233b");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "58300707-6a1e-4696-9c85-67894040357a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "c7bedfeb-e007-48bb-b5be-6933daa0d9c6");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "4ad788a1-545b-453b-abd7-b002bbcdf6d6");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "58298488-638f-43e6-98fc-cd009bd66780");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "623aa2f2-a4b1-4ce5-a1f2-5e4ebf79b428");

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
    }
}
