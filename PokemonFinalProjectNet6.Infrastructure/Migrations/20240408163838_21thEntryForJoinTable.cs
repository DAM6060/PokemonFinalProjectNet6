using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _21thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c12c489-c739-4d8c-9150-bbe6f346c580", "AQAAAAEAACcQAAAAEIAdzl//ILztGBVNco1cffO4ciDvXMN3FgZZs3MCjSo+00UsM3XjXB/ZTNg6PbhnkA==", "f905bf19-8990-475a-863b-985eb537ff27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd7fce0-8a06-401f-8759-8b3f4ec9ef20", "AQAAAAEAACcQAAAAEOpBRC9nLz2zfhETDt5ZN2GK9ZwbfGWd82zbiWjAS+JFTxpjQr7zy9VvrJVXG4dlow==", "68995fbd-010f-4038-91a7-2c9f7bcd06b1" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 1, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13037ee1-3bfc-4c75-b5bd-2078b667fe86", "AQAAAAEAACcQAAAAEO1Old5XfaFvsRIsHMltXnMojqLwFiyHqr4csTZU5gVnERfuw4YyTpvJReWkYPVfLw==", "84eaa2f7-1fcf-4a61-a1ba-de0fd7029f9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50e3f4b7-40cc-4ead-b03d-911f31e1eef6", "AQAAAAEAACcQAAAAEHz8CzDEN5REU+hikoVe5Al6sNr2VbQcYhnBeLUdIW/6RJY9k1dy/nzPQinqdhkwvA==", "01bb96b2-9131-44ec-9871-4eb1083c784a" });
        }
    }
}
