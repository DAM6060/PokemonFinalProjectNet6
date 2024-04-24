using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class _24thEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30cb7b34-1cf8-4937-a872-5f44718f2b27", "AQAAAAEAACcQAAAAEJJ+5YRHStRLJwn4/W0yGinEoTTNuYkGPIuyY+Cyzjzs36nPrUbgB46EEU6chvabfQ==", "176219dd-fb6a-40cc-b914-f13896912e03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36efb85d-f145-4af8-9b9b-04496fa5e80d", "AQAAAAEAACcQAAAAEFnbT7tSd2MbSmg8S9nvJTPnX20hs+SWQeYYc27JgYiXmR7XQ9ZEVgA00HpJ3Io2CQ==", "bdfadb4a-ca3f-4b9b-ba64-2ae8300bb06a" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 9, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 9, 5 });

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
        }
    }
}
