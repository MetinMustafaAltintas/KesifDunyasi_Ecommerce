using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mtn3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "710c05a3-1990-448d-a86f-b31fcc1102e7", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 23, 25, 54, 534, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d097b2a4-89a2-4a1e-a2fa-968793eb04b1", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4447), "AQAAAAIAAYagAAAAEE3czHFswzi9O2XddQOtmAvvXxJPAyDyOG7s41zt3IZ2pqU3BD+zrGvPQDMdb7Bcqg==", "6124cb3c-14a9-4fc5-930b-2319375d7693" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(1173), "Quae fugit quia adipisci eum consequatur açılmadan lakin ullam sed." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(1657), "Eos kutusu tempora sunt non gitti quam quaerat mi deleniti." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(1746), "Olduğu dergi sevindi ratione sevindi eius non voluptatem bundan et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(1820), "Consequatur voluptate mi alias makinesi masanın türemiş tempora totam ama." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(1907), "İusto sequi quaerat gitti kutusu aliquam oldular sıfat consectetur aliquid." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(1983), "Voluptas filmini sıla in ea adanaya kulu voluptatem ipsa lakin." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(2054), "Tempora nemo consequatur reprehenderit corporis şafak masanın için qui exercitationem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(2123), "Adanaya esse yapacakmış gül doloremque quam et nemo magni olduğu." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(2201), "Umut sit quia yaptı quia masanın sit sed koyun velit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(2271), "Ea otobüs velit eos aliquid enim laboriosam koşuyorlar otobüs dolor." });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3959), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4031), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4057), "The Football Is Good For Training And Recreational Purposes" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4078), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4097), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4135), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(4155), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Fresh", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Fresh", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Granite", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Granite", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Soft", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Steel", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Metal", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Wooden", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Steel", new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(2426), "Intelligent Cotton Keyboard", 611.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(2846), "Ergonomic Steel Computer", 28.64m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(2955), "Unbranded Metal Car", 510.43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3043), "Ergonomic Cotton Keyboard", 353.12m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3123), "Gorgeous Granite Bacon", 23.38m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3204), "Handmade Wooden Computer", 95.08m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3294), "Intelligent Rubber Chair", 259.87m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3375), "Fantastic Fresh Shoes", 224.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3455), "Awesome Metal Table", 746.32m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 25, 54, 431, DateTimeKind.Local).AddTicks(3539), "Generic Fresh Shirt", 776.43m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "4085410a-1f78-48b6-b0ba-fc789807dd63", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 16, 9, 10, 760, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "297e3c66-2a69-4a33-bed0-68e8f70c7996", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(6054), "AQAAAAIAAYagAAAAEB9PuNMcbgBuluwMZXCFRhe2HjczgCyZGTd15cht3eoZRN+6mGPSLha/NOS8K43N3A==", "50e5fe7c-bfb2-40d1-af1a-9a61961087a4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(2717), "Dolore iusto quam voluptas alias sinema ducimus koyun bahar ekşili." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3130), "Et dolores koştum gül sıfat incidunt voluptatum sit çobanın mi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3234), "Aspernatur aliquam vel et doloremque voluptatum lambadaki bundan nihil değerli." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3317), "Olduğu numquam sunt ut şafak gül veniam velit dolayı camisi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3394), "Adresini sit layıkıyla yaptı için sıla kapının sarmal ullam aperiam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3472), "İnventore eos aliquam doğru minima minima ötekinden mi ut consequatur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3551), "İncidunt ona ipsa layıkıyla laudantium sayfası ducimus telefonu balıkhaneye autem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3622), "Consequatur ipsa domates ut duyulmamış fugit illo balıkhaneye koştum çünkü." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3692), "Patlıcan olduğu çıktılar sarmal eaque ratione oldular non corporis adipisci." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3767), "Makinesi illo bilgiyasayarı consequuntur magnam camisi adanaya umut tempora ve." });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5429), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5510), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5532), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5556), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5578), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5621), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5644), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Rubber", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Granite", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Frozen", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Rubber", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Granite", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Wooden", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Frozen", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Steel", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Plastic", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3927), "Licensed Soft Mouse", 458.92m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(4195), "Unbranded Rubber Gloves", 579.75m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(4301), "Small Soft Keyboard", 466.59m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(4397), "Ergonomic Granite Bacon", 760.41m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(4493), "Refined Soft Car", 20.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(4599), "Rustic Cotton Shirt", 877.87m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(4695), "Ergonomic Wooden Chips", 535.90m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(4789), "Awesome Wooden Chicken", 994.45m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(4883), "Gorgeous Cotton Computer", 576.32m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(4988), "Refined Metal Mouse", 964.62m });
        }
    }
}
