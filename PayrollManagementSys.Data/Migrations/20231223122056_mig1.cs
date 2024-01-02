using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departmans",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 1, false, "Yeni Departman" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Addres", "BirtDate", "ConcurrencyStamp", "DepertmanId", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SGKNumara", "SecurityStamp", "StartedDate", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "Kayseri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "709b2751-1fef-42c4-bb85-1896008b2ff2", 1, "superadmin@gmail.com", true, "Super", "Erkek", false, "Admin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDz7Syvr5X+TOl1eB74NnYLu3DMRRagqgWdcn75fCMx8iTLcZhz/e/WeeDROu3Y0/Q==", "+905439999999", true, "123456", "78f8de58-b486-40ef-865c-c18429986db9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "superadmin@gmail.com" },
                    { 2, 0, "Kayseri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "91ab630c-d5fa-4ad3-a509-c2ea8f4329fb", 1, "admin@gmail.com", true, "Admin", "Erkek", false, "Test", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDawCJxSbcXG3U+aRvlZalYQkzMVAHBSHSGlxMRRqfbVHGX5c/hpIT/vdcIQPIm2JA==", "+905439999988", true, "123457", "84ae4f36-d260-4d51-bffe-fa2722aa3c58", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin@gmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departmans",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
