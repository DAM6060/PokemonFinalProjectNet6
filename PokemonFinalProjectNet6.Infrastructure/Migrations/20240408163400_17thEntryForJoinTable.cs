using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _17thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf438bff-3195-43b0-849a-38fe18924df1", "AQAAAAEAACcQAAAAEJZgYxfblhkVkEfbVG5gbebyzgvKWcgbP9XqS/tdADM/2+wepMtlaIL9lny5CsA76w==", "5b9da06c-f413-45fa-a351-36c885c3ae16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0a69f91-d3c7-40de-a363-c021e89e426c", "AQAAAAEAACcQAAAAEHQy1DnLDr+X/aCOkSyMIsiJWZumIlrgBxHIlBxfoTXXEwWMbt8wAXBQ64DJZkdfzA==", "cec7041a-3ee8-400c-ae95-b9c14674293b" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 20, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82a87776-6e46-40c9-ba01-2a77ad09fed4", "AQAAAAEAACcQAAAAEFGt5DIFuBMed6FD420BSmCTgUNsoMF4kIOo+LKpSCyu913xLvtiGCK1rPph2m33cA==", "8d5d9ab4-5229-4f38-9004-64bbbbd10383" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a53f0894-95fa-426b-b5f1-f50ae77d23ec", "AQAAAAEAACcQAAAAEIRxzJqwJNielmNDCF3z9n7fdNAZOaa1mmhfkuQks/1kPcAaqOOb88Qx+rJF2dGy9g==", "ae1fcf11-d65e-4c8d-bfb5-c20dae59b6be" });
        }
    }
}
