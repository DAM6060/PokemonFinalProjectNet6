using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class SixthEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 10, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59c042ab-10ec-4232-b6d4-a590ec8fbae5", "AQAAAAEAACcQAAAAEBz3VHjx9tohQMKO7e3vdPg+ia7PP+lyYL2XocofqvhWgSvDj2zEJBAxvPcHMFDruQ==", "221dd350-1e4f-4567-aa98-debd1f010fd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abe13025-303c-48a7-abca-7c66a82df939", "AQAAAAEAACcQAAAAEHyexo0DO4r/Wuzty9PqpnHdJUzEmqvwQblKYpIS+YdCqP1H+n/bO7iBBns902/Fyg==", "bbf3f927-4027-43ba-b49d-2cc599c71dc5" });
        }
    }
}
