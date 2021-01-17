using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniMe1.Migrations
{
    public partial class AddNewOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsOrder");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.CreateTable(
                name: "NewOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    CreditNum = table.Column<string>(maxLength: 16, nullable: false),
                    ExpireMonth = table.Column<int>(nullable: false),
                    ExpireYear = table.Column<int>(nullable: false),
                    OwnName = table.Column<string>(maxLength: 30, nullable: false),
                    IdNum = table.Column<string>(maxLength: 15, nullable: false),
                    CW = table.Column<string>(maxLength: 3, nullable: false),
                    UsersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewOrder_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsNewOrder",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    NewOrderId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    ProductsNewOrderNewOrderId = table.Column<int>(nullable: true),
                    ProductsNewOrderProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsNewOrder", x => new { x.ProductId, x.NewOrderId });
                    table.ForeignKey(
                        name: "FK_ProductsNewOrder_NewOrder_NewOrderId",
                        column: x => x.NewOrderId,
                        principalTable: "NewOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsNewOrder_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsNewOrder_ProductsNewOrder_ProductsNewOrderProductId_ProductsNewOrderNewOrderId",
                        columns: x => new { x.ProductsNewOrderProductId, x.ProductsNewOrderNewOrderId },
                        principalTable: "ProductsNewOrder",
                        principalColumns: new[] { "ProductId", "NewOrderId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewOrder_UsersId",
                table: "NewOrder",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsNewOrder_NewOrderId",
                table: "ProductsNewOrder",
                column: "NewOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsNewOrder_ProductsNewOrderProductId_ProductsNewOrderNewOrderId",
                table: "ProductsNewOrder",
                columns: new[] { "ProductsNewOrderProductId", "ProductsNewOrderNewOrderId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsNewOrder");

            migrationBuilder.DropTable(
                name: "NewOrder");

            migrationBuilder.CreateTable(
                name: "Order",
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
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrdertId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    ProductsOrderOrdertId = table.Column<int>(type: "int", nullable: true),
                    ProductsOrderProductId = table.Column<int>(type: "int", nullable: true)
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
    }
}
