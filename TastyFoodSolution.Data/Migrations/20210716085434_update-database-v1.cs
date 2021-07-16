using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class updatedatabasev1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9a9f1e42-95fb-43f5-8d60-e714daa26673");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2170419-c6d7-4c8d-8015-f77f4c8d7359", "AQAAAAEAACcQAAAAEK8WmLeF0tzL9dS+uT3Hcc60q6+kB0vC5tTWmGfuT0JHG+HUNolBMhiCJnsqhVFmbQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 16, 15, 54, 33, 89, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 16, 15, 54, 33, 89, DateTimeKind.Local).AddTicks(8561));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "dced76e8-6275-49af-ae95-4485e6b5ba4a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d69e281-0078-4415-b8c0-d26b4e2fceaa", "AQAAAAEAACcQAAAAEIKQeZ2jf8rBml7Oy10NDJpEXQLoMuf+TpJf7JeU3Kc5cCGRGk2UrVJDYvJcNYVT+Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 16, 10, 59, 25, 907, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 16, 10, 59, 25, 908, DateTimeKind.Local).AddTicks(4698));
        }
    }
}
