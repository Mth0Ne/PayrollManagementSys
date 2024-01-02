using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class worksalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "ef7b4572-8841-4fe1-8b79-ca4a4d726991", "AQAAAAIAAYagAAAAEGcKo5YxoLXww0Y+1IN5YNRTfnpDKcaGH4omnEtC5YJT9EVTsqAk2dWD/hZMxbOoAA==", "74b4b31a-e3a6-41b8-abca-59e0b0742693", new DateTime(2023, 12, 30, 13, 2, 39, 801, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "5afaabd7-8ed7-4a56-897f-b742bf3991b8", "AQAAAAIAAYagAAAAEPNUxdZoxC5jN+LCtAngJDjtd4+IOMT9Yxbe1tLGU0PhJi6OsJdGTM4XreyTvwT5Hw==", "d5b1af81-af22-4d7a-a578-72f1b2be8baf", new DateTime(2023, 12, 30, 13, 2, 39, 930, DateTimeKind.Local).AddTicks(9447) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "9ac0a50e-21a6-47e5-8daf-ab81c3e9135d", "AQAAAAIAAYagAAAAEH06MPUKbMhyptNc3VUJx8AXLoX0Zjek5lzLcIYwPPmvkYAyteOYdYDE9bifG73GvA==", "94baf96e-8dc6-4aa1-bd7d-293187b1b536", new DateTime(2023, 12, 30, 10, 2, 12, 847, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "d2776fc2-2051-4847-b229-9b5ac0aa80e7", "AQAAAAIAAYagAAAAEBoN3wz3lGd44nneg2Dt7w9xqPp8ENblwxywW+juD0okyKLf9ogP+6adfG3Kkg1k5g==", "701325ea-382a-4fe9-a4c8-34a7e645a183", new DateTime(2023, 12, 30, 10, 2, 12, 973, DateTimeKind.Local).AddTicks(2023) });
        }
    }
}
