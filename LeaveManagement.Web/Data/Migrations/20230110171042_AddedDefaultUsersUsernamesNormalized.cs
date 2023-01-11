using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernamesNormalized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef6c3280-dc64-4230-8c03-b18e7e3029b8", "USER@LOCALHOST.COM.AR", "AQAAAAEAACcQAAAAEGCm8GGUJKWQcZd+0kjKGhpR64RzUbxWobNC+QCwArohXttZmiSy5Nhtt1M9yhccxA==", "711a2589-f3f8-45fa-a169-c1182a30b21f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0869adb5-4441-4e7c-959b-e521af835928",
                column: "ConcurrencyStamp",
                value: "8c29b5aa-8f80-44bd-a89a-a5b3fef64edf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2569adb5-4441-4e7c-959b-e521af835928",
                column: "ConcurrencyStamp",
                value: "62f7ca8f-224c-4294-8b41-961dd670ca78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-4441-4e7c-959b-e521af835928",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d3fb2ea-117c-4b36-847f-95d883a64e07", null, "AQAAAAEAACcQAAAAEGWhi1sxpaOdKz1szgDLSeRPe/Qc1uEmXQd4YV+FjBShV5uZz9A5MPFoRyMijkzEfA==", "948ba6d8-a7bc-4b05-91ab-1b5234f93519" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb38929a-75ed-45db-aed0-10d10eeb70e0",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb15fbc3-1872-411f-a8a0-cd1754d97a9e", null, "AQAAAAEAACcQAAAAEPDM52znVKq8WZSPBrOktJiwteq9rtMPE2Rg4gr73c8uO6/l0ThnBErviDk3QOMhoA==", "b2b4a7ff-3dcb-4d57-a7d8-40f1f50765b5" });
        }
    }
}
