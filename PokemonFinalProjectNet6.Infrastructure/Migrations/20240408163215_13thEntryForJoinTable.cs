using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _13thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 11, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aaf074e-0758-43e1-944a-9a2d90673533", "AQAAAAEAACcQAAAAELAkgxG2nPZgzdVIB5GH4I3kqlNcS+IvUUPXQltGz+ogIdZxYeAGjTsKtcjMgv9fPA==", "3f9e05de-2978-413e-b34c-8806cbb8b7e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc672ca1-4993-4034-a792-9f6cd0f9caef", "AQAAAAEAACcQAAAAECy84VgzaIDCaM6r8SH7Y3xXRRwbFzxyHhrY3qIeqs3wlkua1dGf8F30ZRQizKa+Hw==", "904c1f92-1214-4442-bbf2-9269d411dea5" });
        }
    }
}
