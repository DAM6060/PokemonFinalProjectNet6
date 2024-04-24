using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class SudokosRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sudokos");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78394649-2eef-4730-91a6-5af840819de4", "AQAAAAEAACcQAAAAECctuq3cROcKuyZIv5DeCX/TZPiXSOuKfZe2vpQmnHR5WKzQBnpI5Ktyyp7ZG4OnKw==", "c447e361-004c-4ad9-aa38-3f1e1c79fbe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc4b0fed-e751-4968-8bd6-a6ef830ecb3f", "AQAAAAEAACcQAAAAECiXpByNfG+Q0r7063hvgIMn1tPsh/lzBS6mpnVJVB/X+HeMPM07awauiVoDgS8WZA==", "adf2b980-7f1d-45fe-9eb4-abad20e5afc1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sudokos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Column1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row1xColumn1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row1xColumn2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row1xColumn3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row2xColumn1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row2xColumn2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row2xColumn3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row3xColumn1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row3xColumn2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row3xColumn3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sudokos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70438373-a14e-46a5-8437-0f45d7a32b65", "AQAAAAEAACcQAAAAEG9wpEXf+qe/YPIuMi38kpabnEfJwYQqrpmLog6kUQnMIUSOP4mi5xyWwy3iAhvU+A==", "e99ee6d8-b9f8-4549-8f82-7e762b638806" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab19b9df-7c3c-4d87-8eb9-e2b34f77d46e", "AQAAAAEAACcQAAAAEK7tYqMQdIBN5T8fpd6jAuiRIx6LP6A7pw7TtZzgzQR3cEQBu+CkjgSJaUY+wjDfVw==", "9d1bb631-83a9-4844-b743-e20a2f7dde55" });
        }
    }
}
