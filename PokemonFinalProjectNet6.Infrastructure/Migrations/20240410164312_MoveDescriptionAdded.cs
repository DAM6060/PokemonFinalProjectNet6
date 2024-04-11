using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class MoveDescriptionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Moves",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c6d88f0-9f9d-4e5a-802f-280a3f1f9006", "AQAAAAEAACcQAAAAEDR8inh3d8RxXIOPmu6h84RtgEOeSMgZ6ge3sGoEOeFbSSMgnRu3N3RPcWaYrxq6kQ==", "b41e67eb-eda4-4ef5-b486-af813c73941b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4905aa2-276c-4868-91ad-59427948382a", "AQAAAAEAACcQAAAAENrb7/GQy4sxpvYb9j72H7hV+u0BNscL3PvKzRjgQMT0C57X/xxx2DFlkrlF08ExMQ==", "c0d490e3-365e-46cb-a659-44a48dbe6494" });

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The target is scorched with an intense blast of fire. This may also leave the target with a burn.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The target is punched with an electrified fist. This may also leave the target with paralysis.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "The user scatters a big cloud of sleep-inducing dust around the target.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "In this two-turn attack, the user gathers light, then blasts a bundled beam on the next turn.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "The user sets off an earthquake that strikes every Pokémon around it.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "The target is struck with large, imposing wings spread wide to inflict damage.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "The user bites the target. If the target is holding a Berry, the user eats it and gains its effect.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "After making its attack, the user rushes back to switch places with a party Pokémon in waiting.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "The user fights the target up close without guarding itself. This also lowers the user's Defense and Sp. Def stats.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "The user strikes the target with tough punches as fast as bullets.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "The user attacks the target with great power. However, this also lowers the user's Attack and Defense stats.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "The user makes the ground under the target erupt with power. This may also lower the target's Sp. Def stat.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Large boulders are hurled at the opposing Pokémon to inflict damage. This may also make the opposing Pokémon flinch.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "The user crunches up the target with sharp fangs. This may also lower the target's Sp. Def stat.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "The target is struck with an icy-cold beam of energy. This may also leave the target frozen.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "The target is punched with a fiery fist. This may also leave the target with a burn.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "The user attacks with a swift chop. It can also break barriers, such as Light Screen and Reflect.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Unsanitary sludge is hurled at the target. This may also poison the target.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "A wondrous wall of light is put up to reduce damage from physical attacks for five turns.");

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "A seed is planted on the target. It steals some HP from the target every turn.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Moves");

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
        }
    }
}
