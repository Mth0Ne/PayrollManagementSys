using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class viewAvarageDepartmanSalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "fb3c77c7-e47c-46b8-afaf-f5439d82f2ad", "AQAAAAIAAYagAAAAEHl62SEoH1aLKzOPKLYFibodUSorrHprVQfMxhAun5MTUF/sB3T7YMwjT8OlvZkh9A==", "83056363-39bd-4276-b21c-f06596126f93", new DateTime(2024, 1, 1, 11, 30, 9, 856, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "26296413-6702-4c58-9a4d-ae548ae6cf1b", "AQAAAAIAAYagAAAAEKG4Seg1iiw8O7xkXmUHdDbDRC2NaWlORV0TABI9dSOQgOj1vXyxGn+TA+bCq92vIA==", "23f9f6dc-539c-4f3a-852c-500a2f1f978d", new DateTime(2024, 1, 1, 11, 30, 9, 948, DateTimeKind.Local).AddTicks(6047) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
