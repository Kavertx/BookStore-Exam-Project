using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Infrastructure.Migrations
{
    public partial class UpdatedUserConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3dd94c29-06b5-4a54-bf5a-dd080d77c1a7", "ADMINISTRATORA", "AQAAAAEAACcQAAAAEOjDRaHmrxuz1cZLAl8Q5IqOJvBzzdcBFEV+H1HGgzX71McTKZyjxZxVPv3Oohaaaw==", "82148e35-5e5b-4939-ab3c-b8a0660a5d1e", "AdministratorA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2c394f8b-41d2-4cc5-aed5-78b09637472f", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAENEbLSQKkcML0OxZIbcS0xjBRqOdBy8OVNwSAtLUBSNG7rXUmiimE61C6PAEvPYftA==", "2db96655-0b3b-45d1-9dd5-27a42471cf7e", "admin@mail.com" });
        }
    }
}
