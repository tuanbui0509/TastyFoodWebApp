using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyFoodSolution.Data.Migrations
{
    public partial class updatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "IsShowOnHome",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "Desciption",
                table: "Categories",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desciption",
                table: "Categories");

            migrationBuilder.AddColumn<bool>(
                name: "IsShowOnHome",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "Name", "ParentId", "SortOrder", "Status", "Thumb" },
                values: new object[,]
                {
                    { 1, true, "Bánh mì", null, 1, 1, null },
                    { 2, true, "Đồ ăn nhanh", null, 1, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "IsFeatured", "Name", "OriginalPrice", "Price" },
                values: new object[] { 1, 1, new DateTime(2021, 7, 24, 15, 48, 21, 408, DateTimeKind.Local).AddTicks(6292), "Bánh mì ăn sáng Việt Nam", null, "Bánh mì ăn sáng", 100000m, 200000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "IsFeatured", "Name", "OriginalPrice", "Price" },
                values: new object[] { 2, 2, new DateTime(2021, 7, 24, 15, 48, 21, 409, DateTimeKind.Local).AddTicks(7753), "Gà rán Việt Nam", null, "Gà rán", 150000m, 500000m });
        }
    }
}
