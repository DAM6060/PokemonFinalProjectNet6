using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _22thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "557ccecf-a35b-4f71-a2bc-eb485141df31", "AQAAAAEAACcQAAAAEDt9JOAm0z4PQCVvK0fANcCLWxcqWsMFkFaSIKVG7wTuIuH9uZkZ3ki70Gmp55mxSg==", "a85636ed-9362-44d4-a759-ed68e99b123f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97fa962c-7aba-4fdc-84bd-e09ba446fe0d", "AQAAAAEAACcQAAAAEDs2DhUaP6EIOj5GKLTKdrv3YTLQkbjpwcROAWfWsKioOeHqe37P8leFt/ymL4UKzw==", "8142b641-58b6-44b5-b061-8cc5b2fed02d" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 10, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 10, 5 });

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
        }
    }
}
