using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHome = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2611), "Genel kategori", true, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2626), "Genel", "genel" },
                    { 2, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2630), "Telefonlar", true, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2630), "Telefon", "telefon" },
                    { 3, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2632), "Elektronik ürünler", true, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2633), "Elektronik", "elektronik" },
                    { 4, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2635), "Bilgisayarlar", true, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2635), "Bilgisayar", "bilgisayar" },
                    { 5, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2637), "Beyaz Eşyalar", true, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2638), "Beyaz Eşya", "beyaz-esya" },
                    { 6, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2639), "Yurt dışından gelen ürünler", false, new DateTime(2025, 3, 14, 0, 39, 31, 372, DateTimeKind.Local).AddTicks(2640), "Yurt Dışı", "yurt-disi" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImageUrl", "IsActive", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9858), "1.png", true, true, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9859), "IPhone 14", 59000m, "Harika bir telefon", "iphone-14" },
                    { 2, 2, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9865), "2.png", true, false, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9866), "IPhone 14 Pro", 69000m, "Bu da harika bir telefon", "iphone-14-pro" },
                    { 3, 2, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9870), "3.png", true, true, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9871), "Samsung S23", 49000m, "İdare eder", "samsung-s23" },
                    { 4, 2, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9875), "4.png", true, true, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9876), "Xaomi Note 4", 39000m, "Harika bir telefon", "xaomi-note-4" },
                    { 5, 4, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9880), "5.png", true, true, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9881), "MacBook Air M2", 52000m, "M2nin gücü", "macbook-air-m2" },
                    { 6, 4, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9885), "6.png", true, false, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9886), "MacBook Pro M3", 79000m, "16 Gb ram", "macbook-pro-m3" },
                    { 7, 5, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9890), "7.png", true, true, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9891), "Vestel Çamaşır Makinesi X65", 19000m, "Akıllı makine", "vestel-camasir-makinesi-x65" },
                    { 8, 5, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9894), "8.png", true, false, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9895), "Arçelik Çamaşır Makinesi A-4", 21000m, "Süper hızlı makine", "arcelik-camasir-makinesi-a-4" },
                    { 9, 3, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9899), "9.png", true, true, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9900), "Hoop Dijital Radyo X96", 1250m, "Klasik radyo keyfi", "hoop-dijital-radyo-x96" },
                    { 10, 3, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9904), "10.png", true, true, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9905), "Xaomi Dijital Baskül", 2100m, "Kilonuzu kontrol edin", "xaomi-dijital-baskul" },
                    { 11, 3, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9909), "11.png", true, true, new DateTime(2025, 3, 14, 0, 39, 31, 379, DateTimeKind.Local).AddTicks(9910), "Blaupunkt AC69 Led TV", 9800m, "Android tv", "blaupunkt-ac69-led-tv" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
