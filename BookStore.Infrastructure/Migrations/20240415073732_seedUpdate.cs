using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Infrastructure.Migrations
{
    public partial class seedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6c84171c-22fe-4310-9caf-f69991817a76", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEN8ajpuLBkD4I20A+0otg/cg7Oq4Yie0Z5gtOC+2Js9EeA5BqAS6x4za9sh+IHEymg==", "0afad725-dfbd-4cf0-b220-c3f1ab2e00de", "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "980d786b-925b-43d0-aa46-b2d3ca860b6f", "ADMINISTRATORA", "AQAAAAEAACcQAAAAENNObIbOcpd7gAYpjB/HY4UYmVxP+cuORLf51SadPaCfylHqFwj6wPgJhri7yWiwAQ==", "1bd48d46-eab9-43ed-9b91-56cfc37d11f7", "AdministratorA" });
        }
    }
}
