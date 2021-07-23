using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class addroleuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"), "335164bb-dd78-4ae7-a9e7-eb25a729aa62", "User role", "User", "user" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"), new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84"), 0, "b1d98c4a-0ec3-4915-b8bd-eafc0dca869e", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "User", "My", false, null, "user@gmail.com", "user", "AQAAAAEAACcQAAAAEA+CaNz2FviVn3XTZKa5LO2IN6D8zahEYCWubEm+INcvk+rN/CJ5o6UgX6qhLU2j/g==", null, false, "", false, "user" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 16, 21, 34, 25, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 16, 21, 34, 26, DateTimeKind.Local).AddTicks(4458));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"), new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84"));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "8fab5c94-0d70-46e7-a3dc-a65a783ce2d0", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "1140ceaa-5287-43b2-84b7-14d5f8d94888", new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuanbui0509@gmail.com", true, "Tuan", "Ngoc", false, null, "tuanbui0509@gmail.com", "admin", "AQAAAAEAACcQAAAAELY94xis+m8v87IBQCz0UCFUdDxGvDqAS+Rs07BGgrPXzv5AG9PQcBW3pLDYArorAw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 22, 45, 52, 950, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 22, 45, 52, 951, DateTimeKind.Local).AddTicks(6924));
        }
    }
}
