using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniMe1.Migrations
{
    public partial class AddControllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNum = table.Column<int>(nullable: false),
                    UsersId = table.Column<int>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    SumPrice = table.Column<float>(nullable: false),
                    PaymentMethods = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsOrder",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    OrdertId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    ProductsOrderOrdertId = table.Column<int>(nullable: true),
                    ProductsOrderProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOrder", x => new { x.ProductId, x.OrdertId });
                    table.ForeignKey(
                        name: "FK_ProductsOrder_Order_OrdertId",
                        column: x => x.OrdertId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsOrder_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsOrder_ProductsOrder_ProductsOrderProductId_ProductsOrderOrdertId",
                        columns: x => new { x.ProductsOrderProductId, x.ProductsOrderOrdertId },
                        principalTable: "ProductsOrder",
                        principalColumns: new[] { "ProductId", "OrdertId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_UsersId",
                table: "Order",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOrder_OrdertId",
                table: "ProductsOrder",
                column: "OrdertId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOrder_ProductsOrderProductId_ProductsOrderOrdertId",
                table: "ProductsOrder",
                columns: new[] { "ProductsOrderProductId", "ProductsOrderOrdertId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsOrder");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderNum = table.Column<int>(type: "int", nullable: false),
                    PaymentMethods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SumPrice = table.Column<float>(type: "real", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UsersId",
                table: "Orders",
                column: "UsersId");
        }
    }
}
