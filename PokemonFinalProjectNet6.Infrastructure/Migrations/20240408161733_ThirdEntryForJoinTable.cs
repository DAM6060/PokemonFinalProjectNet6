using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class ThirdEntryForJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "697e5a98-f701-4b7b-9117-93bf1ca06bf6", "AQAAAAEAACcQAAAAEO/7lgCaWszxhemKQl9haOjSMym9PL8Lb1qGn2Sig0PHF2yvURTgjPylKOMvRVj/kg==", "c4faa23b-9740-4d0f-ac4c-2c691f9c052a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "422c7f44-973f-4b7b-b27d-25c35ac4711c", "AQAAAAEAACcQAAAAEJY7v+7AbNreEGKJRIlEY7IOuDfQ0mgOLfaTOjw4Q0cGYktlX6pALWDv5sBDZUXt2A==", "3d60944f-0ef4-4a9e-b217-8a2f725f6000" });

            migrationBuilder.InsertData(
                table: "PokemonsMoves",
                columns: new[] { "MoveId", "PokemonId" },
                values: new object[] { 4, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonsMoves",
                keyColumns: new[] { "MoveId", "PokemonId" },
                keyValues: new object[] { 4, 1 });

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
        }
    }
}
