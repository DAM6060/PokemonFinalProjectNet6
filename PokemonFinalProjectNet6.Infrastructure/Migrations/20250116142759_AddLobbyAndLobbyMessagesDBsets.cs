using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class AddLobbyAndLobbyMessagesDBsets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Lobbies_LobbyId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_LobbyId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "LobbyId",
                table: "Teams");

            migrationBuilder.AddColumn<string>(
                name: "LobbyName",
                table: "Lobbies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "LobbyMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    LobbyId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LobbyMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LobbyMessages_Lobbies_LobbyId",
                        column: x => x.LobbyId,
                        principalTable: "Lobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc9c3855-87a5-44b6-b024-18ce598a7293", "AQAAAAEAACcQAAAAEDyKIQ9OiGx41oS0sMJmTcDUgjIazDuMpu/SeJg0WNkHSaWtIg5A41zO34Vgwg9YZw==", "7fc23896-82cc-400a-a780-d46476949b8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3750704f-1930-4357-9d09-3c014e274f4c", "AQAAAAEAACcQAAAAEC1i1jl8oL8PKwJNCsq73eeMcFjEsXO1bOCpn2jOBp52ZO2qS9lNon5v0nG8x5vNzA==", "ef5695df-3a9a-4e78-91c1-ab295dee959c" });

            migrationBuilder.CreateIndex(
                name: "IX_LobbyMessages_LobbyId",
                table: "LobbyMessages",
                column: "LobbyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LobbyMessages");

            migrationBuilder.DropColumn(
                name: "LobbyName",
                table: "Lobbies");

            migrationBuilder.AddColumn<int>(
                name: "LobbyId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78394649-2eef-4730-91a6-5af840819de4", "AQAAAAEAACcQAAAAECctuq3cROcKuyZIv5DeCX/TZPiXSOuKfZe2vpQmnHR5WKzQBnpI5Ktyyp7ZG4OnKw==", "c447e361-004c-4ad9-aa38-3f1e1c79fbe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc4b0fed-e751-4968-8bd6-a6ef830ecb3f", "AQAAAAEAACcQAAAAECiXpByNfG+Q0r7063hvgIMn1tPsh/lzBS6mpnVJVB/X+HeMPM07awauiVoDgS8WZA==", "adf2b980-7f1d-45fe-9eb4-abad20e5afc1" });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LobbyId",
                table: "Teams",
                column: "LobbyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Lobbies_LobbyId",
                table: "Teams",
                column: "LobbyId",
                principalTable: "Lobbies",
                principalColumn: "Id");
        }
    }
}
