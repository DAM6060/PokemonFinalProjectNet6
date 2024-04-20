using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonFinalProjectNet6.Infrastructure.Migrations
{
    public partial class ChangedTeamToNotRequrirePokemonForEasierTeamCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c38e555-eb7d-481c-b9b4-4ed6e82e1589", "AQAAAAEAACcQAAAAEP05HDI5VsCW/cjG0cFskpsHH1VRwyScGJenBmYVuxHKArye+7bEVSE3DALAPvtKtw==", "095eaf36-6fb4-43f9-a19e-814cea363748" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c0cbd54-422b-4d71-a023-e8ccb2690691", "AQAAAAEAACcQAAAAEIYMBl88QmO3xvdsq0GtPxvGrVcCo34LbddYnKVNojJf9t8X399f4KwKWkKNJiHpWw==", "067b4b2f-b2aa-4b74-9b25-c510eda1c529" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6655937-acc7-4692-940a-dc7c1488897e", "AQAAAAEAACcQAAAAEGYSrdDxb4s+flj1NtaKgviAO+lJqt90zLAeOzFiwJHp5Ph2FLWwa+OGp81BoCkuOA==", "b96f86eb-f24c-4f42-8b5c-5ab33f2954b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edb3562c-12fd-4212-8bf5-4a86da8f3b08", "AQAAAAEAACcQAAAAELOB4tpZXgJUWwXKCE34oo/CMexj+Be061I49YdmBbalDKTCOQJ397xtmQc9b095yA==", "66d30de9-05de-4573-993b-e21d3638e064" });
        }
    }
}
