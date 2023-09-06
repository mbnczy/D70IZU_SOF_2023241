using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class lazy_loading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Specific_shoe_details_ColorID",
                table: "Specific_shoe_details",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Specific_shoe_details_ShoeID",
                table: "Specific_shoe_details",
                column: "ShoeID");

            migrationBuilder.CreateIndex(
                name: "IX_Specific_shoe_details_SizesID",
                table: "Specific_shoe_details",
                column: "SizesID");

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_BrandID",
                table: "Shoes",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_CategoryID",
                table: "Shoes",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CustomerID",
                table: "Purchases",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_items_PurchaseID",
                table: "Purchase_items",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_items_Specific_shoe_detailsID",
                table: "Purchase_items",
                column: "Specific_shoe_detailsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_items_Purchases_PurchaseID",
                table: "Purchase_items",
                column: "PurchaseID",
                principalTable: "Purchases",
                principalColumn: "PurchaseID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_items_Specific_shoe_details_Specific_shoe_detailsID",
                table: "Purchase_items",
                column: "Specific_shoe_detailsID",
                principalTable: "Specific_shoe_details",
                principalColumn: "SpecificShoeID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_AspNetUsers_CustomerID",
                table: "Purchases",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Brands_BrandID",
                table: "Shoes",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Categories_CategoryID",
                table: "Shoes",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Specific_shoe_details_Colors_ColorID",
                table: "Specific_shoe_details",
                column: "ColorID",
                principalTable: "Colors",
                principalColumn: "ColorID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Specific_shoe_details_Shoes_ShoeID",
                table: "Specific_shoe_details",
                column: "ShoeID",
                principalTable: "Shoes",
                principalColumn: "ShoeID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Specific_shoe_details_Sizes_SizesID",
                table: "Specific_shoe_details",
                column: "SizesID",
                principalTable: "Sizes",
                principalColumn: "SizeID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_items_Purchases_PurchaseID",
                table: "Purchase_items");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_items_Specific_shoe_details_Specific_shoe_detailsID",
                table: "Purchase_items");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_AspNetUsers_CustomerID",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Brands_BrandID",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Categories_CategoryID",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Specific_shoe_details_Colors_ColorID",
                table: "Specific_shoe_details");

            migrationBuilder.DropForeignKey(
                name: "FK_Specific_shoe_details_Shoes_ShoeID",
                table: "Specific_shoe_details");

            migrationBuilder.DropForeignKey(
                name: "FK_Specific_shoe_details_Sizes_SizesID",
                table: "Specific_shoe_details");

            migrationBuilder.DropIndex(
                name: "IX_Specific_shoe_details_ColorID",
                table: "Specific_shoe_details");

            migrationBuilder.DropIndex(
                name: "IX_Specific_shoe_details_ShoeID",
                table: "Specific_shoe_details");

            migrationBuilder.DropIndex(
                name: "IX_Specific_shoe_details_SizesID",
                table: "Specific_shoe_details");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_BrandID",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_CategoryID",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_CustomerID",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_items_PurchaseID",
                table: "Purchase_items");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_items_Specific_shoe_detailsID",
                table: "Purchase_items");
        }
    }
}
