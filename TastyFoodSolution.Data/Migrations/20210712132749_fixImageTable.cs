using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class fixImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "af025dd8-875d-4044-b063-38aef94036a5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c3ec33e-84bb-43f8-bd68-06c727302ada", "AQAAAAEAACcQAAAAENBFA64gSH3Hr+TM/MnZoxT//c4nSoo4S2f+rAasidDDR7cVbe3VCLT3E1+vRL7bHQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 16, 38, 25, 456, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 16, 38, 25, 456, DateTimeKind.Local).AddTicks(8012));
        }
    }
}
