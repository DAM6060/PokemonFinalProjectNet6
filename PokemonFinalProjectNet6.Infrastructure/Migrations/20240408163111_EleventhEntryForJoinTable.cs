using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class EleventhEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d5fd83f-8d9b-4fc0-afc8-4ff2a3fc6156", "AQAAAAEAACcQAAAAEM9UXltVr+lwXReyQhyxmxCz6NoR19ydn2XPWhYES7cd84eoTuKNHRfufzqNnHiu6A==", "b07b9e6a-7ccd-44a8-980d-5fbd7fc9a00c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfbada04-a079-469e-82b6-247137626952", "AQAAAAEAACcQAAAAEAgfPbi0Jw0p4FsU0YHHT2+IXmB56R6YY4gtrIY04secpnxehv0rvVTXmc003ReQjg==", "31b2c915-8a22-4c3a-b60f-15de69eb0d2c" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 14, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 14, 3 });

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
        }
    }
}
