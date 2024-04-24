using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class InitialWithoutJoinTable : Migration
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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                    HP = table.Column<int>(type: "int", nullable: false, comment: "Actual HP"),
                    BaseAttack = table.Column<int>(type: "int", nullable: false),
                    EvAttack = table.Column<int>(type: "int", nullable: false, comment: "Effort values for attack set by player upon creation. Starting Value set to 0"),
                    Attack = table.Column<int>(type: "int", nullable: false, comment: "Actual Attack"),
                    BaseDefense = table.Column<int>(type: "int", nullable: false),
                    EvDefence = table.Column<int>(type: "int", nullable: false, comment: "Effort values for defence set by player upon creation. Starting Value set to 0"),
                    Defense = table.Column<int>(type: "int", nullable: false, comment: "Actual Defense"),
                    BaseSpecialAttack = table.Column<int>(type: "int", nullable: false),
                    EvSpecialAttack = table.Column<int>(type: "int", nullable: false, comment: "Effort values for Speacial Attack set by player upon creation. Starting Value set to 0"),
                    SpecialAttack = table.Column<int>(type: "int", nullable: false, comment: "Actual Special Attack"),
                    BaseSpecialDefense = table.Column<int>(type: "int", nullable: false),
                    EvSpecialDefense = table.Column<int>(type: "int", nullable: false, comment: "Effort values for Speacial Defeense set by player upon creation. Starting Value set to 0"),
                    SpecialDefense = table.Column<int>(type: "int", nullable: false, comment: "Actual Special Defense"),
                    BaseSpeed = table.Column<int>(type: "int", nullable: false),
                    EvSpeed = table.Column<int>(type: "int", nullable: false, comment: "Effort values for Speed set by player upon creation. Starting Value set to 0"),
                    Speed = table.Column<int>(type: "int", nullable: false, comment: "Actual Speed"),
                    Type1 = table.Column<int>(type: "int", nullable: false, comment: "The primary type of a pokemon"),
                    Type2 = table.Column<int>(type: "int", nullable: false, comment: "The secondary type of a pokemon"),
                    GenerationCustom = table.Column<int>(type: "int", nullable: false, comment: "Generation in which Pokemon is introduced"),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false, comment: "Team Identifier"),
                    PlayerId = table.Column<int>(type: "int", nullable: false, comment: "Team Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemons_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemons_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemons_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonsMoves_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "Description", "Name", "PhaseOfCombatActivaton" },
                values: new object[,]
                {
                    { 1, "Boosts the Pokémon's Speed stat in harsh sunlight.", "Chlorophyll", 1 },
                    { 2, "Powers up punching moves.", "Iron Fist", 3 },
                    { 3, "Powers up the Pokémon's weaker moves.", "Technician", 3 },
                    { 4, "Powers up moves of the same type.", "Adaptability", 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "92d1848f-ca54-4635-b61d-60f96685249e", "varnasharks.afc@gmail.com", false, false, null, "VARNASHARKS.AFC@GMAIL.COM", "DIMITARPLAYER", "AQAAAAEAACcQAAAAEO80XgJ21fcYMCu+BChaixNSEuNk9W3u/QXC/iB8oFyvkNFhGbNrfiqIkmTu/AgM3w==", null, false, "7ab8c50c-00b7-4598-9f19-1192abb12ab4", false, "DimitarPlayer" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "d62f1464-2538-4eb8-80da-5bf9cbe4ec18", "ddimitar98@gmail.com", false, false, null, "DDIMITAR98@GMAIL.COM", "DIMITARADMIN", "AQAAAAEAACcQAAAAEM04rRuaLQ8kig4qawmbwnlOId+niqEZrrdV+6NULv0Jfj25GGjwgVRSD7s3ERtWVA==", null, false, "0ab01ac0-c8b3-41cd-9256-0c9fb5f3439f", false, "DimitarAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "Id", "Accuracy", "Ailment", "AilmentChance", "DamageClass", "Effect", "EffectChance", "EffectDuration", "HealAmount", "HealType", "IsEffectUser", "Name", "Power", "PowerPoints", "Priority", "Type" },
                values: new object[,]
                {
                    { 1, 100, "Burn", 10, 1, "", 0, 0, 0, 0, null, "Flame Thrower", 90, 15, 0, "Fire" },
                    { 2, 100, "Paralysis", 10, 0, "", 0, 0, 0, 0, null, "Thunder Punch", 75, 15, 0, "Electric" },
                    { 3, 100, "", 0, 1, "Heal", 100, 0, 50, 2, true, "Giga Drain", 75, 10, 0, "Grass" },
                    { 4, 75, "Sleep", 100, 2, "", 0, 0, 0, 0, null, "Sleep Powder", 0, 15, 0, "Grass" },
                    { 5, 100, "", 0, 1, "", 0, 0, 0, 0, null, "Solar Beam", 120, 10, 0, "Grass" },
                    { 7, 100, "", 0, 0, "", 0, 0, 0, 0, null, "Wing Attack", 60, 35, 0, "Flying" },
                    { 8, 100, "", 0, 0, "", 0, 0, 0, 0, null, "Bug Bite", 60, 20, 0, "Bug" },
                    { 9, 100, "", 0, 0, "Force Switch", 100, 0, 0, 0, true, "U-Turn", 70, 20, 0, "Bug" },
                    { 10, 100, "", 0, 0, "Lower Def and SpDef", 0, 0, 0, 0, true, "Close Combat", 120, 5, 0, "Fighting" },
                    { 11, 100, "", 0, 0, "", 0, 0, 0, 0, null, "Bullet Punch", 40, 30, 1, "Steel" },
                    { 12, 100, "", 0, 0, "Lower Attack and Defense", 100, 0, 0, 0, true, "Super Power", 120, 5, 0, "Fighting" },
                    { 13, 100, "", 0, 1, "Lower SpDef", 10, 0, 0, 0, false, "Earth Power", 90, 10, 0, "Ground" },
                    { 14, 90, "", 0, 0, "Flinch", 30, 0, 0, 0, false, "Rock Slide", 75, 10, 0, "Rock" },
                    { 15, 100, "", 0, 0, "Lower SpDef", 20, 0, 0, 0, false, "Crunch", 80, 15, 0, "Dark" },
                    { 16, 100, "Freeze", 10, 1, "", 0, 0, 0, 0, null, "Ice Beam", 90, 10, 0, "Ice" },
                    { 17, 100, "Burn", 10, 0, "", 0, 0, 0, 0, null, "Fire Punch", 75, 15, 0, "Fire" },
                    { 18, 100, "", 0, 0, "Breaks Light Screen and Reflect", 100, 0, 0, 0, false, "Brick Break", 75, 15, 0, "Fighting" },
                    { 19, 100, "Poison", 30, 1, "", 0, 0, 0, 0, null, "Sludge Bomb", 90, 10, 0, "Poison" },
                    { 20, 0, "", 0, 2, "Doubles Defense", 100, 5, 0, 0, true, "Reflect", 0, 20, 0, "Psychic" },
                    { 21, 90, "Seeded", 100, 2, "Drain HP", 100, 0, 12, 2, false, "Leech Seed", 0, 10, 0, "Grass" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 1, "Dimitrakis", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 2, "Dimetros", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Losses", "Name", "PlayerId", "Wins" },
                values: new object[] { 1, 5, "Team1", 1, 10 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Losses", "Name", "PlayerId", "Wins" },
                values: new object[] { 2, 0, "Team2", 1, 100 });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "AbilityId", "Attack", "BaseAttack", "BaseDefense", "BaseHP", "BaseSpecialAttack", "BaseSpecialDefense", "BaseSpeed", "Defense", "EvAttack", "EvDefence", "EvHP", "EvSpecialAttack", "EvSpecialDefense", "EvSpeed", "GenerationCustom", "HP", "Level", "Name", "PlayerId", "PokeDexNumber", "SpecialAttack", "SpecialDefense", "Speed", "TeamId", "Type1", "Type2" },
                values: new object[,]
                {
                    { 1, 1, 82, 82, 83, 80, 100, 100, 80, 83, 0, 0, 0, 0, 4, 0, 1, 80, 50, "Venusaur", 1, 3, 100, 100, 80, 1, 4, 8 },
                    { 2, 2, 104, 104, 71, 76, 104, 71, 108, 71, 0, 0, 0, 0, 0, 0, 4, 76, 50, "Infernape", 1, 392, 104, 71, 108, 1, 2, 7 },
                    { 3, 4, 134, 134, 110, 100, 95, 100, 61, 110, 0, 0, 0, 0, 0, 0, 2, 100, 50, "Tyranitar", 1, 248, 95, 100, 61, 1, 13, 16 },
                    { 4, 3, 130, 130, 100, 70, 55, 80, 65, 100, 0, 0, 0, 0, 0, 0, 2, 70, 50, "Scizor", 1, 212, 55, 80, 65, 2, 12, 17 },
                    { 5, 2, 104, 104, 71, 76, 104, 71, 108, 71, 0, 0, 0, 0, 0, 0, 4, 76, 50, "Infernape", 1, 392, 104, 71, 108, 2, 2, 7 },
                    { 6, 1, 82, 82, 83, 80, 100, 100, 80, 83, 0, 0, 0, 0, 0, 0, 1, 80, 50, "Venusaur", 1, 3, 100, 100, 80, 2, 4, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_AbilityId",
                table: "Pokemons",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PlayerId",
                table: "Pokemons",
                column: "PlayerId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PokemonsMoves");

            migrationBuilder.DropTable(
                name: "Sudokos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
