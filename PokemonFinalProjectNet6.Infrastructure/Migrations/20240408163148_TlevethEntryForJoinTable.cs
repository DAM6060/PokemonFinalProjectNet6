using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class TlevethEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 16, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 16, 3 });

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
        }
    }
}
