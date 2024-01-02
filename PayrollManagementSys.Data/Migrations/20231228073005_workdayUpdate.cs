using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class workdayUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkDate",
                table: "WorkDays",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "ce9e6765-bdcb-4f09-a839-aaedb40c494a", "AQAAAAIAAYagAAAAEAgSqxp3Byx30f7MHMj0V7KSJdZNzeZMf8QDVTGAn6P9RyGzkSGQynBxcN5dGf4efg==", "3a680de0-13f9-44ab-a502-d246fec1c11d", new DateTime(2023, 12, 28, 10, 30, 5, 29, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "d9f660df-483d-4511-9639-2a8c5685e029", "AQAAAAIAAYagAAAAENd6Hq5lKEZMyjZ63ixuSHTCmmwdm8s4KPb9ByQzXJ4iAfc+Jo6leJm8hW8DzjyBow==", "61ceecfa-7e94-4964-ae55-bfe8d60da893", new DateTime(2023, 12, 28, 10, 30, 5, 83, DateTimeKind.Local).AddTicks(8177) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkDate",
                table: "WorkDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
