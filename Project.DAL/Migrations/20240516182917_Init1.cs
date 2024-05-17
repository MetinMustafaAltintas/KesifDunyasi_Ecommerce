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
                values: new object[] { 1, "f95d0995-b517-4a57-b014-93291bb51268", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationCode", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, null, "d895f34c-32b0-44cf-806d-efb543015175", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8509), null, "metinmustafaaltintas@gmail.com", true, false, null, null, "METINMUSTAFAALTINTAS@GMAIL.COM", "METIN", "AQAAAAIAAYagAAAAEHn2InUbbx8uEDTG1Msi8Bz39xVEeVmeh2ERGAtAkw3qdgAz4+k85wi17OywQtzWsw==", null, false, "57ccfbbf-716d-4e3b-abad-8063979787d2", 1, false, "metin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedDate", "DeletedDate", "Description", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Shoes", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(5506), null, "Ex lambadaki sarmal sandalye un ut çorba qui consequatur inventore.", null, 1 },
                    { 2, "Sports", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(5922), null, "Dağılımı için non ea quis et doğru consequatur rem voluptatem.", null, 1 },
                    { 3, "Jewelery", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6005), null, "Ekşili consequuntur consectetur bilgisayarı architecto ullam sıradanlıktan mi exercitationem explicabo.", null, 1 },
                    { 4, "Books", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6088), null, "Makinesi lambadaki quia iusto exercitationem in uzattı velit duyulmamış aliquam.", null, 1 },
                    { 5, "Toys", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6160), null, "Magnam magni odit bundan domates umut rem türemiş gülüyorum enim.", null, 1 },
                    { 6, "Games", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6233), null, "Gördüm ut oldular lambadaki odio incidunt quis ipsum ea architecto.", null, 1 },
                    { 7, "Computers", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6302), null, "Oldular consequuntur voluptas voluptate odio masanın ex düşünüyor voluptatem corporis.", null, 1 },
                    { 8, "Sports", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6379), null, "Gülüyorum camisi eaque voluptatem sit aut suscipit ad öyle quia.", null, 1 },
                    { 9, "Shoes", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6447), null, "Camisi consequuntur suscipit beğendim dicta gitti mıknatıslı ut et quaerat.", null, 1 },
                    { 10, "Books", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6514), null, "Sed iusto incidunt ut voluptatem nisi consequatur sequi ducimus fugit.", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "ID", "AttributeName", "CreatedDate", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Concrete", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7756), null, null, 1 },
                    { 2, "Granite", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7789), null, null, 1 },
                    { 3, "Fresh", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7809), null, null, 1 },
                    { 4, "Wooden", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7829), null, null, 1 },
                    { 5, "Fresh", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7848), null, null, 1 },
                    { 6, "Metal", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7869), null, null, 1 },
                    { 7, "Metal", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7888), null, null, 1 },
                    { 8, "Fresh", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7908), null, null, 1 },
                    { 9, "Fresh", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7927), null, null, 1 },
                    { 10, "Steel", new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7948), null, null, 1 }
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
                    { 1, 1, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6660), null, "http://lorempixel.com/640/480/nightlife", null, "Refined Soft Hat", 1, 936.98m, 100 },
                    { 2, 2, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(6940), null, "http://lorempixel.com/640/480/nightlife", null, "Tasty Fresh Chips", 1, 821.96m, 100 },
                    { 3, 3, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7035), null, "http://lorempixel.com/640/480/nightlife", null, "Practical Rubber Chair", 1, 435.76m, 100 },
                    { 4, 4, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7120), null, "http://lorempixel.com/640/480/nightlife", null, "Handmade Wooden Chair", 1, 881.02m, 100 },
                    { 5, 5, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7199), null, "http://lorempixel.com/640/480/nightlife", null, "Intelligent Frozen Gloves", 1, 607.18m, 100 },
                    { 6, 6, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7290), null, "http://lorempixel.com/640/480/nightlife", null, "Rustic Steel Cheese", 1, 788.21m, 100 },
                    { 7, 7, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7373), null, "http://lorempixel.com/640/480/nightlife", null, "Awesome Soft Fish", 1, 612.82m, 100 },
                    { 8, 8, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7453), null, "http://lorempixel.com/640/480/nightlife", null, "Sleek Rubber Bike", 1, 17.40m, 100 },
                    { 9, 9, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7533), null, "http://lorempixel.com/640/480/nightlife", null, "Awesome Frozen Sausages", 1, 489.98m, 100 },
                    { 10, 10, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(7616), null, "http://lorempixel.com/640/480/nightlife", null, "Unbranded Wooden Chips", 1, 532.01m, 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductAndProductAttributes",
                columns: new[] { "ProductAttributeID", "ProductID", "CreatedDate", "DeletedDate", "ModifiedDate", "Status", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8012), null, null, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { 2, 2, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8051), null, null, 1, "The Football Is Good For Training And Recreational Purposes" },
                    { 3, 3, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8072), null, null, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { 4, 4, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8091), null, null, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { 5, 5, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8109), null, null, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { 6, 6, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8129), null, null, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" },
                    { 7, 7, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8147), null, null, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" },
                    { 8, 8, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8166), null, null, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { 9, 9, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8185), null, null, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { 10, 10, new DateTime(2024, 5, 16, 21, 29, 16, 554, DateTimeKind.Local).AddTicks(8205), null, null, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" }
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
