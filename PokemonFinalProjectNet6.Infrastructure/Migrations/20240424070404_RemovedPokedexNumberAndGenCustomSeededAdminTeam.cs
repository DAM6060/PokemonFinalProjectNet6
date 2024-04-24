using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class RemovedPokedexNumberAndGenCustomSeededAdminTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenerationCustom",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PokeDexNumber",
                table: "Pokemons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70438373-a14e-46a5-8437-0f45d7a32b65", "AQAAAAEAACcQAAAAEG9wpEXf+qe/YPIuMi38kpabnEfJwYQqrpmLog6kUQnMIUSOP4mi5xyWwy3iAhvU+A==", "e99ee6d8-b9f8-4549-8f82-7e762b638806" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab19b9df-7c3c-4d87-8eb9-e2b34f77d46e", "AQAAAAEAACcQAAAAEK7tYqMQdIBN5T8fpd6jAuiRIx6LP6A7pw7TtZzgzQR3cEQBu+CkjgSJaUY+wjDfVw==", "9d1bb631-83a9-4844-b743-e20a2f7dde55" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LobbyId", "Losses", "Name", "PlayerId", "Wins" },
                values: new object[] { 3, null, 0, "AdminTeamForSpeciesAddition", 2, 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "GenerationCustom",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Generation in which Pokemon is introduced");

            migrationBuilder.AddColumn<int>(
                name: "PokeDexNumber",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56023159-dfb2-4966-8fe3-1af9305576d0", "AQAAAAEAACcQAAAAEFknJqlU6g1DCTzr1q0oRMl26A2GHBcdr9FQ5Das4pnFTL+QyOrJEua9TVwwJD/3zA==", "8fe6689c-428b-4948-b8e5-462a8b17aca4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bd53178-7b0e-43ab-bd07-2532d3619d41", "AQAAAAEAACcQAAAAEPlIrsbUFFrMGWustPyuXWc7SqL60hjXAMTPNbFehUm6IJKThKcjUpV/h12SWJHLOA==", "7ebc0cd4-e912-4789-b99d-776e28f50994" });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GenerationCustom", "PokeDexNumber" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GenerationCustom", "PokeDexNumber" },
                values: new object[] { 4, 392 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GenerationCustom", "PokeDexNumber" },
                values: new object[] { 2, 248 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GenerationCustom", "PokeDexNumber" },
                values: new object[] { 2, 212 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GenerationCustom", "PokeDexNumber" },
                values: new object[] { 4, 392 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GenerationCustom", "PokeDexNumber" },
                values: new object[] { 1, 3 });
        }
    }
}
