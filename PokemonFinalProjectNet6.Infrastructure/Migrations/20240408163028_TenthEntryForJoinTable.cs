using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class TenthEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6db18d7f-308c-498a-981e-bb52467c14d0", "AQAAAAEAACcQAAAAEBjA+DpmQashrBPktZh1UOU7xa2iCsdzGY3Cq4Ntto5vC5RhZBIlmUtoD+lhS3NCaw==", "dd34afc4-de49-4c86-8e4e-d2688e377f69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24ded63d-1f4e-4bc7-ab63-cf9b38aae32e", "AQAAAAEAACcQAAAAELI0+KQgSTBPH0InlcU0CkybITToEvWN/maugJo+/nQhGGBsSxmyxeR5EhaspnvR+g==", "fff6fa50-e802-446e-a823-2bf19668836e" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 15, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 15, 3 });

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
        }
    }
}
