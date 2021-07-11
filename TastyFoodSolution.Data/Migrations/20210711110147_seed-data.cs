using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 11, 18, 1, 46, 329, DateTimeKind.Local).AddTicks(3118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 11, 16, 36, 36, 594, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page" },
                    { "HomeSearch", "This is Search page" },
                    { "HomeDesc", "This is Desc page" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng Việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "IsFeatured", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 11, 18, 1, 46, 345, DateTimeKind.Local).AddTicks(4143), null, 100000m, 200000m },
                    { 2, new DateTime(2021, 7, 11, 18, 1, 46, 345, DateTimeKind.Local).AddTicks(6180), null, 150000m, 500000m }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Bánh mì", "banh-mi", "Sản phẩm bánh mì Việt Nam", "Sản phẩm bánh mì Việt Nam" },
                    { 3, 2, "vi-VN", "Đồ ăn nhanh", "do-an-nhanh", "Đồ ăn nhanh Việt Nam", "Đồ Ăn nhanh Việt Nam" },
                    { 2, 1, "en-US", "Bread", "bread", "Bread in Viet Nam", "Bread in Viet Nam" },
                    { 4, 2, "en-US", "Fast Fodd", "fast-food", "Fast Fodd in Viet Nam", "Fast Fodd in Viet Nam" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "Bánh mì ăn sáng Việt Nam", "Bánh mì ăn sáng Việt Nam", "vi-VN", "Bánh mì ăn sáng", 1, "banh-mi-an-sang", "Bánh mì ăn sáng Việt Nam", "Bánh mì ăn sáng Việt Nam" },
                    { 2, "Bread Breadfast Viet Nam", "Bread Breadfast Viet Nam", "en-US", "Bread Breadfast", 1, "bread-breadfast", "Bread Breadfast Viet Nam", "Bread Breadfast Viet Nam" },
                    { 3, "Gà rán Việt Nam", "Gà rán Việt Nam", "vi-VN", "Gà rán", 2, "ga-ran", "Gà rán Việt Nam", "Gà rán Việt Nam" },
                    { 4, "Chicken Fried Viet Nam", "Chicken Fried Viet Nam", "en-US", "Chicken Fried", 2, "chicken-fried", "Chicken Fried Viet Nam", "Chicken Fried Viet Nam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDesc");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeSearch");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 11, 16, 36, 36, 594, DateTimeKind.Local).AddTicks(8471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 11, 18, 1, 46, 329, DateTimeKind.Local).AddTicks(3118));
        }
    }
}
