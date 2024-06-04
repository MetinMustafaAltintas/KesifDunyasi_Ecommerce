using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mtn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ctiy",
                table: "Profiles",
                newName: "City");

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
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(3622), "Consequatur ipsa domates ut duyulmamış fugit illo balıkhaneye koştum çünkü." });

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
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5465), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" });

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
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 9, 10, 680, DateTimeKind.Local).AddTicks(5600), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Profiles",
                newName: "Ctiy");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "19506cf5-2c5d-45fa-87ee-3886a93c86e0", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 14, 31, 519, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13ea3109-7428-4c12-a41f-6b0024a58928", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(7077), "AQAAAAIAAYagAAAAELIyq7oUVuFBhO6m+OtOoS7P1DGZWeRI7oxEAVDygdpUoKKwobPCDoXZL0hJAVfXwg==", "56c4875c-2767-44f7-ac4f-04b8bd6f2a26" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(1595), "Sit ki veritatis quis incidunt yaptı quis teldeki tv bundan." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(2239), "Exercitationem velit orta dicta perferendis inventore yapacakmış ex yapacakmış cesurca." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(2353), "İnventore quia çünkü ut exercitationem sıradanlıktan dicta bahar nisi alias." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(2424), "Çünkü ut otobüs enim sıradanlıktan sit odit sevindi quia suscipit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(2500), "Adanaya patlıcan reprehenderit çorba adresini corporis bilgisayarı mi bahar makinesi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(2577), "Aperiam nisi camisi sandalye cesurca sıla ut kutusu quia incidunt." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(2859), "Ama consequatur sevindi sandalye totam un ona lakin türemiş aut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(2936), "Layıkıyla nemo consequuntur umut patlıcan aut ut nesciunt dolor şafak." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(3194), "Eve lakin minima iusto değerli illo sed sed gitti gül." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(3632), "Açılmadan sayfası çobanın sevindi voluptatem vel rem esse çıktılar blanditiis." });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6149), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6180), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6223), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6243), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6265), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6285), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6304), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6323), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6343), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Wooden", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Rubber", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Fresh", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Granite", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Soft", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Rubber", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Rubber", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Frozen", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Concrete", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(3883), "Sleek Fresh Salad", 350.05m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(4231), "Practical Frozen Computer", 34.71m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(4331), "Unbranded Wooden Towels", 117.65m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(4417), "Handmade Rubber Car", 755.16m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(4688), "Tasty Concrete Car", 186.67m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(4974), "Generic Wooden Pants", 58.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5057), "Gorgeous Rubber Cheese", 684.12m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5138), "Tasty Plastic Chips", 436.03m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5220), "Sleek Metal Keyboard", 96.38m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5313), "Awesome Soft Soap", 946.23m });
        }
    }
}
