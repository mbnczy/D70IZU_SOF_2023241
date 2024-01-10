using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeWebshop.Data.Migrations
{
    public partial class siteuser_extension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "AspNetUsers");
        }
    }
}
