using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernamesNormalizeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0869adb5-4441-4e7c-959b-e521af835928",
                column: "ConcurrencyStamp",
                value: "5de5940a-fca1-42b5-a63d-409d6663f731");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2569adb5-4441-4e7c-959b-e521af835928",
                column: "ConcurrencyStamp",
                value: "d6504829-f15b-472d-b050-d2df9a052955");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-4441-4e7c-959b-e521af835928",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94636f79-80b2-4b09-a16b-c1d165563868", "ADMIN@LOCALHOST.COM.AR", "AQAAAAEAACcQAAAAEJg6L+L1XDPVDOPc3+R3UFvaQzpNykwmjPgHGIgAdAOC8ud6P41Do3RZcmd8eWVxGg==", "747313ef-1957-4bcd-b734-7bfdb3937bcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb38929a-75ed-45db-aed0-10d10eeb70e0",
                columns: new[] { "ConcurrencyStamp", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33ab0203-3f98-40e3-bc5e-95d5580a60e2", "User", "AQAAAAEAACcQAAAAEJ7jI+foTyXJ1CiJN55w8vXUVU6dLD+PdEI0TTmKTBux9en5CMptx4GEbn6t/jcNKA==", "ddbbe21b-ee45-4229-a6cc-0e6751a3b935" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0869adb5-4441-4e7c-959b-e521af835928",
                column: "ConcurrencyStamp",
                value: "8bbbd58f-8648-499b-b010-e4b7df009a9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2569adb5-4441-4e7c-959b-e521af835928",
                column: "ConcurrencyStamp",
                value: "24c9b3e5-6b33-4ce1-9f39-08b1ebaff422");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-4441-4e7c-959b-e521af835928",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "529660a7-7e18-4fa8-a624-311dd34d60dc", "admin@localhost.com.ar", "AQAAAAEAACcQAAAAEMAsVFR+RzhVidmc0A+Enub9IxSaycM8dmXkIX1uC3UxTV4CIOuDYfY4FxMgen5q6w==", "34ff2c7d-5eb7-4d5b-9f2d-040a8f2f5117" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb38929a-75ed-45db-aed0-10d10eeb70e0",
                columns: new[] { "ConcurrencyStamp", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef6c3280-dc64-4230-8c03-b18e7e3029b8", "user", "AQAAAAEAACcQAAAAEGCm8GGUJKWQcZd+0kjKGhpR64RzUbxWobNC+QCwArohXttZmiSy5Nhtt1M9yhccxA==", "711a2589-f3f8-45fa-a169-c1182a30b21f" });
        }
    }
}
