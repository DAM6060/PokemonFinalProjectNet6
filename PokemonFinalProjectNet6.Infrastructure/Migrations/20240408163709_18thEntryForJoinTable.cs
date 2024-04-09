using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _18thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6329ce2e-4469-4bc7-a695-1123b8c2bf4b", "AQAAAAEAACcQAAAAEFTvxvADToDlgqKaoaugUmzLJvmBTA1kHDEXtpCXqqKzX0/R4GNLgFynNfPTNemfXw==", "9251f554-d31b-44e1-8386-ea239e86ddd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f49efbec-0d67-4031-9fe0-f7361db6d332", "AQAAAAEAACcQAAAAEKuZPAtEE39wwtsas24PaSQVCHg7MCK5oCE5Nh5n7elyrfr8ov+QIZDwECf7Et45Sw==", "13fd5bba-24e8-4413-8453-5c01e73d2b54" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 3, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 3, 6 });

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
        }
    }
}
