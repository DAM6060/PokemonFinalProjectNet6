using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _143thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 8, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f68994a-b877-48d5-b8fe-0ad2b9546de1", "AQAAAAEAACcQAAAAEILop1UF9dFPuPRgD+a6i+YFzgohcg0XiLUyETNoctl08Y0MnGcQZgvPWf6h+zkqWQ==", "92b679fb-ad43-4365-9c5b-bd108382b0f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29d023f0-7d7e-41d0-8394-5f60f3ec679d", "AQAAAAEAACcQAAAAEHxRROywiM5qJ07bu0Smlb4lTsoKEYO8B6P39gP/ELr7GMjhwwEhyxsLN3/PqPSlDg==", "fd378b3e-644b-4d06-af3c-c0731e955f1a" });
        }
    }
}
