using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2a98c379-74cb-408b-a688-6c318fac334a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"),
                column: "ConcurrencyStamp",
                value: "aa93fd88-e148-46fb-8cd4-fa7fcfbae789");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c727f49-431c-4411-8213-24691859f8c7", "AQAAAAEAACcQAAAAEAaJVc96m0znuyrKrNZotLVuDZFG+t5ItEnl1di71TFf5SohEkKQv0oKMeni8sy1QQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08db2e0b-7fc7-4662-9a81-27a1b424d328", "AQAAAAEAACcQAAAAEHHhOOncZ44uBIEQRciq5SDPbQOGvZVNGaTjg6meMUeT60z2XmNx7yfh3hZueds7pA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 22, 5, 47, 693, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 22, 5, 47, 694, DateTimeKind.Local).AddTicks(3801));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page" },
                    { "HomeSearch", "This is Search page" },
                    { "HomeDesc", "This is Desc page" }
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "25941d5c-c3ae-4652-b7e2-dc7d7afae42d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"),
                column: "ConcurrencyStamp",
                value: "adffa8e5-e365-4c4a-b7e1-ebe8b0605a66");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d974822e-3c32-4251-9fbd-9e6ba2d59a74", "AQAAAAEAACcQAAAAENxEga+eAtMRQqedQUOCHiurn+O6SbgpmepFWsX8M3/EBJ+QzJMEhcEfcLr0ZCkYDg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1cca263e-5d18-479a-ba5e-943f943071ad", "AQAAAAEAACcQAAAAEEWpQy13ooWEPVFcLFtNSJ3x2Yw1NUcYwqn5Ejm31mDV6UQY0rQDtyDYgHigTTYqlA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 22, 3, 24, 360, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 22, 3, 24, 361, DateTimeKind.Local).AddTicks(4424));
        }
    }
}
