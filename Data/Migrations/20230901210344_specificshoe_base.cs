using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class specificshoe_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specific_shoe_details",
                columns: table => new
                {
                    SpecificShoeID = table.Column<string>(type: "TEXT", nullable: false),
                    ShoeID = table.Column<string>(type: "TEXT", nullable: false),
                    ColorID = table.Column<string>(type: "TEXT", nullable: false),
                    SizesID = table.Column<string>(type: "TEXT", nullable: false),
                    Specific_images = table.Column<string>(type: "TEXT", nullable: false),
                    Order_type = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity_in_stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    Discount = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specific_shoe_details", x => x.SpecificShoeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specific_shoe_details");
        }
    }
}
