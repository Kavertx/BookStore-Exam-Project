using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Infrastructure.Migrations
{
    public partial class AddedColumnNumberOfBooksToTableOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfBooks",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88995dfd-de1c-45cf-8341-608683ea57fa", "AQAAAAEAACcQAAAAELPEL89gm+Lfga65qd1aMY1vhEYNvuTB1kT8uGyoTZXw+FKocYbRmb8ms7h6pP1xAA==", "d8d2418f-02fa-4ef6-8cd5-765ce230f8e0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfBooks",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dd94c29-06b5-4a54-bf5a-dd080d77c1a7", "AQAAAAEAACcQAAAAEOjDRaHmrxuz1cZLAl8Q5IqOJvBzzdcBFEV+H1HGgzX71McTKZyjxZxVPv3Oohaaaw==", "82148e35-5e5b-4939-ab3c-b8a0660a5d1e" });
        }
    }
}
