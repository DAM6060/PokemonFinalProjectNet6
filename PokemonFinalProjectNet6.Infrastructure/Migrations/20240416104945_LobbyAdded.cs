using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class LobbyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LobbyId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LobbyId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Lobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lobbies", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6655937-acc7-4692-940a-dc7c1488897e", "AQAAAAEAACcQAAAAEGYSrdDxb4s+flj1NtaKgviAO+lJqt90zLAeOzFiwJHp5Ph2FLWwa+OGp81BoCkuOA==", "b96f86eb-f24c-4f42-8b5c-5ab33f2954b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edb3562c-12fd-4212-8bf5-4a86da8f3b08", "AQAAAAEAACcQAAAAELOB4tpZXgJUWwXKCE34oo/CMexj+Be061I49YdmBbalDKTCOQJ397xtmQc9b095yA==", "66d30de9-05de-4573-993b-e21d3638e064" });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LobbyId",
                table: "Teams",
                column: "LobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_LobbyId",
                table: "Players",
                column: "LobbyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Lobbies_LobbyId",
                table: "Players",
                column: "LobbyId",
                principalTable: "Lobbies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Lobbies_LobbyId",
                table: "Teams",
                column: "LobbyId",
                principalTable: "Lobbies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Lobbies_LobbyId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Lobbies_LobbyId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Lobbies");

            migrationBuilder.DropIndex(
                name: "IX_Teams_LobbyId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Players_LobbyId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "LobbyId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "LobbyId",
                table: "Players");

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
        }
    }
}
