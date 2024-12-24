﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Properties = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
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
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7122), "Elektronik ürünler", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektronik" },
                    { 2, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7125), "Giyim ürünleri", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giyim" },
                    { 3, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7127), "Kozmetik ürünler", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kozmetik" },
                    { 4, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7128), "Kitaplar", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitap" },
                    { 5, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7130), "Hediyelik eşyalar", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hediyelik Eşya" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "ModifiedDate", "Name", "Price", "Properties" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7280), "http://localhost:5050/images/products/product1.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akıllı Telefon", 2999.99m, "Son model akıllı telefon" },
                    { 2, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7287), "http://localhost:5050/images/products/product2.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop", 4999.99m, "Yüksek performanslı laptop" },
                    { 3, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7289), "http://localhost:5050/images/products/product3.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kamera", 1999.99m, "Yüksek çözünürlüklü kamera" },
                    { 4, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7291), "http://localhost:5050/images/products/product4.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tablet", 1999.99m, "Taşınabilir tablet" },
                    { 5, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7293), "http://localhost:5050/images/products/product5.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bluetooth Hoparlör", 399.99m, "Kablosuz hoparlör" },
                    { 6, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7295), "http://localhost:5050/images/products/product6.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akıllı Saat", 799.99m, "Akıllı saat" },
                    { 7, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7296), "http://localhost:5050/images/products/product7.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kulaklık", 299.99m, "Kablosuz kulaklık" },
                    { 8, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7298), "http://localhost:5050/images/products/product8.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dizüstü Bilgisayar", 3499.99m, "Hafif dizüstü bilgisayar" },
                    { 9, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7300), "http://localhost:5050/images/products/product9.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oyun Konsolu", 2499.99m, "Yeni nesil oyun konsolu" },
                    { 10, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7302), "http://localhost:5050/images/products/product10.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masaüstü Bilgisayar", 3999.99m, "Güçlü masaüstü bilgisayar" },
                    { 11, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7304), "http://localhost:5050/images/products/product11.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazıcı", 499.99m, "Renkli yazıcı" },
                    { 12, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7305), "http://localhost:5050/images/products/product12.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tarayıcı", 299.99m, "Doküman tarayıcı" },
                    { 13, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7307), "http://localhost:5050/images/products/product13.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projeor", 1999.99m, "Ev sinema sistemi için projektör" },
                    { 14, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7309), "http://localhost:5050/images/products/product14.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kamera Lens", 799.99m, "Yüksek kaliteli lens" },
                    { 15, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7311), "http://localhost:5050/images/products/product15.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksiyon Kamerası", 1499.99m, "Aksiyon çekimleri için kamera" },
                    { 16, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7312), "http://localhost:5050/images/products/product16.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Küçük Ev Aletleri", 299.99m, "Küçük ev aletleri" },
                    { 17, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7314), "http://localhost:5050/images/products/product17.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mutfak Robotu", 899.99m, "Mutfak robotu" },
                    { 18, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7316), "http://localhost:5050/images/products/product18.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blender", 199.99m, "Blender" },
                    { 19, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7317), "http://localhost:5050/images/products/product19.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikser", 149.99m, "Mikser" },
                    { 20, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7319), "http://localhost:5050/images/products/product20.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fırın", 1999.99m, "Dijital fırın" },
                    { 21, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7321), "http://localhost:5050/images/products/product21.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruj", 49.99m, "Kırmızı ruj" },
                    { 22, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7322), "http://localhost:5050/images/products/product22.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parfüm", 199.99m, "Kadın parfümü" },
                    { 23, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7324), "http://localhost:5050/images/products/product23.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krem", 79.99m, "Nemlendirici krem" },
                    { 24, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7326), "http://localhost:5050/images/products/product24.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şampuan", 39.99m, "Saç şampuanı" },
                    { 25, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7327), "http://localhost:5050/images/products/product25.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dudak Balmı", 19.99m, "Nemlendirici dudak balmı" },
                    { 26, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7329), "http://localhost:5050/images/products/product26.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makyaj Seti", 299.99m, "Makyaj seti" },
                    { 27, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7331), "http://localhost:5050/images/products/product27.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Göz Farı", 59.99m, "Göz farı" },
                    { 28, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7332), "http://localhost:5050/images/products/product28.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oje", 29.99m, "Renkli oje" },
                    { 29, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7334), "http://localhost:5050/images/products/product29.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cilt Bakım Seti", 199.99m, "Cilt bakım seti" },
                    { 30, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7335), "http://localhost:5050/images/products/product30.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vücut Losyonu", 89.99m, "Vücut losyonu" },
                    { 31, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7337), "http://localhost:5050/images/products/product31.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saç Spreyi", 39.99m, "Saç spreyi" },
                    { 32, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7339), "http://localhost:5050/images/products/product32.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makyaj Ayna", 49.99m, "Makyaj aynası" },
                    { 33, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7340), "http://localhost:5050/images/products/product33.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tırnak Bakım Seti", 29.99m, "Tırnak bakım seti" },
                    { 34, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7342), "http://localhost:5050/images/products/product34.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yüz Maskesi", 19.99m, "Yüz maskesi" },
                    { 35, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7344), "http://localhost:5050/images/products/product35.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Göz Kremi", 59.99m, "Göz kremi" },
                    { 36, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7345), "http://localhost:5050/images/products/product36.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dudak Peelingi", 29.99m, "Dudak peelingi" },
                    { 37, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7347), "http://localhost:5050/images/products/product37.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cilt Temizleme Jeli", 39.99m, "Cilt temizleme jeli" },
                    { 38, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7348), "http://localhost:5050/images/products/product38.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vücut Scrub'ı", 49.99m, "Vücut scrub'ı" },
                    { 39, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7350), "http://localhost:5050/images/products/product39.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saç Maskesi", 59.99m, "Saç maskesi" },
                    { 40, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7351), "http://localhost:5050/images/products/product40.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makyaj Fırçası", 19.99m, "Makyaj fırçası" },
                    { 41, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7353), "http://localhost:5050/images/products/product41.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tişört", 99.99m, "Pamuklu tişört" },
                    { 42, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7355), "http://localhost:5050/images/products/product42.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pantolon", 149.99m, "Şık pantolon" },
                    { 43, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7356), "http://localhost:5050/images/products/product43.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elbise", 199.99m, "Şık elbise" },
                    { 44, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7358), "http://localhost:5050/images/products/product44.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceket", 299.99m, "Şık ceket" },
                    { 45, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7359), "http://localhost:5050/images/products/product45.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaban", 399.99m, "Kış kabanı" },
                    { 46, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7361), "http://localhost:5050/images/products/product46.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman", 39.99m, "Roman" },
                    { 47, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7362), "http://localhost:5050/images/products/product47.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilim Kurgu", 29.99m, "Bilim kurgu kitabı" },
                    { 48, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7364), "http://localhost:5050/images/products/product48.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tarih Kitabı", 34.99m, "Tarih kitabı" },
                    { 49, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7409), "http://localhost:5050/images/products/product49.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çocuk Kitabı", 19.99m, "Çocuklar için kitap" },
                    { 50, new DateTime(2024, 12, 24, 7, 14, 54, 63, DateTimeKind.Utc).AddTicks(7412), "http://localhost:5050/images/products/product50.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yemek Kitabı", 49.99m, "Yemek tarifleri kitabı" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 5, 1 },
                    { 1, 2 },
                    { 5, 2 },
                    { 1, 3 },
                    { 5, 3 },
                    { 1, 4 },
                    { 5, 4 },
                    { 1, 5 },
                    { 5, 5 },
                    { 1, 6 },
                    { 5, 6 },
                    { 1, 7 },
                    { 5, 7 },
                    { 1, 8 },
                    { 5, 8 },
                    { 1, 9 },
                    { 5, 9 },
                    { 1, 10 },
                    { 5, 10 },
                    { 1, 11 },
                    { 5, 11 },
                    { 1, 12 },
                    { 5, 12 },
                    { 1, 13 },
                    { 5, 13 },
                    { 1, 14 },
                    { 5, 14 },
                    { 1, 15 },
                    { 5, 15 },
                    { 3, 21 },
                    { 5, 21 },
                    { 3, 22 },
                    { 5, 22 },
                    { 3, 23 },
                    { 5, 23 },
                    { 3, 24 },
                    { 5, 24 },
                    { 3, 25 },
                    { 5, 25 },
                    { 3, 26 },
                    { 5, 26 },
                    { 3, 27 },
                    { 5, 27 },
                    { 3, 28 },
                    { 5, 28 },
                    { 3, 29 },
                    { 5, 29 },
                    { 3, 30 },
                    { 5, 30 },
                    { 3, 31 },
                    { 5, 31 },
                    { 3, 32 },
                    { 5, 32 },
                    { 3, 33 },
                    { 5, 33 },
                    { 3, 34 },
                    { 5, 34 },
                    { 3, 35 },
                    { 5, 35 },
                    { 3, 36 },
                    { 5, 36 },
                    { 3, 37 },
                    { 5, 37 },
                    { 3, 38 },
                    { 5, 38 },
                    { 3, 39 },
                    { 5, 39 },
                    { 3, 40 },
                    { 5, 40 },
                    { 2, 41 },
                    { 5, 41 },
                    { 2, 42 },
                    { 5, 42 },
                    { 2, 43 },
                    { 5, 43 },
                    { 2, 44 },
                    { 5, 44 },
                    { 2, 45 },
                    { 5, 45 },
                    { 4, 46 },
                    { 5, 46 },
                    { 4, 47 },
                    { 5, 47 },
                    { 4, 48 },
                    { 5, 48 },
                    { 4, 49 },
                    { 5, 49 },
                    { 4, 50 },
                    { 5, 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ApplicationUserId",
                table: "Baskets",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
