using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class ChangedUserSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "099b2576-ee7c-43aa-b6d0-e7d03de39334", "DIMITARPLAYER@PLAYER.COM", "AQAAAAEAACcQAAAAEEHfOtcCRJA4bym13sShBRtM3vsPE8xI65drnjBQEwP6bBWelkFbIWG/n0060vPhJA==", "61dcdb30-032a-42a7-ac3d-328ac1238b7d", "DimitarPlayer@player.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4a077049-3e81-4e5c-a3ae-fc6869c3db0f", "DIMITARADMIN@ADMIN.COm", "AQAAAAEAACcQAAAAEMxU0B1bRXdmE1fFpX0Te4E4q/W4vS75WTXaxA0o3z+OZYNlRS6zXeyZEPSgGudYdQ==", "3aacd95b-9d92-4899-bee8-4d327442cd78", "DimitarAdmin@admin.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5c38e555-eb7d-481c-b9b4-4ed6e82e1589", "DIMITARPLAYER", "AQAAAAEAACcQAAAAEP05HDI5VsCW/cjG0cFskpsHH1VRwyScGJenBmYVuxHKArye+7bEVSE3DALAPvtKtw==", "095eaf36-6fb4-43f9-a19e-814cea363748", "DimitarPlayer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8c0cbd54-422b-4d71-a023-e8ccb2690691", "DIMITARADMIN", "AQAAAAEAACcQAAAAEIYMBl88QmO3xvdsq0GtPxvGrVcCo34LbddYnKVNojJf9t8X399f4KwKWkKNJiHpWw==", "067b4b2f-b2aa-4b74-9b25-c510eda1c529", "DimitarAdmin" });
        }
    }
}
