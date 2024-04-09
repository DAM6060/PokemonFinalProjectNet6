using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class SecondEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9766cc2-8eb6-45d3-960a-efd75dae63f6", "AQAAAAEAACcQAAAAECeLs1/N1uIsGc23ou9wzYMlHxmBvokjMITyIJfZczkHW5oOmjf4ELtTmQxm2Wcwiw==", "191ada74-174a-4235-b352-2ecba7f0b557" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4c0f985-bb30-4755-a58a-12fe602ca8d5", "AQAAAAEAACcQAAAAEPqfIo7m5Dj2YP2GXJfSk7rsyMtkSpylNU0mdtCa2BEGADf/0M1oDSeAAu8qdZtjDA==", "3558ab9a-39a2-423c-a6d0-c26c16903229" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 3, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14aee737-77cd-4478-a40e-7b80cdac1fec", "AQAAAAEAACcQAAAAEObw9meZRIgSplHg0/3oDkH+evctWQMLaUnH38UP+iu3FwNACU2Nsf5MSxQ/7XG72Q==", "31eb3ce5-e34f-442d-9fe9-e7cfbaa65c51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02abfeea-8af2-46e8-bdec-5765940914a1", "AQAAAAEAACcQAAAAEJghguxhwiCpABo9Q4Qmo1XWN7/0GiZwPXnEPPiw1tru8xLfDQ67DoeTvsBX3xPoBA==", "565bb98c-b39e-47f9-b96b-d405d729ed47" });
        }
    }
}
