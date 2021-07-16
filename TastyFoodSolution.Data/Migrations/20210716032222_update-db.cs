using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropIndex(
                name: "IX_CategoryTranslations_LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "SeoDescription",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "SeoTitle",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c7398356-44d1-46dc-b78e-2406751c7ddd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec2d05a0-a299-44be-9e30-f935462776fd", "AQAAAAEAACcQAAAAEPUlclCT8Z9GxmvMaHT5XhdRCkIXiy2zdwNXA9mbKkSDGaU4xaieBFPqNC1Fq8MGLQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 16, 10, 22, 21, 9, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 16, 10, 22, 21, 9, DateTimeKind.Local).AddTicks(9186));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LanguageId",
                table: "ProductTranslations",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "ProductTranslations",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoDescription",
                table: "ProductTranslations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoTitle",
                table: "ProductTranslations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LanguageId",
                table: "CategoryTranslations",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0a7f8b39-3137-4393-9eed-62821241b967");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f7232df-ca15-40be-bb72-93b49af40860", "AQAAAAEAACcQAAAAELsbqu6r0emAdm94Zw++l2kRpRtFJoFlFlao6wsOVSNAd0atBEYIBBKK3VfV7Nen8A==" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng Việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 20, 27, 48, 134, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 20, 27, 48, 135, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LanguageId",
                value: "vi-VN");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LanguageId",
                value: "en-US");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LanguageId",
                value: "vi-VN");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                column: "LanguageId",
                value: "en-US");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LanguageId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "vi-VN", "banh-mi-an-sang", "Bánh mì ăn sáng Việt Nam", "Bánh mì ăn sáng Việt Nam" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LanguageId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "en-US", "bread-breadfast", "Bread Breadfast Viet Nam", "Bread Breadfast Viet Nam" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LanguageId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "vi-VN", "ga-ran", "Gà rán Việt Nam", "Gà rán Việt Nam" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LanguageId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "en-US", "chicken-fried", "Chicken Fried Viet Nam", "Chicken Fried Viet Nam" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslations_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
