using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _20thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13037ee1-3bfc-4c75-b5bd-2078b667fe86", "AQAAAAEAACcQAAAAEO1Old5XfaFvsRIsHMltXnMojqLwFiyHqr4csTZU5gVnERfuw4YyTpvJReWkYPVfLw==", "84eaa2f7-1fcf-4a61-a1ba-de0fd7029f9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50e3f4b7-40cc-4ead-b03d-911f31e1eef6", "AQAAAAEAACcQAAAAEHz8CzDEN5REU+hikoVe5Al6sNr2VbQcYhnBeLUdIW/6RJY9k1dy/nzPQinqdhkwvA==", "01bb96b2-9131-44ec-9871-4eb1083c784a" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 4, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e88e54c2-49a8-4383-98ed-0677067afabf", "AQAAAAEAACcQAAAAEPq4n3argDTB2u/y0mnnwDERcf9BwghsSVCu2cTrGYqmWYSDKjcpNV2ls0ogs7n1pg==", "81844fe6-ef7c-44b6-9364-0207f0feade4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ef0178a-a950-4289-889e-7dd9d6443e75", "AQAAAAEAACcQAAAAEPfcBwdgaX3vWTewGjO8h/uA8HaasHA6Qc+vcv9GBaZ+HEPwaNv6S86ilRmMZobz0g==", "8c252bb2-7edc-46d0-aabd-733fd1816a24" });
        }
    }
}
