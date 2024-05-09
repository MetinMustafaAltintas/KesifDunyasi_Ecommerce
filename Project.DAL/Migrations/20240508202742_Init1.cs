using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivationCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                name: "Profiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Profiles_AspNetUsers_ID",
                        column: x => x.ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    UnitsInStock = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: true),
                    PriceOfOrder = table.Column<decimal>(type: "money", nullable: false),
                    ShipperID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Shippers_ShipperID",
                        column: x => x.ShipperID,
                        principalTable: "Shippers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductAndProductAttributes",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ProductAttributeID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAndProductAttributes", x => new { x.ProductAttributeID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_ProductAndProductAttributes_ProductAttributes_ProductAttributeID",
                        column: x => x.ProductAttributeID,
                        principalTable: "ProductAttributes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAndProductAttributes_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, "7249832f-daf1-4c18-8ded-bc453c049ad8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationCode", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, null, "95c8efe0-9c73-48c6-b5e2-6025a43fae7c", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6506), null, "metinmustafaaltintas@gmail.com", true, false, null, null, "METINMUSTAFAALTINTAS@GMAIL.COM", "METIN", "AQAAAAIAAYagAAAAELSesC7nj2fxRw0fE7yNYcEiJd4KYISXdPnZRyDW7U1W6+vxTKEkEl8pCYTLRrO1fg==", null, false, "0d1c1198-762d-4044-ac7c-af1dd610ead3", 1, false, "metin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedDate", "DeletedDate", "Description", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Grocery", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(2262), null, "Oldular beğendim çünkü ut düşünüyor aut gitti tempora uzattı numquam.", null, 1 },
                    { 2, "Industrial", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(3468), null, "Koyun çobanın teldeki ve çobanın voluptatem dolor in ut dolore.", null, 1 },
                    { 3, "Movies", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(3753), null, "Corporis consequatur adresini consectetur esse aut quaerat adresini beatae ışık.", null, 1 },
                    { 4, "Garden", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(3828), null, "Oldular göze ama voluptatum enim türemiş ad consequatur sed kalemi.", null, 1 },
                    { 5, "Tools", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(4070), null, "Voluptatem oldular sequi eos corporis bahar gitti iure gül sequi.", null, 1 },
                    { 6, "Jewelery", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(4153), null, "Nisi reprehenderit inventore magnam iure ratione anlamsız perferendis ratione bilgiyasayarı.", null, 1 },
                    { 7, "Music", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(4228), null, "Odio labore amet praesentium velit kulu numquam sandalye dolor adresini.", null, 1 },
                    { 8, "Grocery", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(4297), null, "Batarya ea ekşili aliquam quasi düşünüyor qui ötekinden kapının umut.", null, 1 },
                    { 9, "Computers", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(4364), null, "Fugit in ab doğru voluptatum dignissimos de mutlu dağılımı accusantium.", null, 1 },
                    { 10, "Music", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(4441), null, "Değerli aliquam sed voluptate çünkü voluptate amet dicta praesentium için.", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "ID", "AttributeName", "CreatedDate", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Fresh", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5712), null, null, 1 },
                    { 2, "Metal", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5746), null, null, 1 },
                    { 3, "Cotton", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5768), null, null, 1 },
                    { 4, "Concrete", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5788), null, null, 1 },
                    { 5, "Metal", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5808), null, null, 1 },
                    { 6, "Cotton", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5829), null, null, 1 },
                    { 7, "Fresh", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5857), null, null, 1 },
                    { 8, "Plastic", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5879), null, null, 1 },
                    { 9, "Plastic", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5901), null, null, 1 },
                    { 10, "Granite", new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5922), null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreatedDate", "DeletedDate", "ImagePath", "ModifiedDate", "ProductName", "Status", "UnitPrice", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(4601), null, "http://lorempixel.com/640/480/nightlife", null, "Unbranded Fresh Table", 1, 303.32m, 100 },
                    { 2, 2, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(4896), null, "http://lorempixel.com/640/480/nightlife", null, "Incredible Concrete Ball", 1, 818.01m, 100 },
                    { 3, 3, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(4993), null, "http://lorempixel.com/640/480/nightlife", null, "Rustic Concrete Salad", 1, 62.92m, 100 },
                    { 4, 4, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5074), null, "http://lorempixel.com/640/480/nightlife", null, "Handmade Granite Shirt", 1, 875.37m, 100 },
                    { 5, 5, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5163), null, "http://lorempixel.com/640/480/nightlife", null, "Incredible Cotton Keyboard", 1, 11.64m, 100 },
                    { 6, 6, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5243), null, "http://lorempixel.com/640/480/nightlife", null, "Handmade Granite Mouse", 1, 351.77m, 100 },
                    { 7, 7, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5323), null, "http://lorempixel.com/640/480/nightlife", null, "Licensed Wooden Chicken", 1, 367.33m, 100 },
                    { 8, 8, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5400), null, "http://lorempixel.com/640/480/nightlife", null, "Unbranded Frozen Pants", 1, 439.30m, 100 },
                    { 9, 9, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5488), null, "http://lorempixel.com/640/480/nightlife", null, "Sleek Steel Keyboard", 1, 555.52m, 100 },
                    { 10, 10, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5571), null, "http://lorempixel.com/640/480/nightlife", null, "Licensed Cotton Tuna", 1, 277.16m, 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductAndProductAttributes",
                columns: new[] { "ProductAttributeID", "ProductID", "CreatedDate", "DeletedDate", "ModifiedDate", "Status", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(5996), null, null, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { 2, 2, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6027), null, null, 1, "The Football Is Good For Training And Recreational Purposes" },
                    { 3, 3, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6048), null, null, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { 4, 4, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6068), null, null, 1, "The Football Is Good For Training And Recreational Purposes" },
                    { 5, 5, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6087), null, null, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { 6, 6, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6107), null, null, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" },
                    { 7, 7, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6127), null, null, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { 8, 8, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6146), null, null, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { 9, 9, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6166), null, null, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { 10, 10, new DateTime(2024, 5, 8, 23, 27, 41, 676, DateTimeKind.Local).AddTicks(6194), null, null, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" }
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
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserID",
                table: "Orders",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperID",
                table: "Orders",
                column: "ShipperID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAndProductAttributes_ProductID",
                table: "ProductAndProductAttributes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductAndProductAttributes");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
