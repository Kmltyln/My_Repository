﻿using System;
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Properties = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
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
                    { 1, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6868), "Genel kategori", true, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6878), "Genel", "genel" },
                    { 2, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6881), "Telefonlar", true, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6881), "Telefon", "telefon" },
                    { 3, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6883), "Elektronik ürünler", true, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6884), "Elektronik", "elektronik" },
                    { 4, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6885), "Bilgisayarlar", true, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6886), "Bilgisayar", "bilgisayar" },
                    { 5, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6888), "Beyaz Eşyalar", true, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6888), "Beyaz Eşya", "beyaz-esya" },
                    { 6, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6890), "Yurt dışından gelen ürünler", false, new DateTime(2025, 3, 30, 1, 11, 48, 914, DateTimeKind.Local).AddTicks(6891), "Yurt Dışı", "yurt-disi" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImageUrl", "IsActive", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2448), "1.png", true, true, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2449), "IPhone 14", 59000m, "Harika bir telefon", "iphone-14" },
                    { 2, 2, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2454), "2.png", true, false, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2455), "IPhone 14 Pro", 69000m, "Bu da harika bir telefon", "iphone-14-pro" },
                    { 3, 2, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2459), "3.png", true, true, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2460), "Samsung S23", 49000m, "İdare eder", "samsung-s23" },
                    { 4, 2, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2463), "4.png", true, true, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2464), "Xaomi Note 4", 39000m, "Harika bir telefon", "xaomi-note-4" },
                    { 5, 4, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2468), "5.png", true, true, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2469), "MacBook Air M2", 52000m, "M2nin gücü", "macbook-air-m2" },
                    { 6, 4, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2472), "6.png", true, false, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2473), "MacBook Pro M3", 79000m, "16 Gb ram", "macbook-pro-m3" },
                    { 7, 5, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2477), "7.png", true, true, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2478), "Vestel Çamaşır Makinesi X65", 19000m, "Akıllı makine", "vestel-camasir-makinesi-x65" },
                    { 8, 5, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2482), "8.png", true, false, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2483), "Arçelik Çamaşır Makinesi A-4", 21000m, "Süper hızlı makine", "arcelik-camasir-makinesi-a-4" },
                    { 9, 3, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2486), "9.png", true, true, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2487), "Hoop Dijital Radyo X96", 1250m, "Klasik radyo keyfi", "hoop-dijital-radyo-x96" },
                    { 10, 3, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2491), "10.png", true, true, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2492), "Xaomi Dijital Baskül", 2100m, "Kilonuzu kontrol edin", "xaomi-dijital-baskul" },
                    { 11, 3, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2496), "11.png", true, true, new DateTime(2025, 3, 30, 1, 11, 48, 915, DateTimeKind.Local).AddTicks(2497), "Blaupunkt AC69 Led TV", 9800m, "Android tv", "blaupunkt-ac69-led-tv" }
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
