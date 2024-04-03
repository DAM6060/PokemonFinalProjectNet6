using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Data.Migrations
{
    public partial class SeedJointTableTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d9d4185-1098-4484-b218-7d7085dfd5a3", "AQAAAAEAACcQAAAAEGIacgPr2V+HzLRJhvAUmHkb4gEw0+oQYAP9QQUZhNiTTwCiGy4nOjEg/XBGXuwNQg==", "5e659ee7-03de-4486-aa14-a95b00540b89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd4087a8-5971-4aae-aabb-d7411efcbab6", "AQAAAAEAACcQAAAAEN3vhFd7j9I4gL6utdN3nDwK2CfnCZVZR68wRH/XKLsZWgnYkzMrGDh2F8TPORlyHA==", "b8f31f38-7fd6-44cc-acf5-eb1f05222649" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f626d745-1344-4c96-b320-9f7992315db2", "AQAAAAEAACcQAAAAEClfX2aXAlCJQrIqsbtXg37MzZ1esucsmOaHiVTQ99flXdGdEDq85pm4UGlwRfWFEw==", "4f31acfe-b4d5-4010-b38c-5cba2cd0efb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "977871f6-fb26-4d48-b499-863d898bcf06", "AQAAAAEAACcQAAAAEE9gfRgQ0CDcge/auybjLJR9e+alanIQVhm5GIG3XVRSDHCc7bvwL10DqEBW1RfGMg==", "1644c3f5-1b74-40d8-8006-2959c2e78094" });
        }
    }
}
