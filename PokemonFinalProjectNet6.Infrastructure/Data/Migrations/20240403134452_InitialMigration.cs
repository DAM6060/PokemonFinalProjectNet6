using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhaseOfCombatActivaton = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });


           
            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier of a move")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false, comment: "Attack power of a move"),
                    Accuracy = table.Column<int>(type: "int", nullable: false, comment: "Accuracy of a move"),
                    PowerPoints = table.Column<int>(type: "int", nullable: false, comment: "How many times a use can be used in battle"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Type of a move"),
                    EffectChance = table.Column<int>(type: "int", nullable: false, comment: "Chance of additional effect"),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Name of additional effect"),
                    EffectDuration = table.Column<int>(type: "int", nullable: false),
                    Ailment = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Ailment that attack may induce"),
                    AilmentChance = table.Column<int>(type: "int", nullable: false, comment: "Chance of ailment being induced"),
                    DamageClass = table.Column<int>(type: "int", nullable: false, comment: "Physical Special or Status"),
                    IsEffectUser = table.Column<bool>(type: "bit", nullable: true),
                    HealAmount = table.Column<int>(type: "int", nullable: false, comment: "The percent of heath Restored Based on damage or userHealt"),
                    HealType = table.Column<int>(type: "int", nullable: false, comment: "If the heal is based on own Hp or DamageDelt"),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sudokos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Row1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Column1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row1xColumn1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row1xColumn2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row1xColumn3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row2xColumn1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row2xColumn2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row2xColumn3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row3xColumn1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row3xColumn2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row3xColumn3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sudokos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false, comment: "User Identifier"),
                    Wins = table.Column<int>(type: "int", nullable: false, comment: "Number of Wins"),
                    Losses = table.Column<int>(type: "int", nullable: false, comment: "Number of Losses")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokeDexNumber = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    BaseHP = table.Column<int>(type: "int", nullable: false),
                    EvHP = table.Column<int>(type: "int", nullable: false, comment: "Effort values for health points set by player upon creation. Starting Value set to 0"),
                    BaseAttack = table.Column<int>(type: "int", nullable: false),
                    EvAttack = table.Column<int>(type: "int", nullable: false, comment: "Effort values for attack set by player upon creation. Starting Value set to 0"),
                    BaseDefense = table.Column<int>(type: "int", nullable: false),
                    EvDefence = table.Column<int>(type: "int", nullable: false, comment: "Effort values for defence set by player upon creation. Starting Value set to 0"),
                    BaseSpecialAttack = table.Column<int>(type: "int", nullable: false),
                    EvSpecialAttack = table.Column<int>(type: "int", nullable: false, comment: "Effort values for Speacial Attack set by player upon creation. Starting Value set to 0"),
                    BaseSpecialDefense = table.Column<int>(type: "int", nullable: false),
                    EvSpecialDefense = table.Column<int>(type: "int", nullable: false, comment: "Effort values for Speacial Defeense set by player upon creation. Starting Value set to 0"),
                    BaseSpeed = table.Column<int>(type: "int", nullable: false),
                    EvSpeed = table.Column<int>(type: "int", nullable: false, comment: "Effort values for Speed set by player upon creation. Starting Value set to 0"),
                    Type1 = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The primary type of a pokemon"),
                    Type2 = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The secondary type of a pokemon"),
                    GenerationCustom = table.Column<int>(type: "int", nullable: false, comment: "Generation in which Pokemon is introduced"),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false, comment: "Team Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemons_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemons_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonsMoves",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    MoveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonsMoves", x => new { x.PokemonId, x.MoveId });
                    table.ForeignKey(
                        name: "FK_PokemonsMoves_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonsMoves_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            
            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_AbilityId",
                table: "Pokemons",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TeamId",
                table: "Pokemons",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonsMoves_MoveId",
                table: "PokemonsMoves",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PlayerId",
                table: "Teams",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropTable(
                name: "PokemonsMoves");

            migrationBuilder.DropTable(
                name: "Sudokos");


            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Players");

           
        }
    }
}
