using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _19thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 21, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 21, 6 });

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
        }
    }
}
