using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class SeventhEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bca54de-162b-49d3-b1bc-bec9485256e5", "AQAAAAEAACcQAAAAEIHQ+v6Ll1kCjWWI7M5N5IQc0dNf5c9cc4NnKG5z/UUL2OQCX9cI7Zsehq7bFMgdEA==", "7787ee65-3da8-44df-8b34-b3032f320028" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f48e384d-cb2e-47ee-9f1a-0ca0ed7665fb", "AQAAAAEAACcQAAAAEBKYC2va6+kFu/HmpaeYvLOHtjbUUGaaJ1BYR+lMJGtChof2zkdxaT9ujf0555ouaQ==", "030826ad-e320-4fbb-9572-6bbd64ad6096" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75daf474-7cca-45c4-9176-675ff39c38db", "AQAAAAEAACcQAAAAEBhGW390qyziA6SHpSWQJe4gOUCM73tr//W6iJYUU5O21nBK1AgmwzyXWZyG2abB7Q==", "a417a9d8-9792-4235-a6f8-8eac738800d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ceeec75-4d4b-4902-ace3-3f505d5df269", "AQAAAAEAACcQAAAAEECK/24mr8tg2RLLvgKdHKc6KrQu9r2PcjS5Mop4cuZe7Duk08j4lQnJ6XPUStau9g==", "123a45d6-b504-4b55-9f1b-2ccfdd6dc641" });
        }
    }
}
