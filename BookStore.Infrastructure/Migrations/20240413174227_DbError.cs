using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Infrastructure.Migrations
{
    public partial class DbError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "980d786b-925b-43d0-aa46-b2d3ca860b6f", "AQAAAAEAACcQAAAAENNObIbOcpd7gAYpjB/HY4UYmVxP+cuORLf51SadPaCfylHqFwj6wPgJhri7yWiwAQ==", "1bd48d46-eab9-43ed-9b91-56cfc37d11f7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b57260e-22d6-4262-9320-50508e7762cc", "AQAAAAEAACcQAAAAEIWduEZjm2AUlszoDQl5nTJOl3D3Ef4bniLj1u8aS33LCg1rshEig9n7/CowJIH1WA==", "32279d48-014f-4c99-8327-6b9f01d4b0b0" });
        }
    }
}
