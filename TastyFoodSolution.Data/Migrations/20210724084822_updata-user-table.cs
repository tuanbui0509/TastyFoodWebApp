using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class updatausertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "90f095b4-d9ba-4c29-9ae8-cd4740e6318a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"),
                column: "ConcurrencyStamp",
                value: "51aebb09-1dfa-4eba-8130-6cd01effe8d7");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6307d589-c593-406a-b76c-1c95de885b68", "AQAAAAEAACcQAAAAEJtn54iTKS/8fXZfyYtvtP9M2LXh6Z5TeDgF3eKVcpXxSexkXg5XZUMDezo4Xv/d+Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7be6c17a-6506-45a8-9467-0470b6b448ee", "AQAAAAEAACcQAAAAEIVXx5sZjMew6vYQ1HgqBUEPUCVD3+OREJ/vFJzSFwkNcMj4uDW9WOquphIJiLn8bg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 24, 15, 48, 21, 408, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 24, 15, 48, 21, 409, DateTimeKind.Local).AddTicks(7753));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AppUsers");

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
    }
}
