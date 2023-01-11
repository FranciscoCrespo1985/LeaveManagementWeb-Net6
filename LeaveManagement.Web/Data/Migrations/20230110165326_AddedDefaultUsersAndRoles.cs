using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0869adb5-4441-4e7c-959b-e521af835928", "7d2cefd3-c1d1-4378-b15b-7c1404a9019e", "Administrator", "ADMINISTRATOR" },
                    { "2569adb5-4441-4e7c-959b-e521af835928", "d679839e-435a-4673-8397-f5cdc9506f31", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "408aa945-4441-4e7c-959b-e521af835928", 0, "0f2f115e-56f3-47d2-b8f3-8269415045a3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com.ar", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM.AR", null, "AQAAAAEAACcQAAAAEJfc1Zq7AWxupkJ+AO3F4k6DHmlI36XAf/iSw4fojVm45z/wczPqJL8x62fWalrz2w==", null, false, "a77dbb44-4c75-492a-92ce-7b48a8bd6b64", null, false, null },
                    { "bb38929a-75ed-45db-aed0-10d10eeb70e0", 0, "6a10a326-9a8d-4791-be0c-c006b8abb832", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com.ar", false, "System", "user", false, null, "USER@LOCALHOST.COM.AR", null, "AQAAAAEAACcQAAAAEEGS0PZTb3wLKk+t/XE2NeXK2Q5BP+1euJoSJom43cqDn/wgedSyKD9zVBAPctv4Ww==", null, false, "63e78dc9-38cd-4fe9-8a5f-53b79094c089", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0869adb5-4441-4e7c-959b-e521af835928", "408aa945-4441-4e7c-959b-e521af835928" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2569adb5-4441-4e7c-959b-e521af835928", "bb38929a-75ed-45db-aed0-10d10eeb70e0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0869adb5-4441-4e7c-959b-e521af835928", "408aa945-4441-4e7c-959b-e521af835928" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2569adb5-4441-4e7c-959b-e521af835928", "bb38929a-75ed-45db-aed0-10d10eeb70e0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0869adb5-4441-4e7c-959b-e521af835928");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2569adb5-4441-4e7c-959b-e521af835928");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-4441-4e7c-959b-e521af835928");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb38929a-75ed-45db-aed0-10d10eeb70e0");
        }
    }
}
