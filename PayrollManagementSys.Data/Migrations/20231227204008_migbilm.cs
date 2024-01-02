using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class migbilm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SalaryDate",
                table: "Salaries",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<double>(
                name: "AdditionalPayments",
                table: "Salaries",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "ebb9402e-1020-4c16-9911-56e5f5f2a011", "AQAAAAIAAYagAAAAEK5s2AHQQnZjcpJJkdOlQk+oGT+dz1Tqd3lzkfpKaL/QerCdgdkb+c3qDeL0FamCEQ==", "13b662a1-cd47-4c2a-89f9-b5e5eba107bb", new DateTime(2023, 12, 27, 23, 40, 8, 655, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "3ba42b6c-c1f5-4ca5-b61c-82cb537a43f6", "AQAAAAIAAYagAAAAEIIKIIQWeLUx+jNcV+1aX6HwVYNdl2ZXSLQa2bhNPFxcKvNik4YazDNkXSQGYT5NRg==", "391830d9-a0f8-4ad8-97d1-66e2e7321b69", new DateTime(2023, 12, 27, 23, 40, 8, 716, DateTimeKind.Local).AddTicks(2189) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SalaryDate",
                table: "Salaries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "AdditionalPayments",
                table: "Salaries",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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
        }
    }
}
