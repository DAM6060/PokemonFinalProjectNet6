using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Data.Migrations
{
    public partial class InitialSeedWithoutJointTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "f626d745-1344-4c96-b320-9f7992315db2", "varnasharks.afc@gmail.com", false, false, null, "VARNASHARKS.AFC@GMAIL.COM", "DIMITARPLAYER", "AQAAAAEAACcQAAAAEClfX2aXAlCJQrIqsbtXg37MzZ1esucsmOaHiVTQ99flXdGdEDq85pm4UGlwRfWFEw==", null, false, "4f31acfe-b4d5-4010-b38c-5cba2cd0efb9", false, "DimitarPlayer" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "977871f6-fb26-4d48-b499-863d898bcf06", "ddimitar98@gmail.com", false, false, null, "DDIMITAR98@GMAIL.COM", "DIMITARADMIN", "AQAAAAEAACcQAAAAEE9gfRgQ0CDcge/auybjLJR9e+alanIQVhm5GIG3XVRSDHCc7bvwL10DqEBW1RfGMg==", null, false, "1644c3f5-1b74-40d8-8006-2959c2e78094", false, "DimitarAdmin" }
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
                columns: new[] { "Id", "AbilityId", "Attack", "BaseAttack", "BaseDefense", "BaseHP", "BaseSpecialAttack", "BaseSpecialDefense", "BaseSpeed", "Defense", "EvAttack", "EvDefence", "EvHP", "EvSpecialAttack", "EvSpecialDefense", "EvSpeed", "GenerationCustom", "HP", "Level", "Name", "PokeDexNumber", "SpecialAttack", "SpecialDefense", "Speed", "TeamId", "Type1", "Type2" },
                values: new object[,]
                {
                    { 1, 1, 82, 82, 83, 80, 100, 100, 80, 83, 0, 0, 0, 0, 4, 0, 1, 80, 50, "Venusaur", 3, 100, 100, 80, 1, "Grass", "Poison" },
                    { 2, 2, 104, 104, 71, 76, 104, 71, 108, 71, 0, 0, 0, 0, 0, 0, 4, 76, 50, "Infernape", 392, 104, 71, 108, 1, "Fire", "Fighting" },
                    { 3, 4, 134, 134, 110, 100, 95, 100, 61, 110, 0, 0, 0, 0, 0, 0, 2, 100, 50, "Tyranitar", 248, 95, 100, 61, 1, "Rock", "Dark" },
                    { 4, 3, 130, 130, 100, 70, 55, 80, 65, 100, 0, 0, 0, 0, 0, 0, 2, 70, 50, "Scizor", 212, 55, 80, 65, 2, "Bug", "Steel" },
                    { 5, 2, 104, 104, 71, 76, 104, 71, 108, 71, 0, 0, 0, 0, 0, 0, 4, 76, 50, "Infernape", 392, 104, 71, 108, 2, "Fire", "Fighting" },
                    { 6, 1, 82, 82, 83, 80, 100, 100, 80, 83, 0, 0, 0, 0, 0, 0, 1, 80, 50, "Venusaur", 3, 100, 100, 80, 2, "Grass", "Poison" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");
        }
    }
}
