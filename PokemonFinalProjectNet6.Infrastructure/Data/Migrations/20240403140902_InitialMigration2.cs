using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Data.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Defense",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Actual Defense");

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Actual HP");

            migrationBuilder.AddColumn<int>(
                name: "SpecialAttack",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Actual Special Attack");

            migrationBuilder.AddColumn<int>(
                name: "SpecialDefense",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Actual Special Defense");

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Actual Speed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Defense",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "SpecialAttack",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "SpecialDefense",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Pokemons");
        }
    }
}
