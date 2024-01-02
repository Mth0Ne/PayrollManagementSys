using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "bf3a8295-280e-4b1e-97cf-496cbc97d202", "AQAAAAIAAYagAAAAELbp3HQ13eaYgUv4/fg0ZVCkM4TKeI6n8wkjkBbAsNaQHWlJRe57qTdk9vdJbEB0RA==", "6c0ee12f-e163-401d-84e8-46cf2d7abbaa", new DateTime(2023, 12, 24, 18, 34, 25, 345, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "10941699-4f7f-4661-b611-43e1b338a68d", "AQAAAAIAAYagAAAAEDAtq1g0KERth5bemqmU6rvJA+XSRfsdR97UA4sjHhGuAaFNxIk0IcE6OAyak1PUPw==", "7aef2b22-7b07-4c3c-8f76-0a56de65f324", new DateTime(2023, 12, 24, 18, 34, 25, 389, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "dd93fbbc-d82e-4cf8-8437-f14ada9745fe", "AQAAAAIAAYagAAAAEGMdLASh5Ys4MoMH9EyoznLcmybPgw1ppkpRiVwS6Uttj3zXuWqCopdVBVzw/XSbCw==", "aeea519e-113c-4ad0-8137-2774b3db410f", new DateTime(2023, 12, 24, 16, 39, 21, 105, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "77f1d526-3ecf-48c6-9bc3-3550d53398c3", "AQAAAAIAAYagAAAAEGn/xCHX5b4vJx91h6GRkf9Jhp3ybXooLyo43Sf5hWVScJAv+Gc1S3LHbOgp5Dijnw==", "348dd89b-9032-44ce-8a02-400a8a27a28d", new DateTime(2023, 12, 24, 16, 39, 21, 198, DateTimeKind.Local).AddTicks(4493) });
        }
    }
}
