using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class NinthEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94632b94-4dea-42b8-9b77-dfcc00e5f8e5", "AQAAAAEAACcQAAAAEDDWGZUSfw1vkmuQnS28+4gIiU8ZnjDfKHhFxSRF2HYQKT7LXo5CvZJLcv3YHoWPIg==", "a47aecdb-e21c-4cc7-89dd-1f767827391f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12595d2e-29e8-4a05-88fb-1ea2293d4621", "AQAAAAEAACcQAAAAEDYKjNLz/rt4WxHx6P/6yHxAuUh2UOD87uWd7/UvPRTZMWcaVgyYZaX4TYJsGnCLhg==", "a3434c40-d3a3-40ea-926f-26c8f47e40bf" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 9, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18010a04-74f7-42b0-ac80-bb9d89174b31", "AQAAAAEAACcQAAAAEH1NORiU6qaMFQAwDahxXIPMIqfaF6Tf/IMbiNeserjY1r+VjUDeF6zOEUyYm6MmYw==", "ee6b52e3-411d-4a7f-a49a-3722c23368ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9a806c0-00f7-4c67-bebf-fe649de39c63", "AQAAAAEAACcQAAAAEOJuzUZ/uSJ1norMLQlSNLwBQ/DtM6t3JlP04BwTt12UHvWJOFnb+7/R4Uy5ZdA3WQ==", "d26c34af-b134-42cf-a88a-9a50fa7754de" });
        }
    }
}
