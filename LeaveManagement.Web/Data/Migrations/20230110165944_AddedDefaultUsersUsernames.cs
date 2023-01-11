using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8d3fb2ea-117c-4b36-847f-95d883a64e07", true, "AQAAAAEAACcQAAAAEGWhi1sxpaOdKz1szgDLSeRPe/Qc1uEmXQd4YV+FjBShV5uZz9A5MPFoRyMijkzEfA==", "948ba6d8-a7bc-4b05-91ab-1b5234f93519", "admin@localhost.com.ar" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb38929a-75ed-45db-aed0-10d10eeb70e0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "eb15fbc3-1872-411f-a8a0-cd1754d97a9e", true, "AQAAAAEAACcQAAAAEPDM52znVKq8WZSPBrOktJiwteq9rtMPE2Rg4gr73c8uO6/l0ThnBErviDk3QOMhoA==", "b2b4a7ff-3dcb-4d57-a7d8-40f1f50765b5", "user@localhost.com.ar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0869adb5-4441-4e7c-959b-e521af835928",
                column: "ConcurrencyStamp",
                value: "7d2cefd3-c1d1-4378-b15b-7c1404a9019e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2569adb5-4441-4e7c-959b-e521af835928",
                column: "ConcurrencyStamp",
                value: "d679839e-435a-4673-8397-f5cdc9506f31");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-4441-4e7c-959b-e521af835928",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0f2f115e-56f3-47d2-b8f3-8269415045a3", false, "AQAAAAEAACcQAAAAEJfc1Zq7AWxupkJ+AO3F4k6DHmlI36XAf/iSw4fojVm45z/wczPqJL8x62fWalrz2w==", "a77dbb44-4c75-492a-92ce-7b48a8bd6b64", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb38929a-75ed-45db-aed0-10d10eeb70e0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6a10a326-9a8d-4791-be0c-c006b8abb832", false, "AQAAAAEAACcQAAAAEEGS0PZTb3wLKk+t/XE2NeXK2Q5BP+1euJoSJom43cqDn/wgedSyKD9zVBAPctv4Ww==", "63e78dc9-38cd-4fe9-8a5f-53b79094c089", null });
        }
    }
}
