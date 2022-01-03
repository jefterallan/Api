using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSample.Migrations
{
    public partial class changing_type_of_field_from_addresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Invoices_InvoiceId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Products",
                newName: "OrdersId");

            migrationBuilder.RenameColumn(
                name: "InvoiceId",
                table: "Products",
                newName: "InvoicesId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                newName: "IX_Products_OrdersId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_InvoiceId",
                table: "Products",
                newName: "IX_Products_InvoicesId");

            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "Addresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Invoices_InvoicesId",
                table: "Products",
                column: "InvoicesId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrdersId",
                table: "Products",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Invoices_InvoicesId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrdersId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "Products",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "InvoicesId",
                table: "Products",
                newName: "InvoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_OrdersId",
                table: "Products",
                newName: "IX_Products_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_InvoicesId",
                table: "Products",
                newName: "IX_Products_InvoiceId");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Invoices_InvoiceId",
                table: "Products",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
