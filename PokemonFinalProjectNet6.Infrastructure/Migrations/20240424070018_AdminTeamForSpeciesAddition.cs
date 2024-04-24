using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class AdminTeamForSpeciesAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56023159-dfb2-4966-8fe3-1af9305576d0", "AQAAAAEAACcQAAAAEFknJqlU6g1DCTzr1q0oRMl26A2GHBcdr9FQ5Das4pnFTL+QyOrJEua9TVwwJD/3zA==", "8fe6689c-428b-4948-b8e5-462a8b17aca4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bd53178-7b0e-43ab-bd07-2532d3619d41", "AQAAAAEAACcQAAAAEPlIrsbUFFrMGWustPyuXWc7SqL60hjXAMTPNbFehUm6IJKThKcjUpV/h12SWJHLOA==", "7ebc0cd4-e912-4789-b99d-776e28f50994" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "099b2576-ee7c-43aa-b6d0-e7d03de39334", "AQAAAAEAACcQAAAAEEHfOtcCRJA4bym13sShBRtM3vsPE8xI65drnjBQEwP6bBWelkFbIWG/n0060vPhJA==", "61dcdb30-032a-42a7-ac3d-328ac1238b7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a077049-3e81-4e5c-a3ae-fc6869c3db0f", "AQAAAAEAACcQAAAAEMxU0B1bRXdmE1fFpX0Te4E4q/W4vS75WTXaxA0o3z+OZYNlRS6zXeyZEPSgGudYdQ==", "3aacd95b-9d92-4899-bee8-4d327442cd78" });
        }
    }
}
