using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class migralpereennn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "52a88e96-f1cb-4d31-9dcf-075d08865c7f", "AQAAAAIAAYagAAAAEL96TL9zpuP0Cy3yzoLrd46VDeF4aZBVUePmQ5WcCLxMmPM/5fj9Kui3BkLJaNTv6w==", "572d9f23-afb5-4d02-a748-bfa87fd4c15f", new DateTime(2024, 1, 2, 23, 7, 0, 744, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "f5af0c81-6e5c-4c6f-b493-ee9ae5cd4ea7", "AQAAAAIAAYagAAAAEGClYhETzDw3YbrkUAWPUHirKkNQ56eNlLomkd2yoeOm3W4Gx7aQVxpp2MGhETmCRg==", "0511f39b-7ac1-405a-8f84-3b1503815576", new DateTime(2024, 1, 2, 23, 7, 0, 787, DateTimeKind.Local).AddTicks(5901) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
