using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Infrastructure.Migrations
{
    public partial class ChangedBackToIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsernameCustom",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c394f8b-41d2-4cc5-aed5-78b09637472f", "AQAAAAEAACcQAAAAENEbLSQKkcML0OxZIbcS0xjBRqOdBy8OVNwSAtLUBSNG7rXUmiimE61C6PAEvPYftA==", "2db96655-0b3b-45d1-9dd5-27a42471cf7e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsernameCustom",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UsernameCustom" },
                values: new object[] { "17d7e58b-b410-498f-bdda-abb2916aad36", "AQAAAAEAACcQAAAAEHQuCkdpFL43dDsj5zM6TlvXdBGly6jGJK2GSx47rWEPOTm1TaGHvpUTG68zAA8ZSw==", "9cc43fbc-6f14-42c0-9709-23155ef1290b", "AdministratorA" });
        }
    }
}
