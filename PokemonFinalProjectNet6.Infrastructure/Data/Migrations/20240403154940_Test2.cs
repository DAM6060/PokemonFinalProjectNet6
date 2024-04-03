using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Data.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e7e65ca-4065-4a2d-925a-cddadc703b86", "AQAAAAEAACcQAAAAENSxTxuSZj27QaixK/W/6nhB1erA1UFOnSwTF7UqC9QrRIbvC+roH7KVkqQx900nLw==", "dc62bc90-da9d-4916-84eb-f288ba72c8e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fb2e384-f10b-49b5-b0b7-6e0d82d51ed7", "AQAAAAEAACcQAAAAEKWzI/6u+PqNhrqIHXnu0eRUP5u8kDlvt6gQzYKjeBhDrCg9nxl6RYPerZg0yEm/wg==", "63b1c145-1cf1-4f78-bdd4-61082630009a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
