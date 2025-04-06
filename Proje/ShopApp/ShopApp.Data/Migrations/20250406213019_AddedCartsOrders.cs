using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCartsOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderState = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[] { 1, new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(188), "1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7454), new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7460), new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7463), new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7465), new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7468), new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7470), new DateTime(2025, 4, 7, 0, 30, 15, 78, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5926), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5938), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5943), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5948), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5952), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5957), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5962), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5966), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(6597), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(6605), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(6610), new DateTime(2025, 4, 7, 0, 30, 15, 79, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6868), new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6881), new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6883), new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6885), new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6888), new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6890), new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2448), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2454), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2459), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2463), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2468), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2472), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2477), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2482), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2486), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2491), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2496), new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2497) });
        }
    }
}
