using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class purchase_items_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Purchase_items",
                columns: table => new
                {
                    PurchaseItemID = table.Column<string>(type: "TEXT", nullable: false),
                    PurchaseID = table.Column<string>(type: "TEXT", nullable: false),
                    Specific_shoe_detailsID = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity_purchased = table.Column<byte>(type: "INTEGER", nullable: false),
                    Sub_total = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_items", x => x.PurchaseItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchase_items");
        }
    }
}
