using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Infrastructure.Migrations
{
    public partial class NameViolationFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isApproved",
                table: "Reviews",
                newName: "IsApproved");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb414eae-84f9-44ef-9b91-7e1dfe3b367a", "AQAAAAEAACcQAAAAEKm+KL3bpYVLZ/O+BQyBPReD4jyQZcY59ClNBzfMBxYVkyL/K+R9nHcpra49H52SQQ==", "0aca7246-3d34-4002-904d-6fd0ea66b819" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsApproved",
                table: "Reviews",
                newName: "isApproved");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3db85caf-ab1f-44e4-8f03-b2bda9d6f573", "AQAAAAEAACcQAAAAELGhN9R8KqFjp1LfMpIq476Egur/mHrYqYwq5GgdKYA44D1mnaV1mawzvrrDIL3mFQ==", "c0b24d2f-3736-4122-93c6-84a70e0861ce" });
        }
    }
}
