using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class ForthEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 19, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "697e5a98-f701-4b7b-9117-93bf1ca06bf6", "AQAAAAEAACcQAAAAEO/7lgCaWszxhemKQl9haOjSMym9PL8Lb1qGn2Sig0PHF2yvURTgjPylKOMvRVj/kg==", "c4faa23b-9740-4d0f-ac4c-2c691f9c052a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "422c7f44-973f-4b7b-b27d-25c35ac4711c", "AQAAAAEAACcQAAAAEJY7v+7AbNreEGKJRIlEY7IOuDfQ0mgOLfaTOjw4Q0cGYktlX6pALWDv5sBDZUXt2A==", "3d60944f-0ef4-4a9e-b217-8a2f725f6000" });
        }
    }
}
