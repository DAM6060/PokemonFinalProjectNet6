using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class OneEntryInJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14aee737-77cd-4478-a40e-7b80cdac1fec", "AQAAAAEAACcQAAAAEObw9meZRIgSplHg0/3oDkH+evctWQMLaUnH38UP+iu3FwNACU2Nsf5MSxQ/7XG72Q==", "31eb3ce5-e34f-442d-9fe9-e7cfbaa65c51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02abfeea-8af2-46e8-bdec-5765940914a1", "AQAAAAEAACcQAAAAEJghguxhwiCpABo9Q4Qmo1XWN7/0GiZwPXnEPPiw1tru8xLfDQ67DoeTvsBX3xPoBA==", "565bb98c-b39e-47f9-b96b-d405d729ed47" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 13, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92d1848f-ca54-4635-b61d-60f96685249e", "AQAAAAEAACcQAAAAEO80XgJ21fcYMCu+BChaixNSEuNk9W3u/QXC/iB8oFyvkNFhGbNrfiqIkmTu/AgM3w==", "7ab8c50c-00b7-4598-9f19-1192abb12ab4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d62f1464-2538-4eb8-80da-5bf9cbe4ec18", "AQAAAAEAACcQAAAAEM04rRuaLQ8kig4qawmbwnlOId+niqEZrrdV+6NULv0Jfj25GGjwgVRSD7s3ERtWVA==", "0ab01ac0-c8b3-41cd-9256-0c9fb5f3439f" });
        }
    }
}
