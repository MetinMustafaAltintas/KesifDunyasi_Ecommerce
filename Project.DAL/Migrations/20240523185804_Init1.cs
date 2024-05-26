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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "ModifiedDate", "Name", "NormalizedName", "Status" },
                values: new object[] { 1, "e1525353-927b-405a-808d-8120ac3b9f93", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6909), null, null, "Admin", "ADMIN", 1 });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationCode", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, null, "992de8dd-d2de-4308-a34f-68f8dba8f493", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(7321), null, "metinmustafaaltintas@gmail.com", true, false, null, null, "METINMUSTAFAALTINTAS@GMAIL.COM", "METIN", "AQAAAAIAAYagAAAAEGrfF4E0oZE1dI0aVKDY24AH0LvUK7tb9wm/qSlrCGnn6IzfOtI0Bp/aXWj3cJKI3Q==", null, false, "dff64831-68b7-4c6a-95e7-2bc2b0a34f79", 1, false, "metin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedDate", "DeletedDate", "Description", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Books", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(3495), null, "Ex otobüs orta adipisci aspernatur adanaya ut layıkıyla eos layıkıyla.", null, 1 },
                    { 2, "Computers", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4218), null, "Duyulmamış kalemi sinema adanaya mutlu masanın dolorem ama bilgiyasayarı quam.", null, 1 },
                    { 3, "Grocery", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4308), null, "Nihil ut eius domates dışarı enim voluptatem incidunt adresini veritatis.", null, 1 },
                    { 4, "Computers", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4395), null, "Beatae ötekinden ut exercitationem consectetur esse velit qui doloremque sandalye.", null, 1 },
                    { 5, "Industrial", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4476), null, "Okuma quam nemo esse voluptatem veritatis aspernatur ışık masaya ışık.", null, 1 },
                    { 6, "Music", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4548), null, "Bundan değirmeni voluptatem göze enim ratione non aspernatur doloremque nostrum.", null, 1 },
                    { 7, "Jewelery", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4620), null, "Dolore magnam corporis minima mıknatıslı ötekinden sit cesurca inventore ullam.", null, 1 },
                    { 8, "Industrial", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4691), null, "Adresini tv oldular ama dağılımı gülüyorum quaerat çıktılar quia ea.", null, 1 },
                    { 9, "Electronics", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4779), null, "Masaya teldeki iure çünkü voluptatem dolayı layıkıyla voluptate explicabo magni.", null, 1 },
                    { 10, "Toys", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4852), null, "Et okuma voluptate reprehenderit consequatur batarya odit quasi ut ışık.", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "ID", "AttributeName", "CreatedDate", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Wooden", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6346), null, null, 1 },
                    { 2, "Steel", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6385), null, null, 1 },
                    { 3, "Cotton", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6408), null, null, 1 },
                    { 4, "Soft", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6428), null, null, 1 },
                    { 5, "Soft", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6449), null, null, 1 },
                    { 6, "Concrete", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6472), null, null, 1 },
                    { 7, "Plastic", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6493), null, null, 1 },
                    { 8, "Concrete", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6514), null, null, 1 },
                    { 9, "Frozen", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6534), null, null, 1 },
                    { 10, "Cotton", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6555), null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedDate", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[] { 1, 1, new DateTime(2024, 5, 23, 21, 58, 3, 870, DateTimeKind.Local).AddTicks(7167), null, null, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreatedDate", "DeletedDate", "ImagePath", "ModifiedDate", "ProductName", "Status", "UnitPrice", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5057), null, "http://lorempixel.com/640/480/nightlife", null, "Rustic Steel Fish", 1, 854.81m, 100 },
                    { 2, 2, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5438), null, "http://lorempixel.com/640/480/nightlife", null, "Generic Granite Chips", 1, 252.98m, 100 },
                    { 3, 3, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5547), null, "http://lorempixel.com/640/480/nightlife", null, "Intelligent Soft Chair", 1, 631.66m, 100 },
                    { 4, 4, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5637), null, "http://lorempixel.com/640/480/nightlife", null, "Rustic Fresh Shirt", 1, 358.00m, 100 },
                    { 5, 5, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5723), null, "http://lorempixel.com/640/480/nightlife", null, "Small Fresh Cheese", 1, 903.52m, 100 },
                    { 6, 6, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5813), null, "http://lorempixel.com/640/480/nightlife", null, "Fantastic Steel Mouse", 1, 843.69m, 100 },
                    { 7, 7, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5912), null, "http://lorempixel.com/640/480/nightlife", null, "Refined Rubber Towels", 1, 827.56m, 100 },
                    { 8, 8, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6004), null, "http://lorempixel.com/640/480/nightlife", null, "Unbranded Frozen Sausages", 1, 630.32m, 100 },
                    { 9, 9, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6090), null, "http://lorempixel.com/640/480/nightlife", null, "Practical Cotton Car", 1, 550.50m, 100 },
                    { 10, 10, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6176), null, "http://lorempixel.com/640/480/nightlife", null, "Unbranded Soft Keyboard", 1, 747.44m, 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductAndProductAttributes",
                columns: new[] { "ProductAttributeID", "ProductID", "CreatedDate", "DeletedDate", "ModifiedDate", "Status", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6626), null, null, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { 2, 2, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6657), null, null, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { 3, 3, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6680), null, null, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" },
                    { 4, 4, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6714), null, null, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { 5, 5, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6737), null, null, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" },
                    { 6, 6, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6760), null, null, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { 7, 7, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6781), null, null, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { 8, 8, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6801), null, null, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { 9, 9, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6820), null, null, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { 10, 10, new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6841), null, null, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" }
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
