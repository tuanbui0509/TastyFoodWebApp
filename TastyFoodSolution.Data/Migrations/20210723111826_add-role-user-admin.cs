using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class addroleuseradmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"),
                column: "ConcurrencyStamp",
                value: "20412017-4614-4fdc-aee6-b7ba873d4392");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "f7ebcbd0-ff89-4fcc-bf0e-d288c50f48ab", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ffec662-0923-4403-9026-918364214231", "AQAAAAEAACcQAAAAEIoquAY20NMQ3QrkKKUzRFth9ktouFxz7WxJ7Dyykrbl5x8ZiErARVnAc9gEq8rvFA==" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "edb75054-626f-42be-b7a3-4e0079beb421", new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuanbui0509@gmail.com", true, "Tuan", "Ngoc", false, null, "tuanbui0509@gmail.com", "admin", "AQAAAAEAACcQAAAAEDRxp/rCkiOd3KDO2VrfaOUvQ/I4P2L8GEpOaedcuLXmeM1EyCQFZJHJvWiiurp0HQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 18, 18, 25, 234, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 18, 18, 25, 235, DateTimeKind.Local).AddTicks(2911));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce7e4c06-84b0-4114-912f-7e27f245dc47"),
                column: "ConcurrencyStamp",
                value: "335164bb-dd78-4ae7-a9e7-eb25a729aa62");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa16f18b-95b9-4e6a-837e-efb5b8e63e84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1d98c4a-0ec3-4915-b8bd-eafc0dca869e", "AQAAAAEAACcQAAAAEA+CaNz2FviVn3XTZKa5LO2IN6D8zahEYCWubEm+INcvk+rN/CJ5o6UgX6qhLU2j/g==" });

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
    }
}
