using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Tokio");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Product",
                newSchema: "Tokio");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Category",
                newSchema: "Tokio");

            migrationBuilder.RenameTable(
                name: "BillProduct",
                newName: "BillProduct",
                newSchema: "Tokio");

            migrationBuilder.RenameTable(
                name: "Bill",
                newName: "Bill",
                newSchema: "Tokio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Product",
                schema: "Tokio",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Category",
                schema: "Tokio",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "BillProduct",
                schema: "Tokio",
                newName: "BillProduct");

            migrationBuilder.RenameTable(
                name: "Bill",
                schema: "Tokio",
                newName: "Bill");
        }
    }
}
