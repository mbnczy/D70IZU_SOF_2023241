using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class shoe_img_to_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<byte[]>(
                name: "Images",
                table: "Shoes",
                type: "BLOB",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Shoes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "a1ef9abe-e0ad-42aa-8a7c-726afe26a6ec", "USA", new DateTime(1964, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nike" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Country_of_origin", "Founded_year", "Name" },
                values: new object[] { "b6693d2f-9ea7-4eed-979b-a92a6bc8e98b", "Germany", new DateTime(1949, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adidas" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { "9c23c13b-514c-44ce-a219-6ef2da3472e8", "expensive", "Sneaker" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "484f7ae7-4bdc-4daf-8922-a001922280d9", "#0000FF", "Blue" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "ea0a8f14-5207-40ec-aa17-7030f2e4eacd", "#00FF00", "Green" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "Hexa_color", "Name" },
                values: new object[] { "ef846688-f107-4236-99c6-ed9449854203", "#FF0000", "Red" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "a1ef9abe-e0ad-42aa-8a7c-726afe26a6ec");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: "b6693d2f-9ea7-4eed-979b-a92a6bc8e98b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "9c23c13b-514c-44ce-a219-6ef2da3472e8");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "484f7ae7-4bdc-4daf-8922-a001922280d9");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "ea0a8f14-5207-40ec-aa17-7030f2e4eacd");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: "ef846688-f107-4236-99c6-ed9449854203");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Shoes");

            migrationBuilder.AlterColumn<string>(
                name: "Images",
                table: "Shoes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "BLOB");

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
    }
}
