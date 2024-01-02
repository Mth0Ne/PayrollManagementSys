using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "AdditionalPayments",
                table: "PaymentInfos",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "SalaryCoefficient",
                table: "PaymentInfos",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "SgkDeduction",
                table: "PaymentInfos",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TaxDeduction",
                table: "PaymentInfos",
                type: "real",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalPayments",
                table: "PaymentInfos");

            migrationBuilder.DropColumn(
                name: "SalaryCoefficient",
                table: "PaymentInfos");

            migrationBuilder.DropColumn(
                name: "SgkDeduction",
                table: "PaymentInfos");

            migrationBuilder.DropColumn(
                name: "TaxDeduction",
                table: "PaymentInfos");

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
    }
}
