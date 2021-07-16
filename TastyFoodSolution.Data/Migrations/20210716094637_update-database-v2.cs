using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class updatedatabasev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "68897a32-43c2-4cd7-a161-0d6763fb9564");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e219e58-3d92-445e-a8e7-994eb1d80531", "AQAAAAEAACcQAAAAEPBUaI8SsgM/bZytTQckOphlIHRhf54C3Qki4NntZd+UK5+YoTJSucNm95yGLDQc/Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 16, 16, 46, 35, 665, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 16, 16, 46, 35, 666, DateTimeKind.Local).AddTicks(7971));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "DateCreated", "Details" },
                values: new object[] { new DateTime(2021, 7, 16, 15, 54, 33, 89, DateTimeKind.Local).AddTicks(433), "Bánh mì ăn sáng Việt Nam" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Details" },
                values: new object[] { new DateTime(2021, 7, 16, 15, 54, 33, 89, DateTimeKind.Local).AddTicks(8561), "Gà rán Việt Nam" });
        }
    }
}
