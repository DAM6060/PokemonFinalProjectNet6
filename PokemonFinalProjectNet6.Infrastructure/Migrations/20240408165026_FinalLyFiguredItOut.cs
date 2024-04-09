using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class FinalLyFiguredItOut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a232d48-5c22-4d51-873f-34339cc65763", "AQAAAAEAACcQAAAAEMhMElqjnyfwTj22OxYRZHoRXXrUJjkUTbeiCg/K4RePy5r4g6n4nMvCU+Q04NQ/Ag==", "b680b54f-65c2-442b-b45c-7c10c926729f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa07cf33-70cc-4bef-a0d5-622dcb4cf1be", "AQAAAAEAACcQAAAAEH8PifggkD54ctGBLlUFO5KhdTV32m2WmYYNC20EM+fGr3RqHV4jyzdZnQ9oY9yHRA==", "f5a887db-f48a-44e0-a19d-a24c9e0ae709" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "Id", "Accuracy", "Ailment", "AilmentChance", "DamageClass", "Effect", "EffectChance", "EffectDuration", "HealAmount", "HealType", "IsEffectUser", "Name", "Power", "PowerPoints", "Priority", "Type" },
                values: new object[] { 6, 100, "", 0, 0, "", 0, 0, 0, 0, null, "Earthquake", 100, 10, 0, "Ground" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 6, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30cb7b34-1cf8-4937-a872-5f44718f2b27", "AQAAAAEAACcQAAAAEJJ+5YRHStRLJwn4/W0yGinEoTTNuYkGPIuyY+Cyzjzs36nPrUbgB46EEU6chvabfQ==", "176219dd-fb6a-40cc-b914-f13896912e03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36efb85d-f145-4af8-9b9b-04496fa5e80d", "AQAAAAEAACcQAAAAEFnbT7tSd2MbSmg8S9nvJTPnX20hs+SWQeYYc27JgYiXmR7XQ9ZEVgA00HpJ3Io2CQ==", "bdfadb4a-ca3f-4b9b-ba64-2ae8300bb06a" });
        }
    }
}
