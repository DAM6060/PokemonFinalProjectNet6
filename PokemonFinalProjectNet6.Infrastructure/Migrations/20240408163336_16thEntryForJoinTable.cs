using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _16thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 7, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b79aabb-759a-4d83-89ef-90766c9e6d74", "AQAAAAEAACcQAAAAEK2TtWyp2OLVnCIJWaAYa2lSalinGwWTIOGhDa3rqJ4pk2uWIl5fz0vnhlYr7Tq4aw==", "cc081952-b76b-4796-8de3-bb41cec285b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "851ae11e-a31b-4ccf-a8a1-ced9c41f4d9a", "AQAAAAEAACcQAAAAEIZeyUAmwQnIEVCAi0bRBH8f9AuClMEuAUUrNu0TAtNSlQWIX+VR/hegfauaoafJjg==", "4898a7f4-61ac-43e3-99b0-1f5d7f8ad019" });
        }
    }
}
