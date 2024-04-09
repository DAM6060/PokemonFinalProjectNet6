using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _15thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 12, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e7e8e47-e376-41ee-9019-6c7ee95b3729", "AQAAAAEAACcQAAAAEB2OUVTIqMof/ouvQH7NBcqPbaflxsL09p+Dc7OJgzhZFpbeoylXYjR2AkPfgg+mWg==", "58a6dbe6-dec6-40c1-8875-fa92379f2ee6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15dfa617-16ff-4c67-93ad-c42432b7338f", "AQAAAAEAACcQAAAAEPWUXNEMLFUTo80U/dXvTHQfhUfSbW+T2AGGo1sF/bPf6NvL5XujOOb2+tK22YX/4g==", "da26df6b-965e-470a-a773-8edff2a9bd2a" });
        }
    }
}
