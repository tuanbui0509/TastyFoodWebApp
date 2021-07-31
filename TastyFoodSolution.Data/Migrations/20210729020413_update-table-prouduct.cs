using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class updatetableprouduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "dd88d68b-1871-4abe-9326-48eaed0b6624");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"),
                column: "ConcurrencyStamp",
                value: "9f767908-d41a-4858-8674-632b4fe30549");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68fa1978-57d4-4fd9-83ab-98ecddbdbce0", "AQAAAAEAACcQAAAAEI5+UJFo0v85y5WnrGhdTEKZfnQllBvUVqBhfKx0Q3Mx44dnxF58p2CqayFrZ8vBow==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "440a4dd2-9787-4cfe-8bbb-21b9f9985562", "AQAAAAEAACcQAAAAENAhohtGy+lFwXLsJbnRd4nYj4+j0UmPxjhzuwuz285I9k/jzAYCL7+BuOO4p9lZHw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3dd77fbe-6237-4bd5-b486-d9e8f8810484");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"),
                column: "ConcurrencyStamp",
                value: "8c109054-4e44-476b-8e09-10b8f9ced448");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "696d3027-64f8-4de5-88a0-d15778bdc6f6", "AQAAAAEAACcQAAAAEGJkCKryZ1GTdKRWjjaONst9cPsPrvEKHpCe/M6vhVnmFl32YNHOFdJ3xF2LrBD0oQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cda905d7-01a1-4e06-a966-51de5fe37406", "AQAAAAEAACcQAAAAEPQeoXm13cQR0JYgxXrMfINtNHDMHk97BKDsqUtaTvDXFzRRPmFAXlmWIO8KbjflJw==" });
        }
    }
}
