using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Infrastructure.Migrations
{
    public partial class DbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeOfReview",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b57260e-22d6-4262-9320-50508e7762cc", "AQAAAAEAACcQAAAAEIWduEZjm2AUlszoDQl5nTJOl3D3Ef4bniLj1u8aS33LCg1rshEig9n7/CowJIH1WA==", "32279d48-014f-4c99-8327-6b9f01d4b0b0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeOfReview",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9d7a8ed-2513-414a-9b16-aefd735cc53a", "AQAAAAEAACcQAAAAEMI3mkiGRJ6HTam5rO/X7AwJ5P4WC7lL4kIgxft8q4BHi/7Ax+0zEe7D5FvI8Z6OoQ==", "50b1f5e6-f749-4472-bfda-67c3f7fffa83" });
        }
    }
}
