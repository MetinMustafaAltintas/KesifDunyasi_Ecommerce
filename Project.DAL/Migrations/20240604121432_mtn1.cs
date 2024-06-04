using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mtn1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Profiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ctiy",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6149));

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
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(6203), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" });

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
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5471));

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
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Steel", new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5763) });

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
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 14, 31, 421, DateTimeKind.Local).AddTicks(5866));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Ctiy",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Profiles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e1525353-927b-405a-808d-8120ac3b9f93", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 21, 58, 3, 870, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "992de8dd-d2de-4308-a34f-68f8dba8f493", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(7321), "AQAAAAIAAYagAAAAEGrfF4E0oZE1dI0aVKDY24AH0LvUK7tb9wm/qSlrCGnn6IzfOtI0Bp/aXWj3cJKI3Q==", "dff64831-68b7-4c6a-95e7-2bc2b0a34f79" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(3495), "Ex otobüs orta adipisci aspernatur adanaya ut layıkıyla eos layıkıyla." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4218), "Duyulmamış kalemi sinema adanaya mutlu masanın dolorem ama bilgiyasayarı quam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4308), "Nihil ut eius domates dışarı enim voluptatem incidunt adresini veritatis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4395), "Beatae ötekinden ut exercitationem consectetur esse velit qui doloremque sandalye." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4476), "Okuma quam nemo esse voluptatem veritatis aspernatur ışık masaya ışık." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4548), "Bundan değirmeni voluptatem göze enim ratione non aspernatur doloremque nostrum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4620), "Dolore magnam corporis minima mıknatıslı ötekinden sit cesurca inventore ullam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4691), "Adresini tv oldular ama dağılımı gülüyorum quaerat çıktılar quia ea." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4779), "Masaya teldeki iure çünkü voluptatem dolayı layıkıyla voluptate explicabo magni." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(4852), "Et okuma voluptate reprehenderit consequatur batarya odit quasi ut ışık." });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6657), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6680), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6714), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6737), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6760), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6781), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6801), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6820), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" });

            migrationBuilder.UpdateData(
                table: "ProductAndProductAttributes",
                keyColumns: new[] { "ProductAttributeID", "ProductID" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6841), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Steel", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Cotton", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Soft", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Soft", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Concrete", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Plastic", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Concrete", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AttributeName", "CreatedDate" },
                values: new object[] { "Cotton", new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5057), "Rustic Steel Fish", 854.81m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5438), "Generic Granite Chips", 252.98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5547), "Intelligent Soft Chair", 631.66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5637), "Rustic Fresh Shirt", 358.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5723), "Small Fresh Cheese", 903.52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5813), "Fantastic Steel Mouse", 843.69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(5912), "Refined Rubber Towels", 827.56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6004), "Unbranded Frozen Sausages", 630.32m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6090), "Practical Cotton Car", 550.50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 58, 3, 776, DateTimeKind.Local).AddTicks(6176), "Unbranded Soft Keyboard", 747.44m });
        }
    }
}
