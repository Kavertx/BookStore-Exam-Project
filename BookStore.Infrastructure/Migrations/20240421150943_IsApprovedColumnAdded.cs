using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Infrastructure.Migrations
{
    public partial class IsApprovedColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeOfReview",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "isApproved",
                table: "Reviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3db85caf-ab1f-44e4-8f03-b2bda9d6f573", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAELGhN9R8KqFjp1LfMpIq476Egur/mHrYqYwq5GgdKYA44D1mnaV1mawzvrrDIL3mFQ==", "c0b24d2f-3736-4122-93c6-84a70e0861ce", "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeOfReview",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "isApproved",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f9d7a8ed-2513-414a-9b16-aefd735cc53a", "ADMINISTRATORA", "AQAAAAEAACcQAAAAEMI3mkiGRJ6HTam5rO/X7AwJ5P4WC7lL4kIgxft8q4BHi/7Ax+0zEe7D5FvI8Z6OoQ==", "50b1f5e6-f749-4472-bfda-67c3f7fffa83", "AdministratorA" });
        }
    }
}
