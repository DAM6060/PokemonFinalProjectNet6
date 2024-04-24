using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class FifthEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59c042ab-10ec-4232-b6d4-a590ec8fbae5", "AQAAAAEAACcQAAAAEBz3VHjx9tohQMKO7e3vdPg+ia7PP+lyYL2XocofqvhWgSvDj2zEJBAxvPcHMFDruQ==", "221dd350-1e4f-4567-aa98-debd1f010fd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abe13025-303c-48a7-abca-7c66a82df939", "AQAAAAEAACcQAAAAEHyexo0DO4r/Wuzty9PqpnHdJUzEmqvwQblKYpIS+YdCqP1H+n/bO7iBBns902/Fyg==", "bbf3f927-4027-43ba-b49d-2cc599c71dc5" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 17, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5ce614b-3311-4b35-b077-5c645a8a7ca0", "AQAAAAEAACcQAAAAELOArdXspSMivv3t8pEHdYGcvZKdNSzIWDd/hNFZ3Ejwf+LCp8PTmIR8bNCwNpsokw==", "84c2e3f7-bb60-40c9-9961-39b09fc6c1a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "288c855f-7501-4146-9ecd-6b0f59349ed9", "AQAAAAEAACcQAAAAEHHBYOinuhbQJpCJ++1Q4COoHJX7kGTxViOHs8t9R7HVpZbSYWCVN8WrNNW3KR4MCg==", "75f574e9-c126-4ab2-b26b-c238739f1fa7" });
        }
    }
}
